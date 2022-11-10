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
    public partial class UpdateModule : MetroSetForm
    {
        DataBaseHandler dh = new DataBaseHandler();

        List<Module> modules = new List<Module>();
        List<string> moduleCodes = new List<string>();
        public UpdateModule()
        {
            InitializeComponent();

            modules = dh.GetModules();
            foreach (var mod in modules)
            {
                moduleCodes.Add(mod.ModuleCode);
            }

            cmbCodeSelect.DataSource = moduleCodes;
            LoadInformation(cmbCodeSelect.SelectedItem.ToString());
        }

        private void LoadInformation(string code)
        {
            foreach (var mod in modules)
            {
                if (mod.ModuleCode == code)
                {
                    txtModuleName.Text = mod.ModuleName;
                    txtResource.Text = mod.ModuleResource;
                    txtModuleDescription.Text = mod.ModuleDescription;
                }
            }
        }

        private void cmbCodeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInformation(cmbCodeSelect.SelectedItem.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearFields();
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void clearFields()
        {
            txtModuleName.Text = null;
            txtResource.Text = null;
            txtModuleDescription.Text = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MetroSetMessageBox.Show(this, "Are you sure you want to update this module?", "ARE YOU SURE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Module mod = new Module();
                mod.ModuleCode = cmbCodeSelect.SelectedItem.ToString();
                mod.ModuleDescription = txtModuleDescription.Text;
                mod.ModuleName = txtModuleName.Text;
                mod.ModuleResource = txtResource.Text;
            }
        }
    }
}
