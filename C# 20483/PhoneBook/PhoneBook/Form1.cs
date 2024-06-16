using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        Dictionary<string,Person> Entry = new Dictionary<string, Person>();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Person nextEntry = new Person();
            nextEntry.FName = "Place";
            nextEntry.LName = "Holder";
            nextEntry.Address = "101 tommy drive";
            nextEntry.PhoneNum = 1210001111; // check for int length on entry - work num optional
            nextEntry.WorkNum = 1012223333;
            string[] strings = { nextEntry.Address, nextEntry.PhoneNum.ToString(), nextEntry.WorkNum.ToString() };
            Entry.Add(nextEntry.FName+" "+nextEntry.LName, nextEntry);

            // button & page visual setup
            // datagrid setup
            Add_Button.Visible = false;
            Delete_Button.Visible = false;
            Search_Button.Visible = false;
            Edit_Button.Visible = false;
            Entries_Pic1.Visible = false;
            Entries_Pic2.Visible = false;
            ShowHideAllEdit(false);

            AddressGrid.DataSource = Entry.ToList();
            
        }
        private void ShowHideMain(bool B)
        {
            Open_Button.Visible = B;
            Main_Pic.Visible = B;

        }

  

        private void ShowHideAllEdit(bool B)
        {
            Add_Button.Visible = B;
            Delete_Button.Visible = B;
            Search_Button.Visible = B;
            //Edit_Button.Visible = B;

            FNameBox.Visible = B;
            LNameBox.Visible = B;
            AddressBox.Visible = B;
            CellNumBox.Visible = B;
            WorkNumBox.Visible = B;

            AddressGrid.Visible = B;
            
        }

        private void ShowHideTopButtons(bool B)
        {

            Search_Button.Visible = B;
            Edit_Button.Visible = B;


        }

        private void ShowHideSearch(bool B)
        {
            
            Search_Button.Visible = B;
            Edit_Button.Visible = B;

            FNameBox.Visible= B;
            LNameBox.Visible= B;
            
        }

        private void refreshGrid()
        {
            AddressGrid.DataSource = null;
            AddressGrid.DataSource = Entry.ToArray();
        }


        private void Open_Button_Click(object sender, EventArgs e)
        {
            ShowHideAllEdit(true);
            ShowHideMain(false);
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {

        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            
            string found = "";
            foreach (var p in Entry)
                if (p.Key.Contains(FNameBox.Text) || p.Key.Contains(LNameBox.Text))
                    found += ($"Name: {p.Value.FName} {p.Value.LName}\nAddress: {p.Value.Address}\nCell: {p.Value.PhoneNum}\n\n");

            if (found != "")
                MessageBox.Show(found, "Found!!");
            else MessageBox.Show("No names match", "Not Found...");
            // text box refresh? RefreshText();
            
            
            FNameBox.ForeColor = System.Drawing.Color.Olive;
            FNameBox.Text = "First Name";
            LNameBox.ForeColor = System.Drawing.Color.Olive;
            LNameBox.Text = "Last Name";

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (FNameBox.Text != "First Name" && LNameBox.Text != "Last Name" && AddressBox.Text != "Address" && CellNumBox.Text != "Cell Phone" && CellNumBox.Text != string.Empty)
            {
                Person info = new Person();
                if (!Entry.TryGetValue(FNameBox + " " + LNameBox, out info))
                {
                    Person person = new Person();
                    person.Address = AddressBox.Text;
                    person.FName = FNameBox.Text;
                    person.LName = LNameBox.Text;
                    person.PhoneNum = int.Parse(CellNumBox.Text);
                    if (WorkNumBox.Text != "Work Phone (optional)")
                    {
                        person.WorkNum = int.Parse(WorkNumBox.Text);
                        Entry.Add(person.FName + " " + person.LName, person);
                    }
                    else Entry.Add(person.FName + " " + person.LName, person);

                    MessageBox.Show("Entry added successfully!");
                    refreshGrid();
                    AllClear();
                }
                else MessageBox.Show("That name already exists!", "Duplicate Entry");
                
            } else { MessageBox.Show("Please fill out all required fields.", "Missing info"); }
            
            
        }

        private void AddressBox_Enter(object sender, EventArgs e)
        {
            AddressBox.Clear();
            AddressBox.ForeColor = System.Drawing.Color.Gold;
        }

        private void AddressBox_Leave(object sender, EventArgs e)
        {
            if (AddressBox.Text == string.Empty)
            {
                AddressBox.ForeColor = System.Drawing.Color.Olive;
                AddressBox.Text = "Address";
            }
        }

        private void FNameBox_Enter(object sender, EventArgs e)
        {
            FNameBox.Clear();
            FNameBox.ForeColor = System.Drawing.Color.Gold;
        }

        private void FNameBox_Leave(object sender, EventArgs e)
        {
            if (FNameBox.Text == string.Empty)
            {
                FNameBox.ForeColor = System.Drawing.Color.Olive;
                FNameBox.Text = "First Name";
            }
        }

        private void LNameBox_Enter(object sender, EventArgs e)
        {
            LNameBox.Clear();   
            LNameBox.ForeColor = System.Drawing.Color.Gold;
        }

        private void LNameBox_Leave(object sender, EventArgs e)
        {
            if (LNameBox.Text == string.Empty)
            {
                LNameBox.ForeColor = System.Drawing.Color.Olive;
                LNameBox.Text = "Last Name";
            }
        }

        private void WorkNumBox_Enter(object sender, EventArgs e)
        {
            WorkNumBox.Clear();
            WorkNumBox.ForeColor = System.Drawing.Color.Gold;
        }

        private void WorkNumBox_Leave(object sender, EventArgs e)
        {
            if (WorkNumBox.Text == string.Empty)
            {
                WorkNumBox.ForeColor = System.Drawing.Color.Olive;
                WorkNumBox.Text = "Work Phone (optional)";
            }
        }

        private void CellNumBox_Enter(object sender, EventArgs e)
        {
            CellNumBox.Clear();
            CellNumBox.ForeColor = System.Drawing.Color.Gold;
        }

        private void CellNumBox_Leave(object sender, EventArgs e)
        {
            
            if (CellNumBox.Text == string.Empty)
            {
                CellNumBox.ForeColor = System.Drawing.Color.Olive;
                CellNumBox.Text = "Cell Phone";
            }
            
        }

        private void CellNumBox_Validating(object sender, CancelEventArgs e)
        {
            int cell = 0;
            if(CellNumBox.Text!= "Cell Phone")
                if(!int.TryParse(CellNumBox.Text,out cell) || CellNumBox.Text.Length != 10)
                {
                    MessageBox.Show("Please enter 10 digits", "Invalid input");
                    CellNumBox.Clear();
                    e.Cancel = false;
                }
        }

        private void WorkNumBox_Validating(object sender, CancelEventArgs e)
        {
            int work = 0;
            if(WorkNumBox.Text!= "Work Phone (optional)")
                if (!int.TryParse(WorkNumBox.Text, out work) || WorkNumBox.Text.Length != 10)
                {
                    MessageBox.Show("Please enter 10 digits", "Invalid input");
                    WorkNumBox.Clear();
                    e.Cancel = false;
                }

        }
        private void AllClear()
        {
            FNameBox.ForeColor = System.Drawing.Color.Olive;
            FNameBox.Text = "First Name";
            LNameBox.ForeColor = System.Drawing.Color.Olive;
            LNameBox.Text = "Last Name";
            AddressBox.ForeColor = System.Drawing.Color.Olive;
            AddressBox.Text = "Address"; 
            CellNumBox.ForeColor = System.Drawing.Color.Olive;
            CellNumBox.Text = "Cell Phone";
            WorkNumBox.ForeColor = System.Drawing.Color.Olive;
            WorkNumBox.Text = "Work Phone (optional)";
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            string del = AddressGrid.CurrentRow.DataBoundItem.ToString();
            del = del.Substring(1,del.IndexOf(',')-1);
            var result = MessageBox.Show("\t Are you sure?", "Delete Entry", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                
                Entry.Remove(del);
                refreshGrid();
            }

        }
    }
}
