using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDWConfigurator
{
    public partial class Form1 : Form
    {
        private EntityItem SelectedEntity
        {
            get
            {
                if (lb_EntityList.SelectedItem != null)
                {
                    IEnumerable<EntityItem> entityItems = EntityItem.EntityItems.Where(l => l.name == lb_EntityList.SelectedItem.ToString());
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
            cb_ControlEnabled.Checked = SelectedEntity.ControlEnabled;
        }

        protected void FillEntitiesList()
        {
            lb_EntityList.Items.Clear();

            //Add items to list after alphabetizing
            foreach (EntityItem item in EntityItem.EntityItems)
            {
                lb_EntityList.Items.Add(item.name);
            }
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

        private void cb_ControlEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (lb_EntityList.SelectedIndex == -1) return;
            SelectedEntity.ControlEnabled = cb_ControlEnabled.Checked;
        }

        private void b_SaveEntity_Click(object sender, EventArgs e)
        {
            SelectedEntity.SaveValues();
        }

        private void b_SaveAllEntities_Click(object sender, EventArgs e)
        {
            foreach (EntityItem item in EntityItem.EntityItems)
            {
                item.SaveValues();
            }
        }
    }
}