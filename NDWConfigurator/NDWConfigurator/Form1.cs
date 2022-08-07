namespace NDWConfigurator
{
    public partial class Form1 : Form
    {
        public string RootDirectory;
        public SettingsFile NDWConfigSettings;
        public SettingsFile? EntityLocationsFile;
        public SettingsFile? LocationSettingsFile;

        public Form1()
        {
            NDWConfigSettings = new SettingsFile("Settings/", "Config.xml");
            RootDirectory = NDWConfigSettings.ReadSetDefault("General", "RootDirectory", "");

            InitializeComponent();

            // Activates double buffering
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            if (RootDirectory == "")
            {
                l_RootDirectory.Text = "Click Here To Select Config Location";
            }
            else
            {
                l_RootDirectory.Text = RootDirectory;
            }

            LoadConfigs();
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                RootDirectory = dialog.SelectedPath;
                NDWConfigSettings.SetValue("General", "RootDirectory", RootDirectory);
                l_RootDirectory.Text = RootDirectory;
                LoadConfigs();
            }
        }

        private void LoadConfigs()
        {
            if (RootDirectory == null) return;
            if (RootDirectory == "") return;
            LocationSettingsFile = new SettingsFile(RootDirectory, "/Location/LocationSettings.xml");
            EntityLocationsFile = new SettingsFile(RootDirectory, "/Location/EntityLocations.xml");
            InitEntitiesTab();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.TabPages[tabControl.SelectedIndex] == tp_Locations)
            {
                InitLocationTab();
            }
        }
    }
}