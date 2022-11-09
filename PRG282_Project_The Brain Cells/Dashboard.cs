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
    public partial class Dashboard : MetroSetForm
    {
        DataBaseHandler dh = new DataBaseHandler();

        List<string> tables = new List<string>();
        List<Module> modules = new List<Module>();
        List<Student> students = new List<Student>();
        List<Composite> composite = new List<Composite>();
        List<Credential> creds = new List<Credential>();

        public Dashboard()
        {
            InitializeComponent();

            tables = dh.GetTables();
            modules = dh.GetModules();
            students = dh.GetStudents();
            composite = dh.GetComposite();
            creds = dh.GetCreds();

            cmbTableSelect.DataSource = tables;
            LoadDataView(cmbTableSelect.SelectedItem.ToString());
        }

        public void LoadDataView(string tableName)
        {
            if (tableName == "ModuleTable")
            {
                dgvDataBaseView.DataSource = null;
                dgvDataBaseView.DataSource = modules;

                btnAdd.Enabled = true;
                btnRemove.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else if (tableName == "StudentTable")
            {
                dgvDataBaseView.DataSource = null;
                dgvDataBaseView.DataSource = students;

                btnAdd.Enabled = true;
                btnRemove.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else if (tableName == "CompositeTable")
            {
                dgvDataBaseView.DataSource = null;
                dgvDataBaseView.DataSource = composite;

                btnAdd.Enabled = false;
                btnRemove.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else if (tableName == "CredentialTable")
            {
                dgvDataBaseView.DataSource = null;
                dgvDataBaseView.DataSource = creds;

                btnAdd.Enabled = true;
                btnRemove.Enabled = true;
                btnUpdate.Enabled = false;
            }
        }

        private void cmbTableSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataView(cmbTableSelect.SelectedItem.ToString());
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int selectedRow = dgvDataBaseView.CurrentCell.RowIndex;
            if (selectedRow > 0)
            {
                dgvDataBaseView.Rows[selectedRow].Selected = false;
                dgvDataBaseView.Rows[selectedRow - 1].Selected = true;
                dgvDataBaseView.CurrentCell = dgvDataBaseView[0, selectedRow - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int selectedRow = dgvDataBaseView.CurrentCell.RowIndex;
            if (selectedRow < dgvDataBaseView.Rows.Count - 1)
            {
                dgvDataBaseView.Rows[selectedRow].Selected = false;
                dgvDataBaseView.Rows[selectedRow + 1].Selected = true;
                dgvDataBaseView.CurrentCell = dgvDataBaseView[0, selectedRow + 1];
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tableName = cmbTableSelect.SelectedItem.ToString();

            if (tableName == "ModuleTable")
            {
                AddModule addModule = new AddModule();
                addModule.ShowDialog();
                this.Hide();
            }
            else if (tableName == "StudentTable")
            {
                AddStudent addStudent = new AddStudent();
                addStudent.ShowDialog();
                this.Hide();
            }
            else if (tableName == "CredentialTable")
            {
                AddCredentials addCredentials = new AddCredentials();
                addCredentials.ShowDialog();
                this.Hide();
            }
        }

        private void dgvDataBaseView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDataBaseView.DataSource == creds)
            {
                if (e.ColumnIndex == 1 && e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string tableName = cmbTableSelect.SelectedItem.ToString();
            if (tableName == "ModuleTable")
            {
                UpdateModule update = new UpdateModule();
                update.ShowDialog();
                this.Hide();
            }
            else if (tableName == "StudentTable")
            {
                UpdateStudent updateStudent = new UpdateStudent();
                updateStudent.ShowDialog();
                this.Hide();
            }
        }
    }
}
