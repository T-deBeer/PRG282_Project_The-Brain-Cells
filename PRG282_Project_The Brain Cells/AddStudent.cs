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
        DataBaseHandler dh = new DataBaseHandler();

        List<Student> students = new List<Student>();
        List<Student> studentsToAdd = new List<Student>();
        public AddStudent()
        {
            InitializeComponent();
            students = dh.GetStudents();
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
            txtAddress.Text = null;
            txtStdNum.Text = null;
            txtStudName.Text = null;
            txtStudPhone.Text = null;
            txtStudSurname.Text = null;
        }


        private bool ValidateInpute()
        {
            foreach (var student in students)
            {
                if (student.StudentNumber == int.Parse(txtStdNum.Text))
                {
                    return false;
                }
            }

            if (txtStdNum.Text == "" || txtStdNum.Text == " " || txtStudName.Text == "" || txtStudName.Text == " "
                || txtStudSurname.Text == "" || txtStudSurname.Text == " " || txtAddress.Text == "" || txtAddress.Text == " "
                || txtDOB.Text == null || cmbGender.SelectedItem.ToString() == "")
            {
                return false;
            }

            if (DateTime.Now.Year - DateTime.Parse(txtDOB.Text).Year < 18)
            {
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInpute())
            {
                Student stud = new Student();

                stud.StudentNumber = students.Count+1;
                stud.StudentName = txtStudName.Text;
                stud.StudentSurname = txtStudSurname.Text;
                stud.StudentPhone = txtStudPhone.Text;
                stud.StudentAddress = txtAddress.Text;
                stud.StudentDOB = DateTime.Parse(txtDOB.Text);

                studentsToAdd.Add(stud);

                lbxToAdd.Items.Add(stud.Display());

            }
            else
            {
                MetroSetMessageBox.Show(this, "One or more problems with input.\nEnsure no fielda are empty and student is older than 18."
                    , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
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
    }
}
