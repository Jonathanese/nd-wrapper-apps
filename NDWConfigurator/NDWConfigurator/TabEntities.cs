using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDWConfigurator
{
    public partial class Form1 : Form
    {
        private List<EntityItem> EntityItems = new List<EntityItem>();

        private EntityItem SelectedEntity
        {
            get
            {
                if (lb_EntityList.SelectedItem != null)
                {
                    IEnumerable<EntityItem> entityItems = EntityItems.Where(l => l.name == lb_EntityList.SelectedItem.ToString());
                    if (entityItems.Any())
                    {
                        return entityItems.First();
                    }
                }
                return null;
            }
        }

        protected void InitEntitiesTab()
        {
            FillEntitiesList();
        }

        protected void FillEntityInfo()
        {
            if (SelectedEntity == null) return;
            cb_LocationEnabled.Checked = SelectedEntity.LocationEnabled;
        }

        protected void FillEntitiesList()
        {
            if (EntityLocationsFile == null) return;
            lb_EntityList.Items.Clear();
            foreach (string entity in EntityLocationsFile.GetSections())
            {
                var item = new EntityItem();
                item.name = entity;
                item.LocationEnabled = bool.Parse(EntityLocationsFile.ReadSetDefault(entity, "Location_Enabled", "false"));
                item.N = int.Parse(EntityLocationsFile.ReadSetDefault(entity, "North_Inches", "0"));
                item.W = int.Parse(EntityLocationsFile.ReadSetDefault(entity, "West_Inches", "0"));
                item.H = int.Parse(EntityLocationsFile.ReadSetDefault(entity, "Height_Inches", "0"));
                EntityItems.Add(item);
            }
            EntityItems = EntityItems.OrderBy(l => l.name).ToList();
            //Add items to list after alphabetizing
            foreach (EntityItem item in EntityItems)
            {
                lb_EntityList.Items.Add(item.name);
            }
        }

        private void SaveEntity(EntityItem entity)
        {
            EntityLocationsFile.SetValue(entity.name, "Location_Enabled", entity.LocationEnabled.ToString());
        }

        private void lb_EntityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_EntityList.SelectedIndex == -1) return;
            FillEntityInfo();
        }

        private void cb_LocationEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (lb_EntityList.SelectedIndex == -1) return;
            SelectedEntity.LocationEnabled = cb_LocationEnabled.Checked;
        }

        private void b_SaveEntity_Click(object sender, EventArgs e)
        {
            if (EntityLocationsFile == null) return;
            try
            {
                SaveEntity(SelectedEntity);
            }
            catch
            {
                MessageBox.Show("Save Failed");
            }
        }

        private void b_SaveAllEntities_Click(object sender, EventArgs e)
        {
            if (EntityLocationsFile == null) return;
            try
            {
                foreach (EntityItem item in EntityItems)
                {
                    SaveEntity(item);
                }
            }
            catch
            {
                MessageBox.Show("Save Failed");
            }
        }
    }

    public class EntityItem
    {
        public string name = "";
        public int N;
        public int W;
        public int H;
        public bool LocationEnabled;
    }
}