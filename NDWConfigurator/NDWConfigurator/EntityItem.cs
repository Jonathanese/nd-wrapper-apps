using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDWConfigurator
{
    public class EntityItem
    {
        public static List<EntityItem> EntityItems = new List<EntityItem>();
        public string name = "";
        public int N;
        public int W;
        public int H;
        public bool LocationEnabled;
        public bool ControlEnabled;
        public SettingsFile Settings;

        public EntityItem(SettingsFile _settings)
        {
            Settings = _settings;
            name = Path.GetFileNameWithoutExtension(Settings.Path);

            GetValues();
        }

        public static void GetEntities(string folder)
        {
            EntityItems.Clear();
            string[] entityconfigs = Directory.GetFiles(folder, "*.xml");

            foreach (string entityconfig in entityconfigs)
            {
                var EntityFileName = Path.GetFileName(entityconfig);
                EntityItems.Add(new EntityItem(new SettingsFile(folder, EntityFileName)));
            }

            EntityItems = EntityItems.OrderBy(l => l.name).ToList();
        }

        public void GetValues()
        {
            ControlEnabled = bool.Parse(Settings.GetValue("General", "ControlEnabled"));
            LocationEnabled = bool.Parse(Settings.GetValue("Location", "LocationEnabled"));
            N = int.Parse(Settings.GetValue("Location", "North"));
            W = int.Parse(Settings.GetValue("Location", "West"));
            H = int.Parse(Settings.GetValue("Location", "Height"));
        }

        public void SaveValues()
        {
            Settings.SetValue("General", "ControlEnabled", ControlEnabled.ToString());
            Settings.SetValue("Location", "LocationEnabled", LocationEnabled.ToString());
            Settings.SetValue("Location", "North", N.ToString());
            Settings.SetValue("Location", "West", W.ToString());
            Settings.SetValue("Location", "Height", H.ToString());
        }
    }
}