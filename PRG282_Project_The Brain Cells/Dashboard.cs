using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_The_Brain_Cells
{
    public partial class Dashboard : MetroSetForm
    {
        //Declaration of global variables
        DataHandler data = new DataHandler();
        DataBaseHandler dbh = new DataBaseHandler();

        List<string> tables = new List<string>();
        List<Module> modules = new List<Module>();
        List<Student> students = new List<Student>();
        List<Composite> composite = new List<Composite>();
        List<Credential> creds = new List<Credential>();



        public Dashboard()
        {
            int SortByHold;
            InitializeComponent();
            //Populates the lists
            tables = dbh.GetTables();
            modules = dbh.GetModules();
            students = dbh.GetStudents();
            composite = dbh.GetComposite();
            creds = dbh.GetCreds();

            cmbTableSelect.DataSource = tables;

            SortByHold = cmbTableSelect.SelectedIndex;

            LoadDataView(cmbTableSelect.SelectedItem.ToString());
            cmbSortByUpdate(SortByHold);
        }

        public void LoadDataView(string tableName)
        {
            //Populates the dataGridView based on selected table in the dropdown
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
        public void cmbSortByUpdate(int tableSelected)
        {
            //Case that changes the drop down sort options

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

        private void cmbTableSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Calls methods to populate dataGridView and sort drop down
            LoadDataView(cmbTableSelect.SelectedItem.ToString());
            cmbSortByUpdate(cmbTableSelect.SelectedIndex);

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //Selects the previous row in dataGridView
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
            //Selects the next row in dataGridView
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
            //Exits the applicataion
            if (DialogResult.Yes == MetroSetMessageBox.Show(this, "Are you sure you want to quit the application?", "ARE YOU SURE?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                Application.Exit();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Opens adding forms based on the selected table
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
                SignUpForm signUpForm = new SignUpForm();
                signUpForm.ShowDialog();
                this.Hide();
            }
        }

        private void dgvDataBaseView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Changes the second column in the dataGridView to hide passwords when displaying the credentials
            if (dgvDataBaseView.DataSource.GetType() == creds.GetType())
            {
                if (e.ColumnIndex == 1 && e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Opens update forms based on the selected table
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
            int tableIndex = cmbTableSelect.SelectedIndex;
            //changes the sort options based on the selected table
            switch (tableIndex)
            {
                case 0:
                    {

                        List<Module> data = new List<Module>();
                        data = (List<Module>)dgvDataBaseView.DataSource;

                        if (cmbSortBy.SelectedIndex == 0)
                            data.Sort((a, b) => a.ModuleCode.CompareTo(b.ModuleCode));
                        else
                            data.Sort((a, b) => a.ModuleName.CompareTo(b.ModuleName));

                        dgvDataBaseView.DataSource = null;
                        dgvDataBaseView.DataSource = data;

                        break;
                    }
                case 1:
                    {

                        List<Composite> data = new List<Composite>();
                        data = (List<Composite>)dgvDataBaseView.DataSource;

                        if (cmbSortBy.SelectedIndex == 0)
                            data.Sort((a, b) => a.StudentNumber.CompareTo(b.StudentNumber));

                        else
                            data.Sort((a, b) => a.ModuleCode.CompareTo(b.ModuleCode));

                        dgvDataBaseView.DataSource = null;
                        dgvDataBaseView.DataSource = data;

                        break;
                    }
                case 2:
                    {

                        List<Credential> data = new List<Credential>();
                        data = (List<Credential>)dgvDataBaseView.DataSource;

                        if (cmbSortBy.SelectedIndex == 0)
                            data.Sort((a, b) => a.Username.CompareTo(b.Username));
                        else
                            data.Sort((a, b) => a.Password.CompareTo(b.Password));

                        dgvDataBaseView.DataSource = null;
                        dgvDataBaseView.DataSource = data;

                        break;
                    }
                case 3:
                    {

                        List<Student> data = new List<Student>();
                        data = (List<Student>)dgvDataBaseView.DataSource;

                        if (cmbSortBy.SelectedIndex == 0)
                            data.Sort((a, b) => a.StudentNumber.CompareTo(b.StudentNumber));
                        else
                            data.Sort((a, b) => a.StudentName.CompareTo(b.StudentName));

                        dgvDataBaseView.DataSource = null;
                        dgvDataBaseView.DataSource = data;

                        break;
                    }
                default:
                    break;
            }



        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Declaration of local variables
            List<Module> tempmodules = new List<Module>();
            List<Student> tempstudents = new List<Student>();
            List<Composite> tempcomposite = new List<Composite>();
            List<Credential> tempcreds = new List<Credential>();

            string tableName = cmbTableSelect.SelectedItem.ToString();
            //Search based on selected table
            if (!String.IsNullOrWhiteSpace((txtSearch.Text)))
            {

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
                            student.StudentSurname.ToLower().Contains(s) || student.StudentNumber.ToString().Contains(s))
                        {
                            tempstudents.Add(student);
                        }

                    }
                    dgvDataBaseView.DataSource = null;
                    dgvDataBaseView.DataSource = tempstudents;

                }
                else if (tableName == "CompositeTable")
                {
                    List<Composite> tempList = new List<Composite>();
                    foreach (var comp in composite.Where(x => x.StudentNumber.ToString().Contains(txtSearch.Text) || x.ModuleCode.Contains(txtSearch.Text)))
                    {
                        tempList.Add(comp);
                    }
                    dgvDataBaseView.DataSource = null;
                    dgvDataBaseView.DataSource = tempList;
                }
                else if (tableName == "CredentialTable")
                {
                    List<Credential> tempList = new List<Credential>();
                    foreach (var cred in creds.Where(x => x.Username.ToLower().Contains(txtSearch.Text.ToLower())))
                    {
                        tempList.Add(cred);
                    }
                    dgvDataBaseView.DataSource = null;
                    dgvDataBaseView.DataSource = tempList;
                }
            }
        }

        public void DisplayModuleInfo(Module mod)
        {
            //Formating and displaying of rich text box
            rtbEdit.Text = null;
            rtbEdit.Text = rtbEdit.Text + "MODULE NAME: \n";
            rtbEdit.Text = rtbEdit.Text + mod.ModuleName + "\n\n";
            rtbEdit.Text = rtbEdit.Text + "MODULE CODE: \n";
            rtbEdit.Text = rtbEdit.Text + mod.ModuleCode + "\n\n";
            rtbEdit.Text = rtbEdit.Text + "MODULE DESCRIPTION: \n";
            rtbEdit.Text = rtbEdit.Text + mod.ModuleDescription + "\n\n";
            rtbEdit.Text = rtbEdit.Text + "MODULE RESOURCE: \n";
            rtbEdit.Text = rtbEdit.Text + mod.ModuleResource;
        }
        public void DisplayStudentInfo(Student stud)
        {
            //Formating and displaying of rich text box
            rtbEdit.Text = null;
            rtbEdit.Text = rtbEdit.Text + "STUDENT NUMBER: \n";
            rtbEdit.Text = rtbEdit.Text + stud.StudentNumber + "\n\n";
            rtbEdit.Text = rtbEdit.Text + "NAME: \n";
            rtbEdit.Text = rtbEdit.Text + stud.StudentName + "\n\n";
            rtbEdit.Text = rtbEdit.Text + "SURNAME: \n";
            rtbEdit.Text = rtbEdit.Text + stud.StudentSurname + "\n\n";
            rtbEdit.Text = rtbEdit.Text + "DATE OF BIRTH: \n";
            rtbEdit.Text = rtbEdit.Text + stud.StudentDOB + "\n\n";
            rtbEdit.Text = rtbEdit.Text + "GENDER: \n";
            rtbEdit.Text = rtbEdit.Text + stud.StudentGender + "\n\n";
            rtbEdit.Text = rtbEdit.Text + "PHONE NUMBER: \n";
            rtbEdit.Text = rtbEdit.Text + stud.StudentPhone + "\n\n";
            rtbEdit.Text = rtbEdit.Text + "HOME ADDRESS: \n";
            rtbEdit.Text = rtbEdit.Text + stud.StudentAddress + "\n\n";
        }
        public void DisplayCompositeInfo(Composite comp)
        {
            //Formating and displaying of rich text box
            rtbEdit.Text = null;
            rtbEdit.Text = rtbEdit.Text + "STUDENT NUMBER: \n";
            rtbEdit.Text = rtbEdit.Text + comp.StudentNumber + "\n\n";
            rtbEdit.Text = rtbEdit.Text + "MODULES ASSIGNED TO STUDENT: \n";
            foreach (var line in composite.Where(x => x.StudentNumber == comp.StudentNumber))
            {
                rtbEdit.Text = rtbEdit.Text + line.ModuleCode + "\n";
            }
        }
        public void DisplayCredentialInfo(Credential cred)
        {
            //Formating and displaying of rich text box
            rtbEdit.Text = null;
            rtbEdit.Text = rtbEdit.Text + "USERNAME: \n";
            rtbEdit.Text = rtbEdit.Text + cred.Username + "\n\n";
            rtbEdit.Text = rtbEdit.Text + "LOGIN TIMES: \n";
            DataHandler dh = new DataHandler();
            foreach (var line in dh.GetLog())
            {
                if (line.Contains(cred.Username))
                {
                    rtbEdit.Text = rtbEdit.Text + line + "\n";
                }
            }
        }

        private void dgvDataBaseView_SelectionChanged(object sender, EventArgs e)
        {
            //Calls methods to display data in the rich text box
            int index = dgvDataBaseView.CurrentCell.RowIndex;

            if (dgvDataBaseView.DataSource.GetType() == modules.GetType())
            {
                List<Module> dgvData = (List<Module>)dgvDataBaseView.DataSource;

                if (dgvData.Count >= 1)
                {
                    DisplayModuleInfo(dgvData[index]);
                }
            }
            else if (dgvDataBaseView.DataSource.GetType() == students.GetType())
            {
                List<Student> dgvData = (List<Student>)dgvDataBaseView.DataSource;

                if (dgvData.Count >= 1)
                {
                    DisplayStudentInfo(dgvData[index]);
                }
            }
            else if (dgvDataBaseView.DataSource.GetType() == composite.GetType())
            {
                List<Composite> dgvData = (List<Composite>)dgvDataBaseView.DataSource;

                if (dgvData.Count >= 1)
                {
                    DisplayCompositeInfo(dgvData[index]);
                }
            }
            else if (dgvDataBaseView.DataSource.GetType() == creds.GetType())
            {
                List<Credential> dgvData = (List<Credential>)dgvDataBaseView.DataSource;

                if (dgvData.Count >= 1)
                {
                    DisplayCredentialInfo(dgvData[index]);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Calls methods to remove based on the selected table
            string tableName = cmbTableSelect.SelectedItem.ToString();
            int selectedIndex = dgvDataBaseView.CurrentRow.Index;

            if (tableName == "ModuleTable")
            {
                if (DialogResult.Yes == MetroSetMessageBox.Show(this, "Are you sure you want to remove this record?", "ARE YOU SURE?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    dbh.RemoveCompModule(modules[selectedIndex].ModuleCode);
                    foreach (var mod in modules.Where(x => x.ModuleCode == modules[selectedIndex].ModuleCode))
                    {
                        dbh.RemoveModule(mod);
                    }
                }
            }
            else if (tableName == "StudentTable")
            {
                if (DialogResult.Yes == MetroSetMessageBox.Show(this, "Are you sure you want to remove this record?", "ARE YOU SURE?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    dbh.RemoveCompStudent(students[selectedIndex].StudentNumber);
                    foreach (var stud in students.Where(x => x.StudentNumber == students[selectedIndex].StudentNumber))
                    {
                        dbh.RemoveStudent(stud);
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
                        dbh.RemoveCredential(cred);
                    }
                }
            }

            tables = dbh.GetTables();
            modules = dbh.GetModules();
            students = dbh.GetStudents();
            composite = dbh.GetComposite();
            creds = dbh.GetCreds();
            LoadDataView(cmbTableSelect.SelectedItem.ToString());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Opens the main menu
            if (DialogResult.Yes == MetroSetMessageBox.Show(this, "Are you sure you want to quit to menu?", "ARE YOU SURE?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Populates the dataGridView based on selected tables when reset button is clicked
            string tableName = cmbTableSelect.SelectedItem.ToString();
            if (tableName == "ModuleTable")
            {
                dgvDataBaseView.DataSource = modules;
            }
            else if (tableName == "CompositeTable")
            {
                dgvDataBaseView.DataSource = composite;
            }
            else if (tableName == "CredentialTable")
            {
                dgvDataBaseView.DataSource = creds;
            }
            else if (tableName == "StudentTable")
            {
                dgvDataBaseView.DataSource = students;
            }

            txtSearch.Text = null;
        }
    }
}
