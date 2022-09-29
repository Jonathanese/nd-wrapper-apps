namespace NDWConfigurator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.GradientColorPickerItem gradientColorPickerItem3 = new System.Windows.Forms.GradientColorPickerItem();
            System.Windows.Forms.GradientColorPickerItem gradientColorPickerItem4 = new System.Windows.Forms.GradientColorPickerItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tp_General = new System.Windows.Forms.TabPage();
            this.l_RootDirectory = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tp_Entities = new System.Windows.Forms.TabPage();
            this.cb_LocationEnabled = new System.Windows.Forms.CheckBox();
            this.lb_EntityList = new System.Windows.Forms.ListBox();
            this.b_SaveAllEntities = new System.Windows.Forms.Button();
            this.b_SaveEntity = new System.Windows.Forms.Button();
            this.tp_Locations = new System.Windows.Forms.TabPage();
            this.pb_Entity = new System.Windows.Forms.PictureBox();
            this.pb_Ref = new System.Windows.Forms.PictureBox();
            this.b_PlaceEntity = new System.Windows.Forms.Button();
            this.b_PlaceReference = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_RefY = new System.Windows.Forms.NumericUpDown();
            this.nud_RefX = new System.Windows.Forms.NumericUpDown();
            this.b_SaveLights = new System.Windows.Forms.Button();
            this.l_EntityHeightAbsolute = new System.Windows.Forms.Label();
            this.b_MoveDown = new System.Windows.Forms.Button();
            this.b_MoveUp = new System.Windows.Forms.Button();
            this.b_SaveFloor = new System.Windows.Forms.Button();
            this.lb_Floors = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_North = new System.Windows.Forms.NumericUpDown();
            this.nud_West = new System.Windows.Forms.NumericUpDown();
            this.nud_HeightFromFloor = new System.Windows.Forms.NumericUpDown();
            this.lb_LocationEntities = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_FloorWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_FloorHeight = new System.Windows.Forms.NumericUpDown();
            this.pb_Floorplan = new System.Windows.Forms.PictureBox();
            this.CMS_Floorplan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tp_Scenes = new System.Windows.Forms.TabPage();
            this.lv_SceneValues = new System.Windows.Forms.ListView();
            this.ch_Setting = new System.Windows.Forms.ColumnHeader();
            this.ch_Value = new System.Windows.Forms.ColumnHeader();
            this.lb_ScenesList = new System.Windows.Forms.ListBox();
            this.tp_VisualAssistant = new System.Windows.Forms.TabPage();
            this.b_play = new System.Windows.Forms.Button();
            this.nud_KeyFramePosition = new System.Windows.Forms.NumericUpDown();
            this.b_GradientColorsSet = new System.Windows.Forms.Button();
            this.b_KeyframePlus = new System.Windows.Forms.Button();
            this.lb_KeyFrames = new System.Windows.Forms.ListBox();
            this.lb_GradientColors = new System.Windows.Forms.ListBox();
            this.b_GradientColorPlus = new System.Windows.Forms.Button();
            this.tb_KeyFrame = new System.Windows.Forms.TrackBar();
            this.gcp_1 = new System.Windows.Forms.GradientColorPicker();
            this.tt_ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.gradientanimtimer = new System.Windows.Forms.Timer(this.components);
            this.tb_SceneValue = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tp_General.SuspendLayout();
            this.tp_Entities.SuspendLayout();
            this.tp_Locations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Entity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RefY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RefX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_North)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_West)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HeightFromFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_FloorWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_FloorHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Floorplan)).BeginInit();
            this.CMS_Floorplan.SuspendLayout();
            this.tp_Scenes.SuspendLayout();
            this.tp_VisualAssistant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_KeyFramePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_KeyFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tp_General);
            this.tabControl.Controls.Add(this.tp_Entities);
            this.tabControl.Controls.Add(this.tp_Locations);
            this.tabControl.Controls.Add(this.tp_Scenes);
            this.tabControl.Controls.Add(this.tp_VisualAssistant);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(801, 464);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tp_General
            // 
            this.tp_General.Controls.Add(this.l_RootDirectory);
            this.tp_General.Controls.Add(this.label6);
            this.tp_General.Location = new System.Drawing.Point(4, 24);
            this.tp_General.Name = "tp_General";
            this.tp_General.Padding = new System.Windows.Forms.Padding(3);
            this.tp_General.Size = new System.Drawing.Size(793, 436);
            this.tp_General.TabIndex = 0;
            this.tp_General.Text = "General";
            this.tp_General.UseVisualStyleBackColor = true;
            // 
            // l_RootDirectory
            // 
            this.l_RootDirectory.AutoSize = true;
            this.l_RootDirectory.Location = new System.Drawing.Point(79, 3);
            this.l_RootDirectory.Name = "l_RootDirectory";
            this.l_RootDirectory.Size = new System.Drawing.Size(83, 15);
            this.l_RootDirectory.TabIndex = 1;
            this.l_RootDirectory.Text = "None Selected";
            this.l_RootDirectory.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Root Path: ";
            // 
            // tp_Entities
            // 
            this.tp_Entities.Controls.Add(this.cb_LocationEnabled);
            this.tp_Entities.Controls.Add(this.lb_EntityList);
            this.tp_Entities.Controls.Add(this.b_SaveAllEntities);
            this.tp_Entities.Controls.Add(this.b_SaveEntity);
            this.tp_Entities.Location = new System.Drawing.Point(4, 24);
            this.tp_Entities.Name = "tp_Entities";
            this.tp_Entities.Size = new System.Drawing.Size(793, 436);
            this.tp_Entities.TabIndex = 4;
            this.tp_Entities.Text = "Entities";
            this.tp_Entities.UseVisualStyleBackColor = true;
            // 
            // cb_LocationEnabled
            // 
            this.cb_LocationEnabled.AutoSize = true;
            this.cb_LocationEnabled.Location = new System.Drawing.Point(195, 81);
            this.cb_LocationEnabled.Name = "cb_LocationEnabled";
            this.cb_LocationEnabled.Size = new System.Drawing.Size(117, 19);
            this.cb_LocationEnabled.TabIndex = 4;
            this.cb_LocationEnabled.Text = "Location Enabled";
            this.cb_LocationEnabled.UseVisualStyleBackColor = true;
            this.cb_LocationEnabled.CheckedChanged += new System.EventHandler(this.cb_LocationEnabled_CheckedChanged);
            // 
            // lb_EntityList
            // 
            this.lb_EntityList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_EntityList.FormattingEnabled = true;
            this.lb_EntityList.ItemHeight = 15;
            this.lb_EntityList.Location = new System.Drawing.Point(8, 3);
            this.lb_EntityList.Name = "lb_EntityList";
            this.lb_EntityList.Size = new System.Drawing.Size(181, 424);
            this.lb_EntityList.TabIndex = 3;
            this.lb_EntityList.SelectedIndexChanged += new System.EventHandler(this.lb_EntityList_SelectedIndexChanged);
            // 
            // b_SaveAllEntities
            // 
            this.b_SaveAllEntities.Location = new System.Drawing.Point(710, 404);
            this.b_SaveAllEntities.Name = "b_SaveAllEntities";
            this.b_SaveAllEntities.Size = new System.Drawing.Size(75, 23);
            this.b_SaveAllEntities.TabIndex = 2;
            this.b_SaveAllEntities.Text = "Save All";
            this.b_SaveAllEntities.UseVisualStyleBackColor = true;
            this.b_SaveAllEntities.Click += new System.EventHandler(this.b_SaveAllEntities_Click);
            // 
            // b_SaveEntity
            // 
            this.b_SaveEntity.Location = new System.Drawing.Point(629, 404);
            this.b_SaveEntity.Name = "b_SaveEntity";
            this.b_SaveEntity.Size = new System.Drawing.Size(75, 23);
            this.b_SaveEntity.TabIndex = 1;
            this.b_SaveEntity.Text = "Save";
            this.b_SaveEntity.UseVisualStyleBackColor = true;
            this.b_SaveEntity.Click += new System.EventHandler(this.b_SaveEntity_Click);
            // 
            // tp_Locations
            // 
            this.tp_Locations.Controls.Add(this.pb_Entity);
            this.tp_Locations.Controls.Add(this.pb_Ref);
            this.tp_Locations.Controls.Add(this.b_PlaceEntity);
            this.tp_Locations.Controls.Add(this.b_PlaceReference);
            this.tp_Locations.Controls.Add(this.label8);
            this.tp_Locations.Controls.Add(this.label7);
            this.tp_Locations.Controls.Add(this.nud_RefY);
            this.tp_Locations.Controls.Add(this.nud_RefX);
            this.tp_Locations.Controls.Add(this.b_SaveLights);
            this.tp_Locations.Controls.Add(this.l_EntityHeightAbsolute);
            this.tp_Locations.Controls.Add(this.b_MoveDown);
            this.tp_Locations.Controls.Add(this.b_MoveUp);
            this.tp_Locations.Controls.Add(this.b_SaveFloor);
            this.tp_Locations.Controls.Add(this.lb_Floors);
            this.tp_Locations.Controls.Add(this.label5);
            this.tp_Locations.Controls.Add(this.label4);
            this.tp_Locations.Controls.Add(this.label3);
            this.tp_Locations.Controls.Add(this.nud_North);
            this.tp_Locations.Controls.Add(this.nud_West);
            this.tp_Locations.Controls.Add(this.nud_HeightFromFloor);
            this.tp_Locations.Controls.Add(this.lb_LocationEntities);
            this.tp_Locations.Controls.Add(this.label2);
            this.tp_Locations.Controls.Add(this.nud_FloorWidth);
            this.tp_Locations.Controls.Add(this.label1);
            this.tp_Locations.Controls.Add(this.nud_FloorHeight);
            this.tp_Locations.Controls.Add(this.pb_Floorplan);
            this.tp_Locations.Location = new System.Drawing.Point(4, 24);
            this.tp_Locations.Name = "tp_Locations";
            this.tp_Locations.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Locations.Size = new System.Drawing.Size(793, 436);
            this.tp_Locations.TabIndex = 1;
            this.tp_Locations.Text = "Locations";
            this.tp_Locations.UseVisualStyleBackColor = true;
            // 
            // pb_Entity
            // 
            this.pb_Entity.Image = ((System.Drawing.Image)(resources.GetObject("pb_Entity.Image")));
            this.pb_Entity.Location = new System.Drawing.Point(179, 277);
            this.pb_Entity.Name = "pb_Entity";
            this.pb_Entity.Size = new System.Drawing.Size(12, 12);
            this.pb_Entity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Entity.TabIndex = 26;
            this.pb_Entity.TabStop = false;
            // 
            // pb_Ref
            // 
            this.pb_Ref.Image = ((System.Drawing.Image)(resources.GetObject("pb_Ref.Image")));
            this.pb_Ref.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_Ref.InitialImage")));
            this.pb_Ref.Location = new System.Drawing.Point(179, 298);
            this.pb_Ref.Name = "pb_Ref";
            this.pb_Ref.Size = new System.Drawing.Size(12, 12);
            this.pb_Ref.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Ref.TabIndex = 25;
            this.pb_Ref.TabStop = false;
            // 
            // b_PlaceEntity
            // 
            this.b_PlaceEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_PlaceEntity.Location = new System.Drawing.Point(343, 340);
            this.b_PlaceEntity.Name = "b_PlaceEntity";
            this.b_PlaceEntity.Size = new System.Drawing.Size(81, 23);
            this.b_PlaceEntity.TabIndex = 24;
            this.b_PlaceEntity.Text = "Place Entity";
            this.b_PlaceEntity.UseVisualStyleBackColor = true;
            this.b_PlaceEntity.Click += new System.EventHandler(this.b_PlaceEntity_Click);
            // 
            // b_PlaceReference
            // 
            this.b_PlaceReference.Location = new System.Drawing.Point(8, 190);
            this.b_PlaceReference.Name = "b_PlaceReference";
            this.b_PlaceReference.Size = new System.Drawing.Size(155, 23);
            this.b_PlaceReference.TabIndex = 23;
            this.b_PlaceReference.Text = "Place Reference";
            this.tt_ToolTips.SetToolTip(this.b_PlaceReference, "Reference point is used for consistent coordinates across floors.\r\n\r\nReference po" +
        "int should go to the furthest south-east point, and be consistent across all flo" +
        "ors.");
            this.b_PlaceReference.UseVisualStyleBackColor = true;
            this.b_PlaceReference.Click += new System.EventHandler(this.b_PlaceReference_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Reference Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Reference X";
            // 
            // nud_RefY
            // 
            this.nud_RefY.Location = new System.Drawing.Point(106, 161);
            this.nud_RefY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_RefY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nud_RefY.Name = "nud_RefY";
            this.nud_RefY.Size = new System.Drawing.Size(57, 23);
            this.nud_RefY.TabIndex = 20;
            this.nud_RefY.ValueChanged += new System.EventHandler(this.nud_RefY_ValueChanged);
            // 
            // nud_RefX
            // 
            this.nud_RefX.Location = new System.Drawing.Point(106, 132);
            this.nud_RefX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_RefX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nud_RefX.Name = "nud_RefX";
            this.nud_RefX.Size = new System.Drawing.Size(57, 23);
            this.nud_RefX.TabIndex = 19;
            this.nud_RefX.ValueChanged += new System.EventHandler(this.nud_RefX_ValueChanged);
            // 
            // b_SaveLights
            // 
            this.b_SaveLights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_SaveLights.Location = new System.Drawing.Point(712, 404);
            this.b_SaveLights.Name = "b_SaveLights";
            this.b_SaveLights.Size = new System.Drawing.Size(75, 23);
            this.b_SaveLights.TabIndex = 18;
            this.b_SaveLights.Text = "Save Lights";
            this.b_SaveLights.UseVisualStyleBackColor = true;
            this.b_SaveLights.Click += new System.EventHandler(this.b_SaveEntities_Click);
            // 
            // l_EntityHeightAbsolute
            // 
            this.l_EntityHeightAbsolute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_EntityHeightAbsolute.AutoSize = true;
            this.l_EntityHeightAbsolute.Location = new System.Drawing.Point(395, 390);
            this.l_EntityHeightAbsolute.Name = "l_EntityHeightAbsolute";
            this.l_EntityHeightAbsolute.Size = new System.Drawing.Size(62, 15);
            this.l_EntityHeightAbsolute.TabIndex = 17;
            this.l_EntityHeightAbsolute.Text = "(Absolute)";
            // 
            // b_MoveDown
            // 
            this.b_MoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_MoveDown.Location = new System.Drawing.Point(369, 386);
            this.b_MoveDown.Name = "b_MoveDown";
            this.b_MoveDown.Size = new System.Drawing.Size(20, 23);
            this.b_MoveDown.TabIndex = 16;
            this.b_MoveDown.Text = "↓";
            this.b_MoveDown.UseVisualStyleBackColor = true;
            this.b_MoveDown.Click += new System.EventHandler(this.b_MoveDown_Click);
            // 
            // b_MoveUp
            // 
            this.b_MoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_MoveUp.Location = new System.Drawing.Point(343, 386);
            this.b_MoveUp.Name = "b_MoveUp";
            this.b_MoveUp.Size = new System.Drawing.Size(20, 23);
            this.b_MoveUp.TabIndex = 15;
            this.b_MoveUp.Text = "↑";
            this.b_MoveUp.UseVisualStyleBackColor = true;
            this.b_MoveUp.Click += new System.EventHandler(this.b_MoveUp_Click);
            // 
            // b_SaveFloor
            // 
            this.b_SaveFloor.Location = new System.Drawing.Point(8, 277);
            this.b_SaveFloor.Name = "b_SaveFloor";
            this.b_SaveFloor.Size = new System.Drawing.Size(75, 23);
            this.b_SaveFloor.TabIndex = 14;
            this.b_SaveFloor.Text = "Save Floor";
            this.b_SaveFloor.UseVisualStyleBackColor = true;
            this.b_SaveFloor.Click += new System.EventHandler(this.b_SaveFloor_Click);
            // 
            // lb_Floors
            // 
            this.lb_Floors.FormattingEnabled = true;
            this.lb_Floors.ItemHeight = 15;
            this.lb_Floors.Items.AddRange(new object[] {
            "Second Floor",
            "Main Floor",
            "Basement"});
            this.lb_Floors.Location = new System.Drawing.Point(8, 6);
            this.lb_Floors.Name = "lb_Floors";
            this.lb_Floors.Size = new System.Drawing.Size(120, 49);
            this.lb_Floors.TabIndex = 13;
            this.lb_Floors.SelectedIndexChanged += new System.EventHandler(this.lb_Floors_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Height From Floor";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "West";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "North";
            // 
            // nud_North
            // 
            this.nud_North.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nud_North.Location = new System.Drawing.Point(279, 328);
            this.nud_North.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_North.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nud_North.Name = "nud_North";
            this.nud_North.Size = new System.Drawing.Size(58, 23);
            this.nud_North.TabIndex = 9;
            this.nud_North.ValueChanged += new System.EventHandler(this.nud_North_ValueChanged);
            // 
            // nud_West
            // 
            this.nud_West.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nud_West.Location = new System.Drawing.Point(279, 357);
            this.nud_West.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_West.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nud_West.Name = "nud_West";
            this.nud_West.Size = new System.Drawing.Size(58, 23);
            this.nud_West.TabIndex = 8;
            this.nud_West.ValueChanged += new System.EventHandler(this.nud_West_ValueChanged);
            // 
            // nud_HeightFromFloor
            // 
            this.nud_HeightFromFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nud_HeightFromFloor.Location = new System.Drawing.Point(279, 386);
            this.nud_HeightFromFloor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_HeightFromFloor.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nud_HeightFromFloor.Name = "nud_HeightFromFloor";
            this.nud_HeightFromFloor.Size = new System.Drawing.Size(58, 23);
            this.nud_HeightFromFloor.TabIndex = 7;
            this.nud_HeightFromFloor.ValueChanged += new System.EventHandler(this.nud_HeightFromFloor_ValueChanged);
            // 
            // lb_LocationEntities
            // 
            this.lb_LocationEntities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_LocationEntities.FormattingEnabled = true;
            this.lb_LocationEntities.ItemHeight = 15;
            this.lb_LocationEntities.Location = new System.Drawing.Point(665, 6);
            this.lb_LocationEntities.Name = "lb_LocationEntities";
            this.lb_LocationEntities.Size = new System.Drawing.Size(120, 304);
            this.lb_LocationEntities.TabIndex = 5;
            this.lb_LocationEntities.SelectedIndexChanged += new System.EventHandler(this.lb_Entities_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // nud_FloorWidth
            // 
            this.nud_FloorWidth.Location = new System.Drawing.Point(106, 90);
            this.nud_FloorWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_FloorWidth.Name = "nud_FloorWidth";
            this.nud_FloorWidth.Size = new System.Drawing.Size(57, 23);
            this.nud_FloorWidth.TabIndex = 3;
            this.nud_FloorWidth.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.nud_FloorWidth.ValueChanged += new System.EventHandler(this.nud_FloorWidth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ground Height";
            // 
            // nud_FloorHeight
            // 
            this.nud_FloorHeight.Location = new System.Drawing.Point(106, 61);
            this.nud_FloorHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_FloorHeight.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nud_FloorHeight.Name = "nud_FloorHeight";
            this.nud_FloorHeight.Size = new System.Drawing.Size(57, 23);
            this.nud_FloorHeight.TabIndex = 1;
            this.nud_FloorHeight.Value = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.nud_FloorHeight.ValueChanged += new System.EventHandler(this.nud_FloorHeight_ValueChanged);
            // 
            // pb_Floorplan
            // 
            this.pb_Floorplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Floorplan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Floorplan.ContextMenuStrip = this.CMS_Floorplan;
            this.pb_Floorplan.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pb_Floorplan.Location = new System.Drawing.Point(169, 6);
            this.pb_Floorplan.Name = "pb_Floorplan";
            this.pb_Floorplan.Size = new System.Drawing.Size(490, 316);
            this.pb_Floorplan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Floorplan.TabIndex = 0;
            this.pb_Floorplan.TabStop = false;
            this.pb_Floorplan.WaitOnLoad = true;
            this.pb_Floorplan.SizeChanged += new System.EventHandler(this.pb_Floorplan_SizeChanged);
            this.pb_Floorplan.Click += new System.EventHandler(this.pb_Floorplan_Click);
            // 
            // CMS_Floorplan
            // 
            this.CMS_Floorplan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem});
            this.CMS_Floorplan.Name = "CMS_Floorplan";
            this.CMS_Floorplan.Size = new System.Drawing.Size(137, 26);
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // tp_Scenes
            // 
            this.tp_Scenes.Controls.Add(this.tb_SceneValue);
            this.tp_Scenes.Controls.Add(this.lv_SceneValues);
            this.tp_Scenes.Controls.Add(this.lb_ScenesList);
            this.tp_Scenes.Location = new System.Drawing.Point(4, 24);
            this.tp_Scenes.Name = "tp_Scenes";
            this.tp_Scenes.Size = new System.Drawing.Size(793, 436);
            this.tp_Scenes.TabIndex = 3;
            this.tp_Scenes.Text = "Scenes";
            this.tp_Scenes.UseVisualStyleBackColor = true;
            // 
            // lv_SceneValues
            // 
            this.lv_SceneValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_SceneValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Setting,
            this.ch_Value});
            this.lv_SceneValues.Location = new System.Drawing.Point(139, 3);
            this.lv_SceneValues.Name = "lv_SceneValues";
            this.lv_SceneValues.Size = new System.Drawing.Size(187, 395);
            this.lv_SceneValues.TabIndex = 2;
            this.lv_SceneValues.UseCompatibleStateImageBehavior = false;
            this.lv_SceneValues.View = System.Windows.Forms.View.Details;
            // 
            // ch_Setting
            // 
            this.ch_Setting.Text = "Setting";
            this.ch_Setting.Width = 120;
            // 
            // ch_Value
            // 
            this.ch_Value.Text = "Value";
            // 
            // lb_ScenesList
            // 
            this.lb_ScenesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_ScenesList.FormattingEnabled = true;
            this.lb_ScenesList.ItemHeight = 15;
            this.lb_ScenesList.Location = new System.Drawing.Point(8, 3);
            this.lb_ScenesList.Name = "lb_ScenesList";
            this.lb_ScenesList.Size = new System.Drawing.Size(125, 424);
            this.lb_ScenesList.TabIndex = 0;
            // 
            // tp_VisualAssistant
            // 
            this.tp_VisualAssistant.Controls.Add(this.b_play);
            this.tp_VisualAssistant.Controls.Add(this.nud_KeyFramePosition);
            this.tp_VisualAssistant.Controls.Add(this.b_GradientColorsSet);
            this.tp_VisualAssistant.Controls.Add(this.b_KeyframePlus);
            this.tp_VisualAssistant.Controls.Add(this.lb_KeyFrames);
            this.tp_VisualAssistant.Controls.Add(this.lb_GradientColors);
            this.tp_VisualAssistant.Controls.Add(this.b_GradientColorPlus);
            this.tp_VisualAssistant.Controls.Add(this.tb_KeyFrame);
            this.tp_VisualAssistant.Controls.Add(this.gcp_1);
            this.tp_VisualAssistant.Location = new System.Drawing.Point(4, 24);
            this.tp_VisualAssistant.Name = "tp_VisualAssistant";
            this.tp_VisualAssistant.Padding = new System.Windows.Forms.Padding(3);
            this.tp_VisualAssistant.Size = new System.Drawing.Size(793, 436);
            this.tp_VisualAssistant.TabIndex = 5;
            this.tp_VisualAssistant.Text = "Visual Assistant";
            this.tp_VisualAssistant.UseVisualStyleBackColor = true;
            // 
            // b_play
            // 
            this.b_play.Location = new System.Drawing.Point(9, 157);
            this.b_play.Name = "b_play";
            this.b_play.Size = new System.Drawing.Size(75, 23);
            this.b_play.TabIndex = 10;
            this.b_play.Text = "Play";
            this.b_play.UseVisualStyleBackColor = true;
            this.b_play.Click += new System.EventHandler(this.b_play_Click);
            // 
            // nud_KeyFramePosition
            // 
            this.nud_KeyFramePosition.Location = new System.Drawing.Point(710, 156);
            this.nud_KeyFramePosition.Name = "nud_KeyFramePosition";
            this.nud_KeyFramePosition.Size = new System.Drawing.Size(75, 23);
            this.nud_KeyFramePosition.TabIndex = 9;
            this.nud_KeyFramePosition.ValueChanged += new System.EventHandler(this.nud_KeyFramePosition_ValueChanged);
            // 
            // b_GradientColorsSet
            // 
            this.b_GradientColorsSet.Location = new System.Drawing.Point(710, 77);
            this.b_GradientColorsSet.Name = "b_GradientColorsSet";
            this.b_GradientColorsSet.Size = new System.Drawing.Size(75, 23);
            this.b_GradientColorsSet.TabIndex = 8;
            this.b_GradientColorsSet.Text = "Set";
            this.b_GradientColorsSet.UseVisualStyleBackColor = true;
            this.b_GradientColorsSet.Click += new System.EventHandler(this.b_GradientColorsSet_Click);
            // 
            // b_KeyframePlus
            // 
            this.b_KeyframePlus.Location = new System.Drawing.Point(710, 106);
            this.b_KeyframePlus.Name = "b_KeyframePlus";
            this.b_KeyframePlus.Size = new System.Drawing.Size(23, 23);
            this.b_KeyframePlus.TabIndex = 7;
            this.b_KeyframePlus.Text = "+";
            this.b_KeyframePlus.UseVisualStyleBackColor = true;
            this.b_KeyframePlus.Click += new System.EventHandler(this.b_KeyframePlus_Click);
            // 
            // lb_KeyFrames
            // 
            this.lb_KeyFrames.FormattingEnabled = true;
            this.lb_KeyFrames.ItemHeight = 15;
            this.lb_KeyFrames.Location = new System.Drawing.Point(658, 106);
            this.lb_KeyFrames.Name = "lb_KeyFrames";
            this.lb_KeyFrames.Size = new System.Drawing.Size(46, 109);
            this.lb_KeyFrames.TabIndex = 6;
            this.lb_KeyFrames.SelectedIndexChanged += new System.EventHandler(this.lb_KeyFrames_SelectedIndexChanged);
            this.lb_KeyFrames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_KeyFrames_KeyDown);
            // 
            // lb_GradientColors
            // 
            this.lb_GradientColors.FormattingEnabled = true;
            this.lb_GradientColors.ItemHeight = 15;
            this.lb_GradientColors.Location = new System.Drawing.Point(658, 6);
            this.lb_GradientColors.Name = "lb_GradientColors";
            this.lb_GradientColors.Size = new System.Drawing.Size(46, 94);
            this.lb_GradientColors.TabIndex = 5;
            this.lb_GradientColors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_GradientColors_KeyDown);
            // 
            // b_GradientColorPlus
            // 
            this.b_GradientColorPlus.Location = new System.Drawing.Point(710, 6);
            this.b_GradientColorPlus.Name = "b_GradientColorPlus";
            this.b_GradientColorPlus.Size = new System.Drawing.Size(23, 23);
            this.b_GradientColorPlus.TabIndex = 2;
            this.b_GradientColorPlus.Text = "+";
            this.b_GradientColorPlus.UseVisualStyleBackColor = true;
            this.b_GradientColorPlus.Click += new System.EventHandler(this.b_GradientColorPlus_Click);
            // 
            // tb_KeyFrame
            // 
            this.tb_KeyFrame.Location = new System.Drawing.Point(9, 106);
            this.tb_KeyFrame.Maximum = 100;
            this.tb_KeyFrame.Name = "tb_KeyFrame";
            this.tb_KeyFrame.Size = new System.Drawing.Size(642, 45);
            this.tb_KeyFrame.TabIndex = 1;
            this.tb_KeyFrame.Scroll += new System.EventHandler(this.tb_KeyFrame_Scroll);
            // 
            // gcp_1
            // 
            this.gcp_1.AllowAddColorByClick = false;
            this.gcp_1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.gcp_1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.gcp_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gcp_1.ColorItemBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gcp_1.ColorItemWidth = 6;
            gradientColorPickerItem3.Position = 0F;
            gradientColorPickerItem4.Position = 1F;
            this.gcp_1.Colors.Add(gradientColorPickerItem3);
            this.gcp_1.Colors.Add(gradientColorPickerItem4);
            this.gcp_1.GradientLayout = System.Windows.Forms.GradientColorPickerLayout.Percent;
            this.gcp_1.GradientLayoutSize = 75;
            this.gcp_1.Location = new System.Drawing.Point(9, 6);
            this.gcp_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gcp_1.Name = "gcp_1";
            this.gcp_1.SelectedColor = null;
            this.gcp_1.Size = new System.Drawing.Size(642, 84);
            this.gcp_1.TabIndex = 0;
            this.gcp_1.ColorSelected += new System.EventHandler(this.gcp_1_ColorSelected);
            // 
            // gradientanimtimer
            // 
            this.gradientanimtimer.Tick += new System.EventHandler(this.gradientanimtimer_Tick);
            // 
            // tb_SceneValue
            // 
            this.tb_SceneValue.Location = new System.Drawing.Point(139, 404);
            this.tb_SceneValue.Name = "tb_SceneValue";
            this.tb_SceneValue.Size = new System.Drawing.Size(187, 23);
            this.tb_SceneValue.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 463);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "NDW Configuration Editor";
            this.tabControl.ResumeLayout(false);
            this.tp_General.ResumeLayout(false);
            this.tp_General.PerformLayout();
            this.tp_Entities.ResumeLayout(false);
            this.tp_Entities.PerformLayout();
            this.tp_Locations.ResumeLayout(false);
            this.tp_Locations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Entity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RefY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RefX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_North)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_West)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HeightFromFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_FloorWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_FloorHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Floorplan)).EndInit();
            this.CMS_Floorplan.ResumeLayout(false);
            this.tp_Scenes.ResumeLayout(false);
            this.tp_Scenes.PerformLayout();
            this.tp_VisualAssistant.ResumeLayout(false);
            this.tp_VisualAssistant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_KeyFramePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_KeyFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tabControl;
        private TabPage tp_General;
        private TabPage tp_Locations;
        private PictureBox pb_Floorplan;
        private ContextMenuStrip CMS_Floorplan;
        private ToolStripMenuItem loadImageToolStripMenuItem;
        private Label label2;
        private NumericUpDown nud_FloorWidth;
        private Label label1;
        private NumericUpDown nud_FloorHeight;
        private ListBox lb_LocationEntities;
        private Label label5;
        private Label label4;
        private Label label3;
        private NumericUpDown nud_North;
        private NumericUpDown nud_West;
        private NumericUpDown nud_HeightFromFloor;
        private ListBox lb_Floors;
        private Label l_RootDirectory;
        private Label label6;
        private Button b_SaveFloor;
        private Button b_MoveDown;
        private Button b_MoveUp;
        private Label l_EntityHeightAbsolute;
        private Button b_SaveLights;
        private Button b_PlaceEntity;
        private Button b_PlaceReference;
        private Label label8;
        private Label label7;
        private NumericUpDown nud_RefY;
        private NumericUpDown nud_RefX;
        private PictureBox pb_Entity;
        private PictureBox pb_Ref;
        private ToolTip tt_ToolTips;
        private TabPage tp_Scenes;
        private TabPage tp_Entities;
        private Button b_SaveAllEntities;
        private Button b_SaveEntity;
        private ListBox lb_EntityList;
        private CheckBox cb_LocationEnabled;
        private ListView lv_SceneValues;
        private ColumnHeader ch_Setting;
        private ColumnHeader ch_Value;
        private ListBox lb_ScenesList;
        private TabPage tp_VisualAssistant;
        private TrackBar tb_KeyFrame;
        private Button b_GradientColorPlus;
        private Button b_KeyframePlus;
        private ListBox lb_KeyFrames;
        private ListBox lb_GradientColors;
        private GradientColorPicker gcp_1;
        private NumericUpDown nud_KeyFramePosition;
        private Button b_GradientColorsSet;
        private Button b_play;
        private System.Windows.Forms.Timer gradientanimtimer;
        private TextBox tb_SceneValue;
    }
}