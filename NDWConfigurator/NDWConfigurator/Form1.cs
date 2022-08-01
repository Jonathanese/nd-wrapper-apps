namespace NDWConfigurator
{
    public partial class Form1 : Form
    {
        public string RootDirectory;
        public SettingsFile NDWConfigSettings;
        public SettingsFile LightSettings;

        public Form1()
        {
            NDWConfigSettings = new SettingsFile("Settings/", "Config.xml");
            RootDirectory = NDWConfigSettings.ReadSetDefault("General", "RootDirectory", "");

            InitializeComponent();

            // Activates double buffering
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            l_RootDirectory.Text = RootDirectory;
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
            InitLightsTab();
        }
    }
}