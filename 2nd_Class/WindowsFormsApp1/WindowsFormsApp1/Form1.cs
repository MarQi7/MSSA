using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sign_In_Click(object sender, EventArgs e)
        {
            if(InputUN.Text=="Admin" && InputPW.Text == "Password")
            {
                MessageBox.Show("Login successful!");
                Main objmain = new Main();
                objmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login credentials");
                InputUN.Clear();
                InputPW.Clear();    
            }
        }

        private void InputUN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
