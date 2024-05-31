using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._4
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            Back_Button.Visible = false;
            Skip_Submit_Button.Visible = false;
            Name_Box.Visible = false;  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Custom_Button_Click(object sender, EventArgs e)
        {

        }

        private void Cold_Brew_Button_Click(object sender, EventArgs e)
        {

        }

        private void Latte_Button_Click(object sender, EventArgs e)
        {

        }

        private void Americano_Button_Click(object sender, EventArgs e)
        {

        }

        private void Frappe_Button_Click(object sender, EventArgs e)
        {

        }

        private void Espresso_Button_Click(object sender, EventArgs e)
        {

        }

        private void OrderGridButton_Click(object sender, EventArgs e)
        {

        }

        private void Regular_CB_Click(object sender, EventArgs e)
        {

        }

        private void Milk_CB_Click(object sender, EventArgs e)
        {

        }

        private void SaltCaramel_CB_Click(object sender, EventArgs e)
        {

        }

        private void VSC_CB_Click(object sender, EventArgs e)
        {

        }

        private void Back_CB_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Cold_Brew_Button_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void WholeMilk_Button_Click(object sender, EventArgs e)
        {

        }

        private void HoneyMilk_Button_Click(object sender, EventArgs e)
        {

        }

        private void VanillaSC_Button_Click(object sender, EventArgs e)
        {

        }

        private void SaltedCSC_Button_Click(object sender, EventArgs e)
        {

        }

        private void Sugar_Button_Click(object sender, EventArgs e)
        {

        }

        private void Cane__Button_Click(object sender, EventArgs e)
        {

        }

        private void Splenda_Button_Click(object sender, EventArgs e)
        {

        }

        private void Honey_Button_Click(object sender, EventArgs e)
        {

        }

        private void Sugar_Back_Button_Click(object sender, EventArgs e)
        {

        }

        private void Sugar_None_Button_Click(object sender, EventArgs e)
        {

        }

        private void Name_Box_Enter(object sender, EventArgs e)
        {
            Name_Box.Clear();
            Name_Box.ForeColor = System.Drawing.Color.Black;
        }

        private void Name_Box_Leave(object sender, EventArgs e)
        {
            if(Name_Box.Text == String.Empty)
            {
                Name_Box.ForeColor = System.Drawing.Color.Goldenrod;
                Name_Box.Text = "Enter name here";
            }
        }
    }
}
