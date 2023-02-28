using System.Windows.Forms;

namespace NDWConfigurator
{
    public partial class Form1 : Form
    {
        public string RootDirectory;
        public SettingsFile NDWConfigSettings;

        public SettingsFile? LocationSettingsFile;

        public Form1()
        {
            NDWConfigSettings = new SettingsFile("Settings/", "Config.xml");
            RootDirectory = NDWConfigSettings.ReadSetDefault("General", "RootDirectory", "");

            if (RootDirectory == "" || !Directory.Exists(RootDirectory))
            {
                RequestRootDir();
            }

            InitializeComponent();

            // Activates double buffering
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            l_RootDirectory.Text = RootDirectory;

            LoadConfigs();
            InitVisualAssistant();
        }

        private void RequestRootDir()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result;
            while (RootDirectory == "" || !Directory.Exists(RootDirectory))
            {
                result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RootDirectory = dialog.SelectedPath;
                }
                else
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            NDWConfigSettings.SetValue("General", "RootDirectory", RootDirectory);
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestRootDir();
            l_RootDirectory.Text = RootDirectory;
            LoadConfigs();
        }

        private void LoadConfigs()
        {
            if (RootDirectory == null) return;
            if (RootDirectory == "") return;
            LocationSettingsFile = new SettingsFile(RootDirectory, "/Location/LocationSettings.xml");

            EntityItem.GetEntities(RootDirectory + "/Entities/");

            InitEntitiesTab();
            InitScenesTab();
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