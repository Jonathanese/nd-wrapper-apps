using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDWConfigurator
{
    public partial class Form1 : Form
    {
        public List<EntityItem> LocationEntityItems = new List<EntityItem>();
        public List<FloorItem> FloorItems = new List<FloorItem>();

        public enum _placemode
        { Entity, Reference, None };

        private _placemode PlaceMode = _placemode.None;

        private EntityItem SelectedLocationEntity
        {
            get
            {
                if (lb_LocationEntities.SelectedItem != null)
                {
                    IEnumerable<EntityItem> entityItems = LocationEntityItems.Where(l => l.name == lb_LocationEntities.SelectedItem.ToString());
                    if (entityItems.Any())
                    {
                        return entityItems.First();
                    }
                }
                return null;
            }
        }

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

        protected void InitLocationTab()
        {
            FillEntityLocationsList();
            FillFloorItems();
            lb_Floors.SelectedIndex = 1;
        }

        /// <summary>
        /// Fill list of entitys based on saved or default data
        /// </summary>
        protected void FillEntityLocationsList()
        {
            if (EntityLocationsFile == null) return;
            LocationEntityItems.Clear();
            foreach (EntityItem entity in EntityItems)
            {
                if (entity.LocationEnabled)
                {
                    LocationEntityItems.Add(entity);
                }
            }
            LocationEntityItems = LocationEntityItems.OrderBy(l => l.name).ToList();
        }

        /// <summary>
        /// Fill array of floor items based on saved or default data
        /// </summary>
        protected void FillFloorItems()
        {
            if (EntityLocationsFile == null || LocationSettingsFile == null) return;
            FloorItems.Clear();
            for (int i = 0; i < lb_Floors.Items.Count; i++)
            {
                FloorItems.Add(new FloorItem());
                FloorItems[i].ImagePath = RootDirectory + "/Location/Images/Floor_" + i.ToString() + ".png";

                string measure = LocationSettingsFile.ReadSetDefault("Floor" + i.ToString(), "Width_in", DefaultFloorWidth.ToString());
                FloorItems[i].Width_in = int.Parse(measure);

                measure = LocationSettingsFile.ReadSetDefault("Floor" + i.ToString(), "GroundHeight_in", ((1 - i) * 96).ToString());
                FloorItems[i].GroundHeight_in = int.Parse(measure);

                measure = LocationSettingsFile.ReadSetDefault("Floor" + i.ToString(), "ReferencePixelX", "0");
                int refx = int.Parse(measure);

                measure = LocationSettingsFile.ReadSetDefault("Floor" + i.ToString(), "ReferencePixelY", "0");
                int refy = int.Parse(measure);

                FloorItems[i].ReferencePixel = new Point(refx, refy);
            }
            ShowSelectedFloor();
        }

        /// <summary>
        /// For a given floor, populate the list of entitys on that floor
        /// </summary>
        /// <param name="floor"></param>
        protected void PopulateEntityListByFloor(int floor)
        {
            IEnumerable<EntityItem> entities = new List<EntityItem>();
            entities = LocationEntityItems.Where(l => getEntityFloor(l) == floor);
            lb_LocationEntities.Items.Clear();
            foreach (EntityItem l in entities)
            {
                lb_LocationEntities.Items.Add(l.name);
            }
            if (lb_LocationEntities.Items.Count > 0 && lb_LocationEntities.SelectedIndex == -1)
            {
                lb_LocationEntities.SelectedIndex = 0;
                PlaceSelectedEntityImage();
            }
        }

        /// <summary>
        /// Store the floorplan image into the FloorItem object
        /// </summary>
        /// <param name="floor"></param>
        /// <param name="image"></param>
        protected void StoreFloorImage(FloorItem floor, string image)
        {
            var imagefileinfo = new FileInfo(image);
            var destfileinfo = new FileInfo(floor.ImagePath);
            if (!imagefileinfo.Directory.Exists) imagefileinfo.Directory.Create();

            if (imagefileinfo.Directory.Exists)
            {
                try
                {
                    File.Copy(image, destfileinfo.FullName, true);
                }
                catch
                {
                }

                if (!(destfileinfo.Exists))
                {
                    MessageBox.Show("Could not copy image to\n" + destfileinfo.FullName);
                }
            }
            else
            {
                MessageBox.Show("Could not create directory\n" + imagefileinfo.Directory.FullName, "Error");
            }
        }

        /// <summary>
        /// Fill entity settings boxes based on chosen entity
        /// </summary>
        /// <param name="entity"></param>
        protected void DisplayEntityValue(EntityItem entity)
        {
            nud_HeightFromFloor.Value = getEntityHeightFromFloor(entity, entity.H);
            l_EntityHeightAbsolute.Text = entity.H.ToString();
            nud_North.Value = entity.N;
            nud_West.Value = entity.W;
        }

        /// <summary>
        /// Configure the form to show the contents of the currently-selected floor
        /// </summary>
        protected void ShowSelectedFloor()
        {
            if (lb_Floors.SelectedIndex > -1 && lb_Floors.SelectedIndex < FloorItems.Count)
            {
                //Check if image is valid
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

                //Set Floor Measurement Values
                nud_FloorHeight.Value = SelectedFloor.GroundHeight_in;
                nud_FloorWidth.Value = SelectedFloor.Width_in;

                //If image is valid, place items based on image
                if (validimage)
                {
                    nud_RefX.Value = SelectedFloor.ReferencePixel.X;
                    nud_RefY.Value = SelectedFloor.ReferencePixel.Y;
                    SetItemByPixel(pb_Ref, new Point((int)nud_RefX.Value, (int)nud_RefY.Value));
                }
                PopulateEntityListByFloor(lb_Floors.SelectedIndex);
                //Enable/Disable move up/down buttons
                b_MoveDown.Enabled = true;
                b_MoveUp.Enabled = true;

                if (lb_Floors.SelectedIndex == 0)
                {
                    b_MoveUp.Enabled = false;
                }
                else if (lb_Floors.SelectedIndex == lb_Floors.Items.Count - 1)
                {
                    b_MoveDown.Enabled = false;
                }

                return;
            }
            //Invalid floor selection
            pb_Floorplan.ImageLocation = "";
        }

        /// <summary>
        /// Determine which floor the entity is located on
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        private int getEntityFloor(EntityItem l)
        {
            if (l.H >= FloorItems[0].GroundHeight_in) { return 0; }
            else if (l.H < FloorItems[1].GroundHeight_in) { return 2; }
            return 1;
        }

        /// <summary>
        /// Get entity height relative to ground level
        /// </summary>
        /// <param name="l"></param>
        /// <param name="HeightFromFloor"></param>
        /// <returns></returns>
        private int getEntityHeightAbsolute(EntityItem l, int HeightFromFloor)
        {
            return HeightFromFloor + FloorItems[getEntityFloor(l)].GroundHeight_in;
        }

        private int getEntityHeightFromFloor(EntityItem l, int HeightAbsolute)
        {
            return HeightAbsolute - FloorItems[getEntityFloor(l)].GroundHeight_in;
        }

        /// <summary>
        /// Set reference point location using click event
        /// </summary>
        /// <param name="e"></param>
        private void SetRefPointByClick(EventArgs e)
        {
            if (pb_Floorplan.Image == null) return;

            Point location = GetPicturePixel(e);
            nud_RefX.Value = location.X;
            nud_RefY.Value = location.Y;
            SelectedFloor.ReferencePixel = location;
            SetItemByPixel(pb_Ref, location);
            PlaceSelectedEntityImage();
        }

        /// <summary>
        /// Set entity location using click event
        /// </summary>
        /// <param name="e"></param>
        private void SetEntityPointByClick(EventArgs e)
        {
            if (pb_Floorplan.Image == null) return;

            Point location = GetPicturePixel(e);
            SetItemByPixel(pb_Entity, location);
            SetEntityValueByPixel(location);
        }

        /// <summary>
        /// Set item position based on a pixel in the floorplan image
        /// </summary>
        /// <param name="item"></param>
        /// <param name="pixel"></param>
        private void SetItemByPixel(Control item, Point pixel)
        {
            if (pb_Floorplan.Image == null) return;
            Point EntityLocation = pixel;
            double scalar = GetFloorPlanScalar();

            //Scale to display location relative to image location
            EntityLocation = Multiply(EntityLocation, scalar);

            //Get full border thickness
            int oy = pb_Floorplan.Height - (int)(scalar * pb_Floorplan.Image.Height);
            int ox = pb_Floorplan.Width - (int)(scalar * pb_Floorplan.Image.Width);
            //Get thickness of one side of the border.
            oy /= 2;
            ox /= 2;

            EntityLocation = Add(EntityLocation, new Point(ox, oy));
            EntityLocation = Add(EntityLocation, pb_Floorplan.Location);
            EntityLocation = Subtract(EntityLocation, new Point(4, 4));

            item.Location = EntityLocation;
        }

        /// <summary>
        /// Set entity location based on pixel in the flooplan image
        /// </summary>
        /// <param name="location"></param>
        private void SetEntityValueByPixel(Point location)
        {
            //Get coordinates (pixels) of entity relative to reference
            int dx = (int)nud_RefX.Value;
            int dy = (int)nud_RefY.Value;
            //Reversed, remembering that -x is +West and -y is +North
            dx = dx - location.X;
            dy = dy - location.Y;

            SelectedLocationEntity.N = PixelsToInches(dy);
            SelectedLocationEntity.W = PixelsToInches(dx);
            nud_West.Value = SelectedLocationEntity.W;
            nud_North.Value = SelectedLocationEntity.N;
        }

        /// <summary>
        /// Place entity icon based on its stored data
        /// </summary>
        /// <param name="l"></param>
        private void PlaceSelectedEntityImage()
        {
            if (SelectedLocationEntity == null) return;
            if (pb_Floorplan.ImageLocation == "") return;

            Point location = InchesToPixelLocation(SelectedLocationEntity.W, SelectedLocationEntity.N);
            SetItemByPixel(pb_Entity, location);
        }

        /// <summary>
        /// Get the ratio at which the floorplan image is scaled into the form
        /// </summary>
        /// <returns>Displayed image size / Actual image size</returns>
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

        /// <summary>
        /// Select a entity item, switching floor if necessary
        /// </summary>
        /// <param name="l"></param>
        private void SelectEntityAndFloor(EntityItem l)
        {
            lb_Floors.SelectedIndex = getEntityFloor(l);
            //ShowentitysByFloor(lb_Floors.SelectedIndex);
            lb_LocationEntities.SelectedItem = l.name;
        }

        #region TRANSFORMS

        private int PixelsToInches(int pixels)
        {
            double InchesPerPixel = 1;
            InchesPerPixel = (double)SelectedFloor.Width_in / (double)pb_Floorplan.Image.Width;
            return (int)(InchesPerPixel * pixels);
        }

        private int InchesToPixels(int inches)
        {
            if (pb_Floorplan.Image == null) return 0;
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

        /// <summary>
        /// Get coordinates of mouse relative to the child being clicked
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private Point GetChildMouseCoords(EventArgs e)
        {
            Point location = ((MouseEventArgs)e).Location;
            location = Subtract(location, GetChildAtPoint(location).Location);
            return location;
        }

        /// <summary>
        /// Get which pixel in the image was clicked by the mouse
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
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

        #endregion TRANSFORMS

        #region GUI

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_Floors.SelectedIndex == -1) return;
            if (FloorItems.Count == 0) return;
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StoreFloorImage(SelectedFloor, dialog.FileName);
                try
                {
                    pb_Floorplan.ImageLocation = SelectedFloor.ImagePath;
                }
                catch
                {
                    MessageBox.Show("Image load failed", "Error");
                }
            }
        }

        private void lb_Entities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_LocationEntities.SelectedIndex > -1 && lb_LocationEntities.Items.Count > 0)
            {
                DisplayEntityValue(LocationEntityItems.Where(e => e.name == lb_LocationEntities.SelectedItem.ToString()).First());
                b_PlaceEntity.Enabled = true;
                nud_North.Enabled = true;
                nud_West.Enabled = true;
            }
            else
            {
                b_PlaceEntity.Enabled = false;
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
            LocationSettingsFile.SetValue("Floor" + idx.ToString(), "ImagePath", FloorItems[idx].ImagePath);
            LocationSettingsFile.SetValue("Floor" + idx.ToString(), "Width_in", FloorItems[idx].Width_in.ToString());
            LocationSettingsFile.SetValue("Floor" + idx.ToString(), "GroundHeight_in", FloorItems[idx].GroundHeight_in.ToString());
            LocationSettingsFile.SetValue("Floor" + idx.ToString(), "ReferencePixelX", FloorItems[idx].ReferencePixel.X.ToString());
            LocationSettingsFile.SetValue("Floor" + idx.ToString(), "ReferencePixelY", FloorItems[idx].ReferencePixel.Y.ToString());
        }

        private void b_SaveEntities_Click(object sender, EventArgs e)
        {
            foreach (EntityItem l in LocationEntityItems)
            {
                EntityLocationsFile.SetValue(l.name, "North_Inches", l.N.ToString());
                EntityLocationsFile.SetValue(l.name, "West_Inches", l.W.ToString());
                EntityLocationsFile.SetValue(l.name, "Height_Inches", l.H.ToString());
            }
        }

        private void b_MoveUp_Click(object sender, EventArgs e)
        {
            EntityItem entity = LocationEntityItems.Where(l => l.name == lb_LocationEntities.SelectedItem.ToString()).First();
            switch (lb_Floors.SelectedIndex)
            {
                //Already upstairs
                case 0:
                    return;
                //Main Floor -> Upstairs
                case 1:
                    entity.H += FloorItems[0].GroundHeight_in - FloorItems[1].GroundHeight_in;
                    lb_Floors.SelectedIndex = 0;
                    break;
                //Basement -> Main Floor
                case 2:
                    entity.H += FloorItems[1].GroundHeight_in - FloorItems[2].GroundHeight_in;
                    lb_Floors.SelectedIndex = 1;
                    break;
            }
            PopulateEntityListByFloor(lb_Floors.SelectedIndex);
            lb_LocationEntities.SelectedItem = entity.name;
        }

        private void b_MoveDown_Click(object sender, EventArgs e)
        {
            EntityItem entity = LocationEntityItems.Where(l => l.name == lb_LocationEntities.SelectedItem.ToString()).First();
            switch (lb_Floors.SelectedIndex)
            {
                //Upstairs -> Main Floor
                case 0:
                    entity.H -= FloorItems[0].GroundHeight_in - FloorItems[1].GroundHeight_in;
                    break;
                //Main Floor -> Basement
                case 1:
                    entity.H -= FloorItems[1].GroundHeight_in - FloorItems[2].GroundHeight_in;
                    break;
                //Already Downstairs
                case 2:
                    return;
            }
            SelectEntityAndFloor(entity);
        }

        private void nud_HeightFromFloor_ValueChanged(object sender, EventArgs e)
        {
            SelectedLocationEntity.H = getEntityHeightAbsolute(SelectedLocationEntity, (int)nud_HeightFromFloor.Value);
            DisplayEntityValue(SelectedLocationEntity);
            SelectEntityAndFloor(SelectedLocationEntity);
        }

        private void nud_West_ValueChanged(object sender, EventArgs e)
        {
            SelectedLocationEntity.W = (int)nud_West.Value;
            DisplayEntityValue(SelectedLocationEntity);
            PlaceSelectedEntityImage();
        }

        private void nud_North_ValueChanged(object sender, EventArgs e)
        {
            SelectedLocationEntity.N = (int)nud_North.Value;
            DisplayEntityValue(SelectedLocationEntity);
            PlaceSelectedEntityImage();
        }

        private void pb_Floorplan_Click(object sender, EventArgs e)
        {
            switch (PlaceMode)
            {
                case _placemode.Entity:
                    SetEntityPointByClick(e);
                    PlaceMode = _placemode.None;
                    b_PlaceEntity.ForeColor = Color.Black;
                    break;

                case _placemode.Reference:
                    SetRefPointByClick(e);
                    PlaceMode = _placemode.None;
                    b_PlaceReference.ForeColor = Color.Black;
                    break;
            }
        }

        private void pb_Floorplan_SizeChanged(object sender, EventArgs e)
        {
            if (pb_Floorplan.Image != null)
                SetItemByPixel(pb_Ref, new Point((int)nud_RefX.Value, (int)nud_RefY.Value));
            if (lb_LocationEntities.SelectedIndex != -1)
                PlaceSelectedEntityImage();
        }

        private void b_PlaceReference_Click(object sender, EventArgs e)
        {
            PlaceMode = _placemode.Reference;
            b_PlaceReference.ForeColor = Color.Lime;
        }

        private void b_PlaceEntity_Click(object sender, EventArgs e)
        {
            if (lb_LocationEntities.SelectedIndex != -1)
            {
                PlaceMode = _placemode.Entity;
                b_PlaceEntity.ForeColor = Color.Lime;
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
            PlaceSelectedEntityImage();
        }

        private void nud_RefY_ValueChanged(object sender, EventArgs e)
        {
            SetItemByPixel(pb_Ref, new Point((int)nud_RefX.Value, (int)nud_RefY.Value));
            PlaceSelectedEntityImage();
        }

        #endregion GUI
    }

    public class FloorItem
    {
        public int GroundHeight_in = 0;
        public int Width_in = 75 * 12;
        public string ImagePath = "";
        public Point ReferencePixel = new Point(0, 0);
    }
}