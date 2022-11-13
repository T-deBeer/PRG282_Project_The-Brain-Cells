using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_The_Brain_Cells
{


    public partial class Dashboard : MetroSetForm
    {
        DataHandler data = new DataHandler();

        DataBaseHandler dh = new DataBaseHandler();

        List<string> tables = new List<string>();
        List<Module> modules = new List<Module>();
        List<Student> students = new List<Student>();
        List<Composite> composite = new List<Composite>();
        List<Credential> creds = new List<Credential>();

        bool searched = false;
        List<Module> tempmodules = new List<Module>();
        List<Student> tempstudents = new List<Student>();
        List<Composite> tempcomposite = new List<Composite>();
        List<Credential> tempcreds = new List<Credential>();


        public Dashboard()
        {
            int SortByHold;
            InitializeComponent();

            tables = dh.GetTables();
            modules = dh.GetModules();
            students = dh.GetStudents();
            composite = dh.GetComposite();
            creds = dh.GetCreds();

            cmbTableSelect.DataSource = tables;
            SortByHold = cmbTableSelect.SelectedIndex;

            LoadDataView(cmbTableSelect.SelectedItem.ToString());
            cmbSortByUpdate(SortByHold);
        }

        public void LoadDataView(string tableName)
        {
            if (tableName == "ModuleTable")
            {
                data.AddToLogFile("Viewed Module Table");
                dgvDataBaseView.DataSource = null;
                dgvDataBaseView.DataSource = modules;

                btnAdd.Enabled = true;
                btnRemove.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else if (tableName == "StudentTable")
            {
                data.AddToLogFile("Viewed Student Table");
                dgvDataBaseView.DataSource = null;
                dgvDataBaseView.DataSource = students;

                btnAdd.Enabled = true;
                btnRemove.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else if (tableName == "CompositeTable")
            {
                data.AddToLogFile("Viewed Composite Table");
                dgvDataBaseView.DataSource = null;
                dgvDataBaseView.DataSource = composite;

                btnAdd.Enabled = false;
                btnRemove.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else if (tableName == "CredentialTable")
            {
                data.AddToLogFile("Viewed Credential Table");
                dgvDataBaseView.DataSource = null;
                dgvDataBaseView.DataSource = creds;

                btnAdd.Enabled = true;
                btnRemove.Enabled = true;
                btnUpdate.Enabled = false;
            }

        }

        private void cmbTableSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
 searched = false;
            LoadDataView(cmbTableSelect.SelectedItem.ToString());
            cmbSortByUpdate(cmbTableSelect.SelectedIndex);
           
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

        public void cmbSortByUpdate(int tableSelected)
        {
            List<string> cmbOptions = new List<string>();
            switch (tableSelected)
            {
                case 0:
                    {
                        cmbOptions.Add("Sort by Module Code");
                        cmbOptions.Add("Sort by Module Name");
                        break;
                    }
                case 1:
                    {
                        cmbOptions.Add("Sort by Student Number");
                        cmbOptions.Add("Sort by Module Code");

                        break;
                    }
                case 2:
                    {
                        cmbOptions.Add("Sort by Username");
                        cmbOptions.Add("Unsort");

                        break;
                    }
                case 3:
                    {
                        cmbOptions.Add("Sort by Student Number");
                        cmbOptions.Add("Sort by Student Name");

                        break;
                    }
                default:
                    break;
            }
            cmbSortBy.DataSource = cmbOptions;
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

        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            searched = false;
            int tableIndex = cmbTableSelect.SelectedIndex;
            dgvDataBaseView.DataSource = null;

            switch (tableIndex)
            {
                case 0:
                    {
                        if (cmbSortBy.SelectedIndex == 0)
                            modules.Sort((a, b) => a.ModuleCode.CompareTo(b.ModuleCode));
                        else
                            modules.Sort((a, b) => a.ModuleName.CompareTo(b.ModuleName));

                        dgvDataBaseView.DataSource = modules;
                        break;
                    }
                case 1:
                    {
                        if (cmbSortBy.SelectedIndex == 0)
                            composite.Sort((a, b) => a.StudentNumber.CompareTo(b.StudentNumber));

                        else
                            composite.Sort((a, b) => a.ModuleCode.CompareTo(b.ModuleCode));

                        dgvDataBaseView.DataSource = composite;
                        break;
                    }
                case 2:
                    {
                        if (cmbSortBy.SelectedIndex == 0)
                            creds.Sort((a, b) => a.Username.CompareTo(b.Username));
                        else
                            creds.Sort((a, b) => a.Password.CompareTo(b.Password));

                        dgvDataBaseView.DataSource = creds;
                        break;
                    }
                case 3:
                    {
                        if (cmbSortBy.SelectedIndex == 0)
                            students.Sort((a, b) => a.StudentNumber.CompareTo(b.StudentNumber));
                        else
                            students.Sort((a, b) => a.StudentName.CompareTo(b.StudentName));


                        dgvDataBaseView.DataSource = students;
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tableName = cmbTableSelect.SelectedItem.ToString();

            searched = false;
            if (!String.IsNullOrWhiteSpace((txtSearch.Text)))
            {
                searched = true;
                if (tableName == "ModuleTable")
                {
                    string s = txtSearch.Text.ToLower();

                     tempmodules = new List<Module>();
                    foreach (Module mod in modules)
                    {
                        if (mod.ModuleCode.ToLower().Contains(s) || mod.ModuleName.ToLower().Contains(s) || mod.ModuleDescription.ToLower().Contains(s) || mod.ModuleResource.ToLower().Contains(s))
                        {
                          tempmodules.Add(mod);    
                        }
            
                    }
                   
                    dgvDataBaseView.DataSource = null;
                    dgvDataBaseView.DataSource = tempmodules;
                }
                else if (tableName == "StudentTable")
                {
                    string s = txtSearch.Text.ToLower();

                     tempstudents = new List<Student>();
                    foreach (Student student in students)
                    {
                        if (student.StudentName.ToLower().Contains(s) || 
                            student.StudentSurname.ToLower().Contains(s) || 
                            student.StudentPhone.ToLower().Contains(s) || 
                            student.StudentDOB.ToString().ToLower().Contains(s)||
                                Convert.ToString(student.StudentNumber).ToLower().Contains(s)||
                                student.StudentGender.ToLower().Contains(s)||
                                student.StudentAddress.ToLower().Contains(s))
                        {
                            tempstudents.Add(student);
                        }

                    }
                    dgvDataBaseView.DataSource = null;
                    dgvDataBaseView.DataSource = tempstudents;

                }
                else if (tableName == "CompositeTable")
                {
                 /*Can be coded, or left, depending on need*/
                }
                else if (tableName == "CredentialTable")
                {
                    /*Can be coded, or left, depending on need*/
                }
            }

            }

            public void updateRTB()
            {
                int selectedIndex;
                int selectedTable;
                rtbEdit.ResetText();

                selectedTable = cmbTableSelect.SelectedIndex;

            if (!searched)
            {
                switch (selectedTable)
                {
                    case 0:
                        {
                            if (dgvDataBaseView.CurrentRow.Index > modules.Count)
                            {
                                selectedIndex = 0;
                            }
                            else
                            {
                                selectedIndex = dgvDataBaseView.CurrentRow.Index;
                            }

                            rtbEdit.Text = rtbEdit.Text + "MODULE NAME: \n";
                            rtbEdit.Text = rtbEdit.Text + modules[selectedIndex].ModuleName + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "MODULE CODE: \n";
                            rtbEdit.Text = rtbEdit.Text + modules[selectedIndex].ModuleCode + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "MODULE DESCRIPTION: \n";
                            rtbEdit.Text = rtbEdit.Text + modules[selectedIndex].ModuleDescription + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "MODULE RESOURCE: \n";
                            rtbEdit.Text = rtbEdit.Text + modules[selectedIndex].ModuleResource;

                            break;
                        }
                    case 1:
                        {
                            /*Can be coded, or left, depending on need*/


                            break;
                        }
                    case 2:
                        {
                            /*Can be coded, or left, depending on need*/
                            break;
                        }
                    case 3:
                        {
                            if (dgvDataBaseView.CurrentRow.Index > students.Count)
                            {
                                selectedIndex = 0;
                            }
                            else
                            {
                                selectedIndex = dgvDataBaseView.CurrentRow.Index;
                            }

                            rtbEdit.Text = rtbEdit.Text + "STUDENT NUMBER: \n";
                            rtbEdit.Text = rtbEdit.Text + students[selectedIndex].StudentNumber + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "NAME: \n";
                            rtbEdit.Text = rtbEdit.Text + students[selectedIndex].StudentName + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "SURNAME: \n";
                            rtbEdit.Text = rtbEdit.Text + students[selectedIndex].StudentSurname + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "DATE OF BIRTH: \n";
                            rtbEdit.Text = rtbEdit.Text + students[selectedIndex].StudentDOB + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "GENDER: \n";
                            rtbEdit.Text = rtbEdit.Text + students[selectedIndex].StudentGender + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "PHONE NUMBER: \n";
                            rtbEdit.Text = rtbEdit.Text + students[selectedIndex].StudentPhone + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "HOME ADDRESS: \n";
                            rtbEdit.Text = rtbEdit.Text + students[selectedIndex].StudentAddress + "\n\n";
                            break;
                        }
                    default:
                        break;
                } 
            }
            else
            {
                switch (selectedTable)
                {
                    case 0:
                        {
                            if (dgvDataBaseView.CurrentRow.Index > tempmodules.Count)
                            {
                                selectedIndex = 0;
                            }
                            else
                            {
                                selectedIndex = dgvDataBaseView.CurrentRow.Index;
                            }

                            rtbEdit.Text = rtbEdit.Text + "MODULE NAME: \n";
                            rtbEdit.Text = rtbEdit.Text + tempmodules[selectedIndex].ModuleName + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "MODULE CODE: \n";
                            rtbEdit.Text = rtbEdit.Text + tempmodules[selectedIndex].ModuleCode + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "MODULE DESCRIPTION: \n";
                            rtbEdit.Text = rtbEdit.Text + tempmodules[selectedIndex].ModuleDescription + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "MODULE RESOURCE: \n";
                            rtbEdit.Text = rtbEdit.Text + tempmodules[selectedIndex].ModuleResource;

                            break;
                        }
                    case 1:
                        {
                            /*Can be coded, or left, depending on need*/


                            break;
                        }
                    case 2:
                        {
                            /*Can be coded, or left, depending on need*/
                            break;
                        }
                    case 3:
                        {
                            if (dgvDataBaseView.CurrentRow.Index > tempstudents.Count)
                            {
                                selectedIndex = 0;
                            }
                            else
                            {
                                selectedIndex = dgvDataBaseView.CurrentRow.Index;
                            }

                            rtbEdit.Text = rtbEdit.Text + "STUDENT NUMBER: \n";
                            rtbEdit.Text = rtbEdit.Text + tempstudents[selectedIndex].StudentNumber + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "NAME: \n";
                            rtbEdit.Text = rtbEdit.Text + tempstudents[selectedIndex].StudentName + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "SURNAME: \n";
                            rtbEdit.Text = rtbEdit.Text + tempstudents[selectedIndex].StudentSurname + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "DATE OF BIRTH: \n";
                            rtbEdit.Text = rtbEdit.Text + tempstudents[selectedIndex].StudentDOB + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "GENDER: \n";
                            rtbEdit.Text = rtbEdit.Text + tempstudents[selectedIndex].StudentGender + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "PHONE NUMBER: \n";
                            rtbEdit.Text = rtbEdit.Text + tempstudents[selectedIndex].StudentPhone + "\n\n";
                            rtbEdit.Text = rtbEdit.Text + "HOME ADDRESS: \n";
                            rtbEdit.Text = rtbEdit.Text + tempstudents[selectedIndex].StudentAddress + "\n\n";
                            break;
                        }
                    default:
                        break;
                }
                searched = false;

            }

            }

            private void dgvDataBaseView_SelectionChanged(object sender, EventArgs e)
            {
                updateRTB();
            }

            private void btnRemove_Click(object sender, EventArgs e)
            {
                string tableName = cmbTableSelect.SelectedItem.ToString();
                int selectedIndex = dgvDataBaseView.CurrentRow.Index;

                if (tableName == "ModuleTable")
                {
                    if (DialogResult.Yes == MetroSetMessageBox.Show(this, "Are you sure you want to remove this record?", "ARE YOU SURE?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        dh.RemoveCompModule(modules[selectedIndex].ModuleCode);
                        foreach (var mod in modules.Where(x => x.ModuleCode == modules[selectedIndex].ModuleCode))
                        {
                            dh.RemoveModule(mod);
                        }
                    }
                }
                else if (tableName == "StudentTable")
                {
                    if (DialogResult.Yes == MetroSetMessageBox.Show(this, "Are you sure you want to remove this record?", "ARE YOU SURE?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        dh.RemoveCompStudent(students[selectedIndex].StudentNumber);
                        foreach (var stud in students.Where(x => x.StudentNumber == students[selectedIndex].StudentNumber))
                        {
                            dh.RemoveStudent(stud);
                        }
                    }
                }
                else if (tableName == "CredentialTable")
                {
                    if (DialogResult.Yes == MetroSetMessageBox.Show(this, "Are you sure you want to remove this record?", "ARE YOU SURE?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        foreach (var cred in creds.Where(x => x.Username == creds[selectedIndex].Username))
                        {
                            dh.RemoveCredential(cred);
                        }
                    }
                }
            }

            private void btnBack_Click(object sender, EventArgs e)
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
        }
    }
