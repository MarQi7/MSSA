using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Login_Button_MouseClick(object sender, MouseEventArgs e)
        {
            if(username_box.Text=="Admin" && password_box.Text == "myPass")
            {
                MessageBox.Show("Login Successful!");
                StudentRecords studentRecords = new StudentRecords();
                studentRecords.Show();
                this.Hide();
                //create transition object
            }
            else
            {
                MessageBox.Show("Login Unsuccessful... try again");
                username_box.Clear(); password_box.Clear();
            }
        }
    }
}
