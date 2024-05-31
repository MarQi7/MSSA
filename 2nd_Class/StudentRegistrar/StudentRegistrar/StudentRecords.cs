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
    public partial class StudentRecords : Form
    {
        List<Students> students = new List<Students>();
        public StudentRecords()
        {
            InitializeComponent();
        }

        private void StudentRecords_Load(object sender, EventArgs e)
        {
            students.Add(new Students() { Id = 001, FName = "Marcus", LName = "Holmes", Addresss = "121 Dover St.", Admission = MoA.May, Grade = StudentGrade.C });
            students.Add(new Students() { Id = 002, FName = "Joey", LName = "Wise", Addresss = "121 Dover St.", Admission = MoA.May, Grade = StudentGrade.C });
            students.Add(new Students() { Id = 003, FName = "Sarah", LName = "Newman", Addresss = "121 Dover St.", Admission = MoA.May, Grade = StudentGrade.C });
            students.Add(new Students() { Id = 004, FName = "Leeann", LName = "Canes", Addresss = "121 Dover St.", Admission = MoA.May, Grade = StudentGrade.C });

            Student_Grid.DataSource = students;
            Combo_MoA.DataSource = Enum.GetValues(typeof(MoA));
            Combo_Grade.DataSource = Enum.GetValues(typeof(StudentGrade));
            Student_Record.Visible = false;
            // make the box invisible
        }

        private void Add_Record_Click(object sender, EventArgs e)
        {
            Student_Record.Visible=true;
        }

        private void Delete_Record_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to remove this student?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                students.RemoveAt(Student_Grid.CurrentRow.Index);
                RefreshData();
            }

            
        }
        private void RefreshData()
        {
            Text_ID.Clear(); Text_Address.Clear(); Text_Fname.Clear(); Text_Lname.Clear();
            Combo_MoA.SelectedIndex = -1; Combo_Grade.SelectedIndex = -1;
            Student_Grid.DataSource = null;
            Student_Grid.DataSource = students;
        }



        private void submit_button_Click(object sender, EventArgs e)
        {
            if(Text_ID.Text!=string.Empty &&  Text_Address.Text!=string.Empty && Text_Fname.Text!=string.Empty && Text_Lname.Text!= string.Empty)
            {
                var newStu = new Students();
                newStu.Id = int.Parse(Text_ID.Text);
                newStu.FName = Text_Fname.Text;
                newStu.LName = Text_Lname.Text;
                newStu.Addresss = Text_Address.Text;
                newStu.Admission = (MoA)(Combo_MoA.SelectedIndex+1);
                newStu.Grade = (StudentGrade)(Combo_Grade.SelectedIndex+1);
                students.Add(newStu);
                MessageBox.Show("Record added successfully!");
                RefreshData();
            }
        }

        private void Text_ID_Validating(object sender, CancelEventArgs e)
        {
            int value;
            if(!int.TryParse(Text_ID.Text, out value))
            {
                MessageBox.Show("Please enter a numeric value.");
                e.Cancel = true;
                Text_ID.Clear();
            }
            else if(students.Exists(x => x.Id == value)) 
            {
                MessageBox.Show("That ID is already in use.");
                e.Cancel = true;
                Text_ID.Clear();
            }
        }
    }
}
