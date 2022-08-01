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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.l_RootDirectory = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pb_Light = new System.Windows.Forms.PictureBox();
            this.pb_Ref = new System.Windows.Forms.PictureBox();
            this.b_PlaceLight = new System.Windows.Forms.Button();
            this.b_PlaceReference = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_RefY = new System.Windows.Forms.NumericUpDown();
            this.nud_RefX = new System.Windows.Forms.NumericUpDown();
            this.b_SaveLights = new System.Windows.Forms.Button();
            this.l_LightHeightAbsolute = new System.Windows.Forms.Label();
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
            this.lb_Lights = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_FloorWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_FloorHeight = new System.Windows.Forms.NumericUpDown();
            this.pb_Floorplan = new System.Windows.Forms.PictureBox();
            this.CMS_Floorplan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tt_ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Light)).BeginInit();
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
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(801, 464);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.l_RootDirectory);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pb_Light);
            this.tabPage2.Controls.Add(this.pb_Ref);
            this.tabPage2.Controls.Add(this.b_PlaceLight);
            this.tabPage2.Controls.Add(this.b_PlaceReference);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.nud_RefY);
            this.tabPage2.Controls.Add(this.nud_RefX);
            this.tabPage2.Controls.Add(this.b_SaveLights);
            this.tabPage2.Controls.Add(this.l_LightHeightAbsolute);
            this.tabPage2.Controls.Add(this.b_MoveDown);
            this.tabPage2.Controls.Add(this.b_MoveUp);
            this.tabPage2.Controls.Add(this.b_SaveFloor);
            this.tabPage2.Controls.Add(this.lb_Floors);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.nud_North);
            this.tabPage2.Controls.Add(this.nud_West);
            this.tabPage2.Controls.Add(this.nud_HeightFromFloor);
            this.tabPage2.Controls.Add(this.lb_Lights);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.nud_FloorWidth);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.nud_FloorHeight);
            this.tabPage2.Controls.Add(this.pb_Floorplan);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lights";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pb_Light
            // 
            this.pb_Light.Image = ((System.Drawing.Image)(resources.GetObject("pb_Light.Image")));
            this.pb_Light.Location = new System.Drawing.Point(179, 277);
            this.pb_Light.Name = "pb_Light";
            this.pb_Light.Size = new System.Drawing.Size(12, 12);
            this.pb_Light.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Light.TabIndex = 26;
            this.pb_Light.TabStop = false;
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
            // b_PlaceLight
            // 
            this.b_PlaceLight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_PlaceLight.Location = new System.Drawing.Point(343, 340);
            this.b_PlaceLight.Name = "b_PlaceLight";
            this.b_PlaceLight.Size = new System.Drawing.Size(81, 23);
            this.b_PlaceLight.TabIndex = 24;
            this.b_PlaceLight.Text = "Place Light";
            this.b_PlaceLight.UseVisualStyleBackColor = true;
            this.b_PlaceLight.Click += new System.EventHandler(this.b_PlaceLight_Click);
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
            this.b_SaveLights.Click += new System.EventHandler(this.b_SaveLights_Click);
            // 
            // l_LightHeightAbsolute
            // 
            this.l_LightHeightAbsolute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_LightHeightAbsolute.AutoSize = true;
            this.l_LightHeightAbsolute.Location = new System.Drawing.Point(395, 390);
            this.l_LightHeightAbsolute.Name = "l_LightHeightAbsolute";
            this.l_LightHeightAbsolute.Size = new System.Drawing.Size(62, 15);
            this.l_LightHeightAbsolute.TabIndex = 17;
            this.l_LightHeightAbsolute.Text = "(Absolute)";
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
            // lb_Lights
            // 
            this.lb_Lights.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Lights.FormattingEnabled = true;
            this.lb_Lights.ItemHeight = 15;
            this.lb_Lights.Location = new System.Drawing.Point(665, 6);
            this.lb_Lights.Name = "lb_Lights";
            this.lb_Lights.Size = new System.Drawing.Size(120, 304);
            this.lb_Lights.TabIndex = 5;
            this.lb_Lights.SelectedIndexChanged += new System.EventHandler(this.lb_Lights_SelectedIndexChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 463);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "NDW Configuration Editor";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Light)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pb_Floorplan;
        private ContextMenuStrip CMS_Floorplan;
        private ToolStripMenuItem loadImageToolStripMenuItem;
        private Label label2;
        private NumericUpDown nud_FloorWidth;
        private Label label1;
        private NumericUpDown nud_FloorHeight;
        private ListBox lb_Lights;
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
        private Label l_LightHeightAbsolute;
        private Button b_SaveLights;
        private Button b_PlaceLight;
        private Button b_PlaceReference;
        private Label label8;
        private Label label7;
        private NumericUpDown nud_RefY;
        private NumericUpDown nud_RefX;
        private PictureBox pb_Light;
        private PictureBox pb_Ref;
        private ToolTip tt_ToolTips;
    }
}