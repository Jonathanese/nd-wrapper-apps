using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NDWConfigurator
{
    public partial class Form1 : Form
    {
        public List<keyframe> keyframes = new List<keyframe>();
        public List<colorpoint> colorpoints = new List<colorpoint>();

        public keyframe SelectedKeyframe
        {
            get
            {
                if (lb_KeyFrames.SelectedIndex > -1 && lb_KeyFrames.SelectedIndex < keyframes.Count)
                    return keyframes[lb_KeyFrames.SelectedIndex];
                else
                    return keyframes[0];
            }
        }

        public colorpoint SelectedColorpoint
        {
            get
            {
                if (lb_GradientColors.SelectedIndex > -1 && lb_GradientColors.SelectedIndex < colorpoints.Count)
                    return colorpoints[lb_GradientColors.SelectedIndex];
                else
                    return colorpoints[0];
            }
        }

        public void InitVisualAssistant()
        {
            gradientanimtimer.Stop();
            gradientanimtimer.Interval = 50;
            SetDefaults();
            GetGradientsList();
        }

        private void GetGradientsList()
        {
            lb_GradientList.Items.Clear();
            List<String> filelist = Directory.GetFiles(RootDirectory + "/Lighting/Gradients").ToList();
            filelist = filelist.Where(name => name.EndsWith(".xml")).ToList();
            filelist.Sort();
            string thisfile = "";
            foreach (String file in filelist)
            {
                thisfile = Path.GetFileNameWithoutExtension(file);
                lb_GradientList.Items.Add(thisfile);
            }
        }

        private void gradientanimtimer_Tick(object sender, EventArgs e)
        {
            tb_KeyFrame.Value++;
            tb_KeyFrame_Scroll(sender, e);
            if (tb_KeyFrame.Value >= tb_KeyFrame.Maximum)
            {
                gradientanimtimer.Stop();
                b_Gradient_play.Text = "Play";
            }
        }

        public void SetDefaults()
        {
            keyframes.Clear();
            colorpoints.Clear();
            AddKeyframe(new keyframe { position = 0 });
            AddKeyframe(new keyframe { position = 1 });
            AddColorpoint(new colorpoint { color = Color.Black, position = 0 });
            AddColorpoint(new colorpoint() { color = Color.White, position = 1 });
        }

        public void SyncColorPointsList()
        {
            int index = lb_GradientColors.SelectedIndex;
            lb_GradientColors.Items.Clear();
            gcp_1.Colors.Clear();
            int i = 0;
            foreach (colorpoint cp in colorpoints)
            {
                lb_GradientColors.Items.Add(i.ToString());
                gcp_1.AddColor(cp.color, cp.position);
                i++;
            }
            if (index > -1 && index < lb_GradientColors.Items.Count)
            {
                lb_GradientColors.SelectedIndex = index;
            }
            else
            {
                lb_KeyFrames.SelectedIndex = 0;
            }
        }

        public void SyncKeyFramesList()
        {
            int index = lb_KeyFrames.SelectedIndex;
            lb_KeyFrames.Items.Clear();
            keyframes = keyframes.OrderBy(k => k.position).ToList();
            int i = 0;
            foreach (keyframe kf in keyframes)
            {
                lb_KeyFrames.Items.Add(i.ToString());
                i++;
            }

            if (index > -1 && index < lb_KeyFrames.Items.Count)
            {
                lb_KeyFrames.SelectedIndex = index;
            }
            else
            {
                lb_KeyFrames.SelectedIndex = 0;
            }
        }

        public void AddColorpoint(colorpoint cp)
        {
            colorpoints.Add(cp);
            foreach (keyframe kf in keyframes)
            {
                kf.colorpoints.Add(cp);
            }
            SyncColorPointsList();
        }

        public void AddKeyframe(keyframe kf)
        {
            keyframes.Add(kf);
            SyncKeyFramesList();
        }

        public void RemoveColorpoint(int index)
        {
            colorpoints.RemoveAt(index);
            foreach (keyframe kf in keyframes)
            {
                kf.colorpoints.RemoveAt(index);
            }
            SyncColorPointsList();
        }

        public void RemoveKeyframe(int index)
        {
            keyframes.RemoveAt(index);
        }

        private float getRatio(float A, float B, float ab)
        {
            //Cut everything before A for both such that A = 0;
            B = B - A;
            if (B == 0) return 0; //Prevent division by zero for overlapping points.
            ab = ab - A;
            //Scale everything such that B = 1.
            ab = ab / B;
            return ab;
        }

        private float lerp(float A, float B, float ratio)
        {
            return (A * (1 - ratio) + B * ratio);
        }

        private float powerlerp(float A, float B, float ratio)
        {
            A *= A;
            B *= B;
            return (float)Math.Sqrt(lerp(A, B, ratio));
        }

        private void ShowAtPosition(float position)
        {
            keyframe A = keyframes.First();
            keyframe B = A.Clone();

            foreach (keyframe kf in keyframes)
            {
                if (kf.position <= position)
                {
                    A = kf;
                    B = kf;
                }
                else
                {
                    B = kf;
                    break;
                }
            }
            float ratio = getRatio(A.position, B.position, position);
            int r, g, b;
            for (int i = 0; i < colorpoints.Count; i++)
            {
                colorpoints[i].position = lerp(A.colorpoints[i].position, B.colorpoints[i].position, ratio);
                r = (int)powerlerp(A.colorpoints[i].color.R, B.colorpoints[i].color.R, ratio);
                g = (int)powerlerp(A.colorpoints[i].color.G, B.colorpoints[i].color.G, ratio);
                b = (int)powerlerp(A.colorpoints[i].color.B, B.colorpoints[i].color.B, ratio);
                colorpoints[i].color = Color.FromArgb(r, g, b);

                gcp_1.Colors[i].Color = colorpoints[i].color;
                gcp_1.Colors[i].Position = colorpoints[i].position;
            }
        }

        private void SaveGradient(string gradientname)
        {
            String filename = "/Lighting/Gradients/";
            if (gradientname == "")
            {
                //Filename is blank
                MessageBox.Show("Gradient name can't be blank", "Name Error");
                return;
            }

            filename += gradientname + ".xml";

            SettingsFile output = new SettingsFile(RootDirectory, filename);

            for (int k = 0; k < keyframes.Count; k++)
            {
                output.SetValue("keytimes", k.ToString(), keyframes[k].position.ToString());
                for (int c = 0; c < keyframes[0].colorpoints.Count; c++)
                {
                    output.SetValue(getKeyFrameName(k, c), "R", keyframes[k].colorpoints[c].color.R.ToString());
                    output.SetValue(getKeyFrameName(k, c), "G", keyframes[k].colorpoints[c].color.G.ToString());
                    output.SetValue(getKeyFrameName(k, c), "B", keyframes[k].colorpoints[c].color.B.ToString());
                    output.SetValue(getKeyFrameName(k, c), "A", keyframes[k].colorpoints[c].color.A.ToString());
                    output.SetValue(getKeyFrameName(k, c), "P", keyframes[k].colorpoints[c].position.ToString());
                }
            }
        }

        private void LoadGradient(string gradientname)
        {
            tb_KeyFrame.Value = 0;
            String filename = "/Lighting/Gradients/";
            if (gradientname == "")
            {
                //Filename is blank
                MessageBox.Show("Gradient name can't be blank", "Name Error");
                return;
            }

            filename += gradientname + ".xml";

            SettingsFile output = new SettingsFile(RootDirectory, filename);

            List<string> sections = output.GetSections();
            int k = 0;
            int c = 0;
            int maxk = -1;
            int maxc = -1;

            //Get maximum extents of array
            foreach (string section in sections)
            {
                getKeyFrameFromName(section, out k, out c);
                if (k > maxk) maxk = k;
                if (c > maxc) maxc = c;
            }

            int r = 0;
            int g = 0;
            int b = 0;
            int a = 0;
            float p = 0;

            //load in keyframes
            for (k = 0; k <= maxk; k++)
            {
                keyframe newkf = new keyframe();
                newkf.position = float.Parse(output.ReadSetDefault("keytimes", k.ToString(), "0"));
                for (c = 0; c <= maxc; c++)
                {
                    r = int.Parse(output.ReadSetDefault(getKeyFrameName(k, c), "R", "0"));
                    g = int.Parse(output.ReadSetDefault(getKeyFrameName(k, c), "G", "0"));
                    b = int.Parse(output.ReadSetDefault(getKeyFrameName(k, c), "B", "0"));
                    a = int.Parse(output.ReadSetDefault(getKeyFrameName(k, c), "A", "255"));
                    p = float.Parse(output.ReadSetDefault(getKeyFrameName(k, c), "P", "0"));
                    colorpoint newcp = new colorpoint();

                    newcp.color = Color.FromArgb(a, r, g, b);
                    newcp.position = p;

                    newkf.colorpoints.Add(newcp);
                }
                keyframes.Add(newkf);
            }
            SyncColorPointsList();
            SyncKeyFramesList();
        }

        private String getKeyFrameName(int keyframe, int colorpoint)
        {
            return "k" + keyframe.ToString() + "c" + colorpoint.ToString();
        }

        private bool getKeyFrameFromName(string name, out int keyframe, out int colorpoint)
        {
            keyframe = -1;
            colorpoint = -1;

            if (name.IndexOf('k') != 0)
                return false;
            if (name.IndexOf('c') == -1)
                return false;

            try
            {
                keyframe = int.Parse(name.Substring(1, name.IndexOf('c') - 1));
                colorpoint = int.Parse(name.Substring(name.IndexOf('c') + 1));
            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }

        #region GUI

        private void b_GradientColorPlus_Click(object sender, EventArgs e)
        {
            AddColorpoint(SelectedColorpoint.Clone());
        }

        private void b_KeyframePlus_Click(object sender, EventArgs e)
        {
            AddKeyframe(SelectedKeyframe.Clone());
        }

        private void lb_KeyFrames_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_KeyFrame.Value = (int)(SelectedKeyframe.position * 100);
            nud_KeyFramePosition.Value = (int)(SelectedKeyframe.position * 100);
            ShowAtPosition(((float)tb_KeyFrame.Value) / 100.0f);
        }

        private void tb_KeyFrame_Scroll(object sender, EventArgs e)
        {
            ShowAtPosition(((float)tb_KeyFrame.Value) / 100.0f);
        }

        private void lb_GradientColors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveColorpoint(lb_GradientColors.SelectedIndex);
            }
        }

        private void lb_KeyFrames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveKeyframe(lb_KeyFrames.SelectedIndex);
            }
        }

        private void gcp_1_ColorSelected(object sender, EventArgs e)
        {
            int i = 0;
            for (; i < gcp_1.Colors.Count; i++)
            {
                if (gcp_1.SelectedColor == gcp_1.Colors[i]) break;
            }

            lb_GradientColors.SelectedIndex = i;
        }

        private void b_GradientColorsSet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < colorpoints.Count; i++)
            {
                colorpoints[i].color = gcp_1.Colors[i].Color;
                colorpoints[i].position = gcp_1.Colors[i].Position;
                SelectedKeyframe.colorpoints[i] = colorpoints[i].Clone();
            }
        }

        private void nud_KeyFramePosition_ValueChanged(object sender, EventArgs e)
        {
            SelectedKeyframe.position = ((float)nud_KeyFramePosition.Value) / 100.0f;
            SyncKeyFramesList();
        }

        private void b_play_Click(object sender, EventArgs e)
        {
            if (gradientanimtimer.Enabled)
            {
                gradientanimtimer.Stop();
                b_Gradient_play.Text = "Play";
            }
            else
            {
                tb_KeyFrame.Value = 0;
                gradientanimtimer.Start();
                b_Gradient_play.Text = "Stop";
            }
        }

        private void b_Gradient_Save_Click(object sender, EventArgs e)
        {
            SaveGradient(tb_GradientName.Text);
        }

        private void b_GradientLoad_Click(object sender, EventArgs e)
        {
            if (lb_GradientList.Text == "") return;
            LoadGradient(lb_GradientList.Text);
            tb_GradientName.Text = lb_GradientList.Text;
        }

        #endregion GUI
    }

    public class keyframe
    {
        public List<colorpoint> colorpoints = new List<colorpoint>();

        public float position;

        public keyframe Clone()
        {
            keyframe clone = new keyframe();
            clone.position = position;
            foreach (colorpoint c in colorpoints)
            {
                clone.colorpoints.Add(c.Clone());
            }
            return clone;
        }
    }

    public class colorpoint
    {
        public Color color;
        public float position;

        public colorpoint Clone()
        {
            colorpoint clone = new colorpoint();
            clone.color = color;
            clone.position = position;
            return clone;
        }
    }
}