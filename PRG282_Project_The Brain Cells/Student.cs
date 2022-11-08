using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_The_Brain_Cells
{
    internal class Student
    {
        public Student()
        {
        }

        public Student(int studentNumber, string studentName, string studentSurname, string studentImage, DateTime studentDOB, string studentGender, string studentPhone, string studentAddress)
        {
            StudentNumber = studentNumber;
            StudentName = studentName;
            StudentSurname = studentSurname;
            StudentImage = studentImage;
            StudentDOB = studentDOB;
            StudentGender = studentGender;
            StudentPhone = studentPhone;
            StudentAddress = studentAddress;
        }

        public int StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentImage { get; set; }
        public DateTime StudentDOB { get; set; }
        public string StudentGender { get; set; }
        public string StudentPhone { get; set; }
        public string StudentAddress { get; set; }

        public string Display()
        {
            return $"Student Num: {this.StudentNumber} | Full Name: {this.StudentName} {this.StudentSurname}";
        }

    }
}
