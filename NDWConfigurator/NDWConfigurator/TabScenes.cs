using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDWConfigurator
{
    public partial class Form1 : Form
    {
        private String ScenesDirectory;

        public void InitScenesTab()
        {
            if (RootDirectory != "")
            {
                ScenesDirectory = RootDirectory + "/Lighting/Scenes";
            }
            GetScenesList();
        }

        private void GetScenesList()
        {
            lb_ScenesList.Items.Clear();
            List<String> fileslist = Directory.GetFiles(ScenesDirectory).ToList();
            fileslist = fileslist.Where(name => name.EndsWith(".xml")).ToList();
            fileslist.Sort();
            string thisfile = "";
            foreach (String file in fileslist)
            {
                thisfile = Path.GetFileNameWithoutExtension(file);
                lb_ScenesList.Items.Add(thisfile);
            }
        }
    }
}