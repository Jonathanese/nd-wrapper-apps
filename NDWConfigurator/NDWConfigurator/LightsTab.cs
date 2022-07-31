﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDWConfigurator
{
    public partial class Form1 : Form
    {
        public IEnumerable<LightItem> LightItems = new List<LightItem>();
        public List<FloorItem> FloorItems = new List<FloorItem>();

        public enum _placemode
        { Light, Reference, None };

        private _placemode PlaceMode = _placemode.None;

        private LightItem SelectedLight
        { get { return LightItems.Where(l => l.name == lb_Lights.SelectedItem.ToString()).First(); } }

        private FloorItem SelectedFloor
        {
            get
            {
                if (lb_Floors.SelectedIndex > -1 && lb_Floors.SelectedIndex < FloorItems.Count)
                {
                    return FloorItems[lb_Floors.SelectedIndex];
                }
                else
                {
                    return FloorItems[0];
                }
            }
        }

        private int DefaultFloorWidth = new FloorItem().Width_in;

        protected void InitLightsTab()
        {
            LightSettings = new SettingsFile(RootDirectory, "/Lighting/LightConfig.xml");
            FillLightItems();
            FillFloorItems();
            lb_Floors.SelectedIndex = 1;
        }

        protected void FillLightItems()
        {
            if (LightSettings == null) return;
            foreach (string entity in LightSettings.GetSections())
            {
                LightItem item = new LightItem();
                item.name = entity;
                item.N = int.Parse(LightSettings.ReadSetDefault(entity, "North_Inches", "0"));
                item.W = int.Parse(LightSettings.ReadSetDefault(entity, "West_Inches", "0"));
                item.H = int.Parse(LightSettings.ReadSetDefault(entity, "Height_Inches", "0"));
                LightItems = LightItems.Append(item);
            }
        }

        protected void FillFloorItems()
        {
            if (LightSettings == null) return;
            FloorItems.Clear();
            for (int i = 0; i < lb_Floors.Items.Count; i++)
            {
                FloorItems.Add(new FloorItem());
                FloorItems[i].ImagePath = NDWConfigSettings.ReadSetDefault("Floor" + i.ToString(), "ImagePath", "");

                string measure = NDWConfigSettings.ReadSetDefault("Floor" + i.ToString(), "Width_in", DefaultFloorWidth.ToString());
                FloorItems[i].Width_in = int.Parse(measure);

                measure = NDWConfigSettings.ReadSetDefault("Floor" + i.ToString(), "GroundHeight_in", ((1 - i) * 96).ToString());
                FloorItems[i].GroundHeight_in = int.Parse(measure);

                measure = NDWConfigSettings.ReadSetDefault("Floor" + i.ToString(), "ReferencePixelX", "0");
                int refx = int.Parse(measure);

                measure = NDWConfigSettings.ReadSetDefault("Floor" + i.ToString(), "ReferencePixelY", "0");
                int refy = int.Parse(measure);

                FloorItems[i].ReferencePixel = new Point(refx, refy);
            }
            ShowSelectedFloor();
        }

        protected void ShowLightsByFloor(int floor)
        {
            IEnumerable<LightItem> lights = new List<LightItem>();
            lights = LightItems.Where(l => getLightFloor(l) == floor);
            lb_Lights.Items.Clear();
            foreach (LightItem l in lights)
            {
                lb_Lights.Items.Add(l.name);
            }
        }

        protected void SaveFloorImage(int floor, string image)
        {
            if (floor < 0 || floor >= lb_Floors.Items.Count || floor >= FloorItems.Count) return;

            FloorItems[lb_Floors.SelectedIndex].ImagePath = image;
        }

        protected void GetLightValues(LightItem light)
        {
            nud_HeightFromFloor.Value = getLightHeightFromFloor(light, light.H);
            l_LightHeightAbsolute.Text = light.H.ToString();
            nud_North.Value = light.N;
            nud_West.Value = light.W;
        }

        protected void ShowSelectedFloor()
        {
            if (lb_Floors.SelectedIndex > -1 && lb_Floors.SelectedIndex < FloorItems.Count)
            {
                bool validimage = false;
                if (SelectedFloor.ImagePath != "")
                {
                    try
                    {
                        pb_Floorplan.ImageLocation = SelectedFloor.ImagePath;

                        validimage = true;
                    }
                    catch { pb_Floorplan.ImageLocation = ""; }
                }

                nud_FloorHeight.Value = SelectedFloor.GroundHeight_in;
                nud_FloorWidth.Value = SelectedFloor.Width_in;

                if (validimage)
                {
                    nud_RefX.Value = SelectedFloor.ReferencePixel.X;
                    nud_RefY.Value = SelectedFloor.ReferencePixel.Y;
                    SetItemByPixel(pb_Ref, new Point((int)nud_RefX.Value, (int)nud_RefY.Value));
                    ShowLightsByFloor(lb_Floors.SelectedIndex);
                }

                b_MoveDown.Enabled = true;
                b_MoveUp.Enabled = true;

                if (lb_Floors.SelectedIndex == 0)
                {
                    b_MoveUp.Enabled = false;
                }
                else if (lb_Floors.SelectedIndex == 2)
                {
                    b_MoveDown.Enabled = false;
                }

                return;
            }
            pb_Floorplan.ImageLocation = "";
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_Floors.SelectedIndex == -1) return;
            if (FloorItems.Count == 0) return;
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pb_Floorplan.ImageLocation = dialog.FileName;
                }
                catch
                {
                    MessageBox.Show("Image load failed", "Error");
                }
                SaveFloorImage(lb_Floors.SelectedIndex, dialog.FileName);
            }
        }

        private void lb_Lights_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Lights.SelectedIndex > -1 && lb_Lights.Items.Count > 0)
            {
                GetLightValues(LightItems.Where(e => e.name == lb_Lights.SelectedItem.ToString()).First());
                b_PlaceLight.Enabled = true;
                nud_North.Enabled = true;
                nud_West.Enabled = true;
            }
            else
            {
                b_PlaceLight.Enabled = false;
                nud_North.Enabled = false;
                nud_West.Enabled = false;
            }
        }

        private void lb_Floors_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedFloor();
        }

        private void b_SaveFloor_Click(object sender, EventArgs e)
        {
            int idx = lb_Floors.SelectedIndex;
            NDWConfigSettings.SetValue("Floor" + idx.ToString(), "ImagePath", FloorItems[idx].ImagePath);
            NDWConfigSettings.SetValue("Floor" + idx.ToString(), "Width_in", FloorItems[idx].Width_in.ToString());
            NDWConfigSettings.SetValue("Floor" + idx.ToString(), "GroundHeight_in", FloorItems[idx].GroundHeight_in.ToString());
            NDWConfigSettings.SetValue("Floor" + idx.ToString(), "ReferencePixelX", FloorItems[idx].ReferencePixel.X.ToString());
            NDWConfigSettings.SetValue("Floor" + idx.ToString(), "ReferencePixelY", FloorItems[idx].ReferencePixel.Y.ToString());
        }

        private void b_SaveLights_Click(object sender, EventArgs e)
        {
            foreach (LightItem l in LightItems)
            {
                LightSettings.SetValue(l.name, "North_Inches", l.N.ToString());
                LightSettings.SetValue(l.name, "West_Inches", l.W.ToString());
                LightSettings.SetValue(l.name, "Height_Inches", l.H.ToString());
            }
        }

        private int getLightFloor(LightItem l)
        {
            if (l.H >= FloorItems[0].GroundHeight_in) { return 0; }
            else if (l.H < FloorItems[1].GroundHeight_in) { return 2; }
            return 1;
        }

        private int getLightHeightAbsolute(LightItem l, int HeightFromFloor)
        {
            return HeightFromFloor + FloorItems[getLightFloor(l)].GroundHeight_in;
        }

        private int getLightHeightFromFloor(LightItem l, int HeightAbsolute)
        {
            return HeightAbsolute - FloorItems[getLightFloor(l)].GroundHeight_in;
        }

        private void b_MoveUp_Click(object sender, EventArgs e)
        {
            LightItem light = LightItems.Where(l => l.name == lb_Lights.SelectedItem.ToString()).First();
            switch (lb_Floors.SelectedIndex)
            {
                //Already upstairs
                case 0:
                    return;
                //Main Floor -> Upstairs
                case 1:
                    light.H += FloorItems[0].GroundHeight_in - FloorItems[1].GroundHeight_in;
                    lb_Floors.SelectedIndex = 0;
                    break;
                //Basement -> Main Floor
                case 2:
                    light.H += FloorItems[1].GroundHeight_in - FloorItems[2].GroundHeight_in;
                    lb_Floors.SelectedIndex = 1;
                    break;
            }
            ShowLightsByFloor(lb_Floors.SelectedIndex);
            lb_Lights.SelectedItem = light.name;
        }

        private void b_MoveDown_Click(object sender, EventArgs e)
        {
            LightItem light = LightItems.Where(l => l.name == lb_Lights.SelectedItem.ToString()).First();
            switch (lb_Floors.SelectedIndex)
            {
                //Upstairs -> Main Floor
                case 0:
                    light.H -= FloorItems[0].GroundHeight_in - FloorItems[1].GroundHeight_in;
                    break;
                //Main Floor -> Basement
                case 1:
                    light.H -= FloorItems[1].GroundHeight_in - FloorItems[2].GroundHeight_in;
                    break;
                //Already Downstairs
                case 2:
                    return;
            }
            SelectLightAndFloor(light);
        }

        private void SelectLightAndFloor(LightItem l)
        {
            lb_Floors.SelectedIndex = getLightFloor(l);
            ShowLightsByFloor(lb_Floors.SelectedIndex);
            lb_Lights.SelectedItem = l.name;
        }

        private void nud_HeightFromFloor_ValueChanged(object sender, EventArgs e)
        {
            SelectedLight.H = getLightHeightAbsolute(SelectedLight, (int)nud_HeightFromFloor.Value);
            GetLightValues(SelectedLight);
            SelectLightAndFloor(SelectedLight);
        }

        private void nud_West_ValueChanged(object sender, EventArgs e)
        {
            SelectedLight.W = (int)nud_West.Value;
            GetLightValues(SelectedLight);
            PlaceLightImage(SelectedLight);
        }

        private void nud_North_ValueChanged(object sender, EventArgs e)
        {
            SelectedLight.N = (int)nud_North.Value;
            GetLightValues(SelectedLight);
            PlaceLightImage(SelectedLight);
        }

        private void pb_Floorplan_Click(object sender, EventArgs e)
        {
            switch (PlaceMode)
            {
                case _placemode.Light:
                    SetLightPointByClick(e);
                    PlaceMode = _placemode.None;
                    b_PlaceLight.ForeColor = Color.Black;
                    break;

                case _placemode.Reference:
                    SetRefPointByClick(e);
                    PlaceMode = _placemode.None;
                    b_PlaceReference.ForeColor = Color.Black;
                    break;
            }
        }

        private void SetRefPointByClick(EventArgs e)
        {
            if (pb_Floorplan.Image == null) return;

            Point location = GetPicturePixel(e);
            nud_RefX.Value = location.X;
            nud_RefY.Value = location.Y;
            SelectedFloor.ReferencePixel = location;
            SetItemByPixel(pb_Ref, location);
        }

        private void SetLightPointByClick(EventArgs e)
        {
            if (pb_Floorplan.Image == null) return;

            Point location = GetPicturePixel(e);
            SetItemByPixel(pb_Light, location);
            SetLightValueByPixel(location);
        }

        private void SetItemByPixel(Control item, Point pixel)
        {
            if (pb_Floorplan.Image == null) return;
            Point LightLocation = pixel;
            double scalar = GetFloorPlanScalar();

            //Scale to display location relative to image location
            LightLocation = Multiply(LightLocation, scalar);

            //Get full border thickness
            int oy = pb_Floorplan.Height - (int)(scalar * pb_Floorplan.Image.Height);
            int ox = pb_Floorplan.Width - (int)(scalar * pb_Floorplan.Image.Width);
            //Get thickness of one side of the border.
            oy /= 2;
            ox /= 2;

            LightLocation = Add(LightLocation, new Point(ox, oy));
            LightLocation = Add(LightLocation, pb_Floorplan.Location);
            LightLocation = Subtract(LightLocation, new Point(4, 4));

            item.Location = LightLocation;
        }

        private void SetLightValueByPixel(Point location)
        {
            //Get coordinates (pixels) of light relative to reference
            int dx = (int)nud_RefX.Value;
            int dy = (int)nud_RefY.Value;
            //Reversed, remembering that -x is +West and -y is +North
            dx = dx - location.X;
            dy = dy - location.Y;

            SelectedLight.N = PixelsToInches(dy);
            SelectedLight.W = PixelsToInches(dx);
            nud_West.Value = SelectedLight.W;
            nud_North.Value = SelectedLight.N;
        }

        private int PixelsToInches(int pixels)
        {
            double InchesPerPixel = 1;
            InchesPerPixel = (double)SelectedFloor.Width_in / (double)pb_Floorplan.Image.Width;
            return (int)(InchesPerPixel * pixels);
        }

        private int InchesToPixels(int inches)
        {
            double PixelsPerInch = 1;
            PixelsPerInch = (double)pb_Floorplan.Image.Width / (double)SelectedFloor.Width_in;
            return (int)(PixelsPerInch * inches);
        }

        private Point InchesToPixelLocation(int W, int N)
        {
            Point location = new Point((int)nud_RefX.Value, (int)nud_RefY.Value);
            N = InchesToPixels(N);
            W = InchesToPixels(W);
            location = Subtract(location, new Point(W, N));
            return location;
        }

        private void PlaceLightImage(LightItem l)
        {
            Point location = InchesToPixelLocation(l.W, l.N);
            SetItemByPixel(pb_Light, location);
        }

        private Point GetChildMouseCoords(EventArgs e)
        {
            Point location = ((MouseEventArgs)e).Location;
            location = Subtract(location, GetChildAtPoint(location).Location);
            return location;
        }

        private Point GetPicturePixel(EventArgs e)
        {
            Point location = GetChildMouseCoords(e);

            double scalingfactor = GetFloorPlanScalar();
            int ox = 0;
            int oy = 0;

            //Get full border thickness
            oy = pb_Floorplan.Height - (int)(scalingfactor * pb_Floorplan.Image.Height);
            ox = pb_Floorplan.Width - (int)(scalingfactor * pb_Floorplan.Image.Width);
            //Get thickness of one side of the border.
            oy /= 2;
            ox /= 2;

            location = Subtract(location, new Point(ox, oy));

            return Multiply(location, 1 / scalingfactor);
        }

        private double GetFloorPlanScalar()
        {
            if (pb_Floorplan.Image == null) return 1.0;
            double imageaspectratio = (double)pb_Floorplan.Image.Width / (double)pb_Floorplan.Image.Height;
            double pbAspectRatio = (double)pb_Floorplan.Width / (double)pb_Floorplan.Height;

            if (imageaspectratio > pbAspectRatio)
            {
                //Image is wider than container, so width determines scale
                return (double)pb_Floorplan.Width / (double)pb_Floorplan.Image.Width;
            }
            else
            {
                //Image is taller than container, so height determines scale
                return (double)pb_Floorplan.Height / (double)pb_Floorplan.Image.Height;
            }
        }

        private Point Subtract(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        private Point Add(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        private Point Multiply(Point a, double scalar)
        {
            return new Point((int)(a.X * scalar), (int)(a.Y * scalar));
        }

        private void pb_Floorplan_SizeChanged(object sender, EventArgs e)
        {
            if (pb_Floorplan.Image != null)
                SetItemByPixel(pb_Ref, new Point((int)nud_RefX.Value, (int)nud_RefY.Value));
            if (lb_Lights.SelectedIndex != -1)
                PlaceLightImage(SelectedLight);
        }

        private void b_PlaceReference_Click(object sender, EventArgs e)
        {
            PlaceMode = _placemode.Reference;
            b_PlaceReference.ForeColor = Color.Lime;
        }

        private void b_PlaceLight_Click(object sender, EventArgs e)
        {
            if (lb_Lights.SelectedIndex != -1)
            {
                PlaceMode = _placemode.Light;
                b_PlaceLight.ForeColor = Color.Lime;
            }
        }

        private void nud_FloorHeight_ValueChanged(object sender, EventArgs e)
        {
            SelectedFloor.GroundHeight_in = (int)nud_FloorHeight.Value;
        }

        private void nud_FloorWidth_ValueChanged(object sender, EventArgs e)
        {
            SelectedFloor.Width_in = (int)nud_FloorWidth.Value;
        }

        private void nud_RefX_ValueChanged(object sender, EventArgs e)
        {
            SetItemByPixel(pb_Ref, new Point((int)nud_RefX.Value, (int)nud_RefY.Value));
        }

        private void nud_RefY_ValueChanged(object sender, EventArgs e)
        {
            SetItemByPixel(pb_Ref, new Point((int)nud_RefX.Value, (int)nud_RefY.Value));
        }
    }

    public class LightItem
    {
        public string name = "";
        public int N;
        public int W;
        public int H;
    }

    public class FloorItem
    {
        public int GroundHeight_in = 0;
        public int Width_in = 75 * 12;
        public string ImagePath = "";
        public Point ReferencePixel = new Point(0, 0);
    }
}