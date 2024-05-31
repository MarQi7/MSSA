using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._4
{
    public partial class Orders : Form
    {
        List<Coffee> coffees = new List<Coffee>();
        private int phase = 0;
        private int orders = 4;
        private int[] choices = new int[5];
        public Orders()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Coffee nextOrder = new Coffee();
            nextOrder.order = 1;
            nextOrder.Name = "Sample";
            nextOrder.Roast = (roast)1;
            nextOrder.Temp = (temp)1;
            nextOrder.Mix = (mix)1;
            nextOrder.Sweet = (sweetener)1;
            nextOrder.Size = (size)1;
            OrderWindow.AppendText($"[{nextOrder.order}] {nextOrder.Name}\n");
            coffees.Add(nextOrder);
            
            Back_Button.Visible = false;
            None_Button.Visible = false;
            Submit_Button.Visible = false;
            Name_Box.Visible = false;
            Orders_Grid.DataSource = coffees;


            Orders_Grid.Visible = false;
            Search_Box.Visible = false;
            ClearSearch_Button.Visible = false;
            Search_Button.Visible = false;
            DeleteOrder_Button.Visible = false;
            Exit_OrderView_Button.Visible = false;
        }



        private void FormChange(int phase) 
        {
            switch (phase)
            {
                case 0:
                    Roast();
                    break;
                case 1:
                    Temp();
                    break;
                case 2:
                    Mix();
                    break;
                case 3:
                    Sweet();
                    break;
                case 4:
                    Sizes();
                    break;
                case 5:
                    Submit();
                    break;

            }   

        }

        private void Roast()
        {
            Option_1.Visible = true;
            Option_2.Visible = true;
            Option_3.Visible = true;
            Option_4.Visible = true;
            Option_1.Text = "Light";
            Option_2.Text = "Medium";
            Option_3.Text = "Dark";
            Option_4.Text = "Bold";
            Back_Button.Visible = false;
            None_Button.Visible = false;
            Submit_Button.Visible = false;
            Name_Box.Visible= false;
            Coffee_Choice.Text = "Roast Selection";
        }

        private void Temp()
        {
            Option_1.Visible = true;
            Option_2.Visible = true;
            Option_1.Text = "Iced";
            Option_2.Text = "Hot";
            Option_3.Visible = false;
            Option_4.Visible = false;
            Back_Button.Visible = true;
            None_Button.Visible = false;
            Coffee_Choice.Text = "Hot or Cold?";
        }

        private void Mix()
        {
            Option_1.Visible = true;
            Option_2.Visible = true;
            Option_1.Text = "Whole Milk";
            Option_2.Text = "Honey Almond Milk";
            Option_3.Visible = true;
            Option_4.Visible = true;
            Option_3.Text = "Vanilla Sweet Cream";
            Option_4.Text = "Salted Caramel Sweet Cream";
            None_Button.Visible = true;
            Back_Button.Visible= true;
            Coffee_Choice.Text = "Mixture Selection";
        }
        private void Sweet()
        {
            Option_1.Visible = true;
            Option_2.Visible = true;
            Option_3.Visible = true;
            Option_4.Visible = true;
            Option_1.Text = "Sugar";
            Option_2.Text = "Cane Sugar";
            Option_3.Text = "Splenda";
            Option_4.Text = "Honey";
            None_Button.Visible = true;
            Back_Button.Visible = true;
            Coffee_Choice.Text = "Sweetener Selection";
        }
        private void Sizes()
        {
            Option_1.Visible = true;
            Option_2.Visible = true;
            Option_3.Visible = true;
            Option_4.Visible = true;
            Option_1.Text = "Small";
            Option_2.Text = "Medium";
            Option_3.Text = "Large";
            Option_4.Text = "Ooof";
            None_Button.Visible = false;
            Name_Box.Visible = false;
            Back_Button.Visible = true;
            Submit_Button.Visible = false;
            Coffee_Choice.Text = "Size Selection";
        }

        private void Submit()
        {
            Option_1.Visible = false;
            Option_2.Visible = false;
            Option_3.Visible = false;
            Option_4.Visible = false;
            None_Button.Visible = false;
            Submit_Button.Visible = true;
            Name_Box.Visible = true;
            Back_Button.Visible = true;
            Coffee_Choice.Text = "Checkout";
        }
        private void RefreshOrders()
        {
            Orders_Grid.DataSource = null;
            Orders_Grid.DataSource = coffees;
        }
        private void RefreshNameBox()
        {
            Name_Box.ForeColor = System.Drawing.Color.Goldenrod;
            Name_Box.Text = "Enter name here";
        }
        private void RefreshText()
        {
            Search_Box.ForeColor = System.Drawing.Color.Goldenrod;
            Search_Box.Text = "Enter name here";
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
                RefreshNameBox();
            }
        }

        private void Option_1_Click(object sender, EventArgs e)
        {
            choices[phase] = 1;
            phase++;
            FormChange(phase);
        }

        private void Option_2_Click(object sender, EventArgs e)
        {
            choices[phase] = 2;
            phase++;
            FormChange(phase);
        }

        private void Option_3_Click(object sender, EventArgs e)
        {
            choices[phase] = 3;
            phase++;
            FormChange(phase);
        }

        private void Option_4_Click(object sender, EventArgs e)
        {
            choices[phase] = 4;
            phase++;
            FormChange(phase);
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {

            phase--;
            FormChange(phase);
        }

        private void None_Button_Click(object sender, EventArgs e)
        {
            choices[phase] = 0;
            phase++;
            FormChange(phase);
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            if (Name_Box.Text != String.Empty && Name_Box.Text != "Enter name here")
            {
                orders += 1;
                Coffee nextOrder = new Coffee();
                nextOrder.order = orders;
                nextOrder.Name = Name_Box.Text;
                nextOrder.Roast = (roast)(choices[0]);
                nextOrder.Temp = (temp)(choices[1]);
                nextOrder.Mix = (mix)(choices[2]);
                nextOrder.Sweet = (sweetener)(choices[3]);
                nextOrder.Size = (size)(choices[4]);
                OrderWindow.AppendText($"[{nextOrder.order}] {nextOrder.Name}\n");
                coffees.Add(nextOrder);
                RefreshNameBox();
                RefreshOrders();
                
                phase = 0;
                FormChange(phase);

            }
            else { MessageBox.Show("Please enter your name.", "Missing field"); }
        }

        private void OrderGridButton_Click(object sender, EventArgs e)
        {
            Orders_Grid.Visible = true;
            Search_Box.Visible = true;
            ClearSearch_Button.Visible = true;
            Search_Button.Visible = true;
            Exit_OrderView_Button.Visible = true;
            DeleteOrder_Button.Visible = true;

            Option_1.Visible = false;
            Option_2.Visible = false;
            Option_3.Visible = false;
            Option_4.Visible = false;

            Back_Button.Visible = false;
            None_Button.Visible = false;
            Submit_Button.Visible = false;
            Name_Box.Visible = false;


        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            string found="";
            foreach (var p in coffees)
                if (p.Name.ToLower() == Search_Box.Text.ToLower())
                    found += ($"Order#: {p.order} Name: {p.Name}\n");

            if (found != "")
                MessageBox.Show(found, "Found!!");
            else MessageBox.Show("No names match", "Not Found...");
            RefreshText();
        }

        private void ClearSearch_Button_Click(object sender, EventArgs e)
        {
            RefreshText();
        }

        private void Search_Box_Enter(object sender, EventArgs e)
        {
            Search_Box.Clear();
            Search_Box.ForeColor = System.Drawing.Color.Black;
        }

        private void Search_Box_Leave(object sender, EventArgs e)
        {
            if (Name_Box.Text == String.Empty)
            {
                RefreshText();
            }
        }

        private void DeleteOrder_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("\t Are you sure?","Delete Order",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                coffees.RemoveAt(Orders_Grid.CurrentRow.Index);
                RefreshOrders();
                RefreshText();
            }
        }

        private void Exit_OrderView_Button_Click(object sender, EventArgs e)
        {
            Orders_Grid.Visible = false;
            Search_Box.Visible = false;
            ClearSearch_Button.Visible = false;
            Search_Button.Visible = false;

            DeleteOrder_Button.Visible = false;
            Exit_OrderView_Button.Visible = false;

            FormChange(phase);
        }
    }
}
