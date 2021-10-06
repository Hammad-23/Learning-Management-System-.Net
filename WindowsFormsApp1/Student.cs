using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Student
    {
       public string student_adress;
        string student_contact;
        string student_email;
        string student_gpa;

        public void studentInformation(TextBox std_adress,TextBox std_contact,TextBox std_email,TextBox std_gpa, ListBox show_data)
        {
            student_adress = std_adress.Text;
            student_contact = std_contact.Text;
            student_email = std_email.Text;
            student_gpa = std_gpa.Text;
            show_data.Items.Add("student adress: " + student_adress);
            show_data.Items.Add("student contact: " + student_contact);
            show_data.Items.Add("student email: " + student_email);
            show_data.Items.Add("student GPA: " + student_gpa);


        }

 
    }
}
