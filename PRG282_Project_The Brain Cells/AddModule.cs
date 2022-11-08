using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_The_Brain_Cells
{
    public partial class AddModule : MetroSetForm
    {
        DataBaseHandler dh = new DataBaseHandler();
      
        /*List<Module> modules = new List<Module>();*/
        List<Module> modulesToAdd = new List<Module>();

        public AddModule()
        {
            InitializeComponent();
            DataSet modules= new DataSet();
            modules = dh.GetModules();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void ClearFields()
        {
            txtModuleCode.Text = null;
            txtModuleDescription.Text = null;
            txtModuleName.Text = null;
            txtResource.Text = null;
        }

        private bool ValidateInput()
        {
            DataSet modules = new DataSet();
            DataTable table = new DataTable();
            table = modules.Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["ModuleCode"].ToString() == txtModuleCode.Text || table.Rows[i]["ModuleName"].ToString() == txtModuleName.Text)
                {
                    return false;
                }
            }
            /*
            foreach (DataTable table in modules.Tables)
            {
                foreach (var row in table.Rows)
                {
                   if (["ModuleCode"].ToString() == txtModuleCode.Text || ["ModuleName"].ToString() == txtModuleName.Text)
                {
                    return false;
                }
                }
               
            }*/

            if ( String.IsNullOrWhiteSpace(txtModuleCode.Text) || String.IsNullOrWhiteSpace(txtModuleName.Text) )
            {
                return false;
            }

            if (!txtResource.Text.Contains("http") || !txtResource.Text.Contains("www"))
            {
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Module mod = new Module
                { 
                    ModuleCode = txtModuleCode.Text,
                    ModuleName = txtModuleName.Text,
                    ModuleDescription = txtModuleDescription.Text,
                    ModuleResource = txtResource.Text
                };
                modulesToAdd.Add(mod);
                lbxToAdd.Items.Add(mod.Display());
            }
            else
            {
                MetroSetMessageBox.Show(this, "One or more problems with input.\nEnsure resource is a link and no fielda are empty."
                    , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (modulesToAdd.Count>=1)
            {
                foreach (var mod in modulesToAdd)
                {
                    dh.AddModule(mod);
                }
            }
            else
            {
                MetroSetMessageBox.Show(this, "Enter the details of a new module before writing to database."
                    , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
