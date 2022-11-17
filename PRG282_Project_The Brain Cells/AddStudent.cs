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
    public partial class AddStudent : MetroSetForm
    {
        //Global declaration of variables
        DataBaseHandler dh = new DataBaseHandler();

        List<Student> students = new List<Student>();
        List<Student> studentsToAdd = new List<Student>();
        public AddStudent()
        {
            InitializeComponent();
            //Returns a list of students
            students = dh.GetStudents();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Returns to the dashboard
            ClearFields();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void ClearFields()
        {
            //Clears text fields
            txtAddress.Text = null;
            txtStudName.Text = null;
            txtStudPhone.Text = null;
            txtStudSurname.Text = null;
            txtDOB.Text = null;
            cmbGender.Text = null;
            cmbGender.SelectedIndex = -1;
        }


        private bool ValidateInput()
        {
            //Validates the text input
            if (string.IsNullOrEmpty(txtStudName.Text) || string.IsNullOrEmpty(txtStudSurname.Text)
                || string.IsNullOrEmpty(txtDOB.Text) || string.IsNullOrEmpty(txtStudPhone.Text) || string.IsNullOrEmpty(txtAddress.Text)
                || !(cmbGender.SelectedIndex >= 0))
            {
                return false;
            }

            if (int.Parse((DateTime.Now.Year - DateTime.ParseExact(txtDOB.Text, "dd/MM/yyyy", null).Year).ToString()) < 18)
            {
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Creates a student if validation was returned as true
            if (ValidateInput())
            {
                Student stud = new Student();
                stud.StudentName = txtStudName.Text;
                stud.StudentSurname = txtStudSurname.Text;
                stud.StudentPhone = txtStudPhone.Text;
                stud.StudentImage = "";
                stud.StudentGender = cmbGender.SelectedItem.ToString();
                stud.StudentAddress = txtAddress.Text;
                stud.StudentDOB = DateTime.Parse(txtDOB.Text);

                studentsToAdd.Add(stud);

                lbxToAdd.Items.Add($"{stud.StudentName} {stud.StudentSurname}");

                ClearFields();
            }
            else
            {
                MetroSetMessageBox.Show(this, "One or more problems with input.\nEnsure no fields are empty and student is older than 18."
                    , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //Writes the students to the database
            if (DialogResult.Yes == MetroSetMessageBox.Show(this, "Are you sure you want to add this student's information?", "ARE YOU SURE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (studentsToAdd.Count >= 1)
                {
                    foreach (var stud in studentsToAdd)
                    {
                        dh.AddStudent(stud);
                    }
                }
                else
                {
                    MetroSetMessageBox.Show(this, "Enter the details of a new student before writing to database."
                        , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            ClearFields();
            studentsToAdd.Clear();
            lbxToAdd.Clear();
        }
    }
}
