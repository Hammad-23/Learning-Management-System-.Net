using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class login
    {
        public string std_name;
        public int std_id;
        public void student_login(TextBox studentName, TextBox studentId )
        {
            std_name = studentName.Text;
            std_id = int.Parse(studentId.Text);
            if (std_name == "Hammad" && std_id == 12345)
            {
                MessageBox.Show("Successfully logged in");
                studentDashboard stdDashboard = new studentDashboard();
                stdDashboard.Show();
                  
            }
            else
            {
                MessageBox.Show("Incorrect Name or password");
            }

        }
    }
}
