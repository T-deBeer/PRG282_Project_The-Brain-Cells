using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_The_Brain_Cells
{
    public partial class AddModule : MetroSetForm
    {
        DataBaseHandler dh = new DataBaseHandler();

        List<Module> modules = new List<Module>();
        List<Module> modulesToAdd = new List<Module>();

        public AddModule()
        {
            InitializeComponent();
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
            modulesToAdd.Clear();
            lbxToAdd.Clear();
        }

        private bool ValidateInput()
        {
            foreach (var item in modules)
            {
                if (item.ModuleCode == txtModuleCode.Text || item.ModuleName == txtModuleName.Text)
                {
                    return false;
                }
            }

            if (txtModuleCode.Text == "" || txtModuleCode.Text == " " || txtModuleName.Text == "" || txtModuleName.Text == " ")
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
            if (DialogResult.Yes == MetroSetMessageBox.Show(this, "Are you sure you want to add this module's information?", "ARE YOU SURE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (modulesToAdd.Count >= 1)
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
            ClearFields();
        }
    }
}
