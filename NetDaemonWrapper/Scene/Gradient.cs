using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NetDaemonWrapper
{
    [NetDaemonApp]
    internal class GradientManager
    {
        private ILogger logger;

        public GradientManager(IHaContext _ha, ILogger<GradientManager> _logger)
        {
            logger = _logger;
            logger.LogInformation("Build Gradient List");
            BuildGradientList();
        }

        private void BuildGradientList()
        {
            //Clear existing gradients
            Gradient.Gradients.Clear();

            //Check if the gradient directory exists. If not, create it.
            if (!Directory.Exists(PATHS.CONFIG_BASE + PATHS.GRADIENTS))
            {
                Directory.CreateDirectory(PATHS.CONFIG_BASE + PATHS.GRADIENTS);
            }

            List<String> gfilelist = Directory.GetFiles(PATHS.CONFIG_BASE + PATHS.GRADIENTS).ToList();
            gfilelist = gfilelist.Where(name => name.EndsWith(".xml")).ToList();
            gfilelist.Sort();

            string thisfile = "";
            string logline = "";
            foreach (String gfile in gfilelist)
            {
                thisfile = Path.GetFileNameWithoutExtension(gfile);
                Gradient.Gradients.Add(new Gradient(thisfile));
                logline = "- " + thisfile;
                logline += " Keyframes: " + Gradient.Gradients.Last().keyframes.Count().ToString();
                logline += " Colorpoints: " + Gradient.Gradients.Last().keyframes[0].colorpoints.Count().ToString();
                logger.LogInformation(logline);
            }
        }
    }

    internal class Gradient
    {
        public static List<Gradient> Gradients = new List<Gradient>();
        private string name = "";
        private SettingsFile GradientFile;
        public List<keyframe> keyframes;

        public Gradient(string _name)
        {
            GradientFile = new SettingsFile(PATHS.GRADIENTS + _name + ".xml");
            keyframes = new List<keyframe>();
            name = _name;
            build();
        }

        private void build()
        {
            keyframes.Clear();
            List<string> sections = GradientFile.GetSections();
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

            for (k = 0; k <= maxk; k++)
            {
                keyframe newkf = new keyframe();
                newkf.position = float.Parse(GradientFile.ReadSetDefault("keytimes", k.ToString(), "0"));
                for (c = 0; c <= maxc; c++)
                {
                    r = int.Parse(GradientFile.ReadSetDefault(getKeyFrameName(k, c), "R", "0"));
                    g = int.Parse(GradientFile.ReadSetDefault(getKeyFrameName(k, c), "G", "0"));
                    b = int.Parse(GradientFile.ReadSetDefault(getKeyFrameName(k, c), "B", "0"));
                    a = int.Parse(GradientFile.ReadSetDefault(getKeyFrameName(k, c), "A", "255"));
                    p = float.Parse(GradientFile.ReadSetDefault(getKeyFrameName(k, c), "P", "0"));
                    colorpoint newcp = new colorpoint();

                    newcp.color = Color.FromArgb(a, r, g, b);
                    newcp.position = p;

                    newkf.colorpoints.Add(newcp);
                }
                keyframes.Add(newkf);
            }
        }

        public static Gradient? getGradientFromName(string name)
        {
            return Gradients.Find(g => (g.name == name));
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

        private keyframe GetIntermediateKeyframe(float time)
        {
            int A = 0;
            int B = 0;

            for (int kf = 0; kf < keyframes.Count; kf++)
            {
                if (keyframes[kf].position <= time)
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
            //This condition occurs before or after the extents
            if (A == B) return keyframes[A];

            keyframe newkf = new keyframe();
            newkf.position = time;
            float ratio = Utils.getRatio(keyframes[A].position, keyframes[B].position, time);

            for (int cp = 0; cp < keyframes[A].colorpoints.Count; cp++)
            {
                colorpoint newcp = new colorpoint();
                newcp.position = Utils.lerp(keyframes[A].colorpoints[cp].position, keyframes[B].colorpoints[cp].position, ratio);
                newcp.color = Color.FromArgb(
                    (int)Utils.lerp(keyframes[A].colorpoints[cp].color.A, keyframes[B].colorpoints[cp].color.A, ratio),
                    (int)Utils.lerp(keyframes[A].colorpoints[cp].color.R, keyframes[B].colorpoints[cp].color.R, ratio),
                    (int)Utils.lerp(keyframes[A].colorpoints[cp].color.G, keyframes[B].colorpoints[cp].color.G, ratio),
                    (int)Utils.lerp(keyframes[A].colorpoints[cp].color.B, keyframes[B].colorpoints[cp].color.B, ratio));
                newkf.colorpoints.Add(newcp);
            }

            return newkf;
        }

        private Color GetColorFromPosition(keyframe kf, float position)
        {
            colorpoint A = kf.colorpoints.First();
            colorpoint B = A.Clone();

            //Iterate through each color point until the threshold is met
            //Set A and B to be the nearest points.
            foreach (colorpoint cp in kf.colorpoints)
            {
                if (cp.position <= position)
                {
                    //We are lower than the threshold
                    A = cp;
                    B = cp;
                    //If we run out of colorpoints here, we are out of bounds. This is fine.
                    //Just return the max and we get to skip some math.
                }
                else
                {
                    //We are above the threshold. This mean this is the next point above our requested point.
                    B = cp;
                    break;
                }
            }

            //This condition occurs above and below the extents
            if (A == B) return B.color;

            float ratio = Utils.getRatio(A.position, B.position, position);

            return Color.FromArgb(
                (int)Utils.lerp(A.color.A, B.color.A, ratio),
                (int)Utils.lerp(A.color.R, B.color.R, ratio),
                (int)Utils.lerp(A.color.G, B.color.G, ratio),
                (int)Utils.lerp(A.color.B, B.color.B, ratio));
        }

        public Color GetColor(float position, float time)
        {
            return GetColorFromPosition(GetIntermediateKeyframe(time), position);
        }
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