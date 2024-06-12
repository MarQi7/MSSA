using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TeachersLogin
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        Teacher teacher = new Teacher();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void PageLoad(bool B)
        {
            Login_button.Visible = !B;
            LoginLabel.Visible = !B;
            UserBox.Visible = !B;
            PassBox.Visible = !B;
            Name_box.Visible = B;
            ID_box.Visible = B;
            StudentGrid.Visible = B;
            Math_box.Visible = B;
            Sci_box.Visible = B;
            Tech_box.Visible = B;
            Eng_box.Visible = B;
            Add_button.Visible = B;
            Delete_button.Visible = B;
            Search_button.Visible = B;
            Star_button.Visible = B;

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            
            Student student = new Student();
            student.Name = "Temp";
            student.Sci = Student.grade.A;
            student.Eng = Student.grade.B;
            student.Math = Student.grade.C;
            student.Tech = Student.grade.D;
            student.ID = 10101;
            students.Add(student);
            

            Sci_box.DataSource = Enum.GetValues(typeof(Student.grade));
            Tech_box.DataSource = Enum.GetValues(typeof(Student.grade));
            Eng_box.DataSource = Enum.GetValues(typeof (Student.grade));
            Math_box.DataSource = Enum.GetValues(typeof(Student.grade));

            StudentGrid.DataSource = students;
            StudentGrid.Visible = false;

            PageLoad(false);
        }

        private void UserBox_Enter(object sender, EventArgs e)
        {
            UserBox.Clear();
            UserBox.ForeColor = Color.White;
        }

        private void PassBox_Enter(object sender, EventArgs e)
        {
            PassBox.Clear();
            PassBox.ForeColor = Color.White;
        }

        private void RefreshGrid()
        {
            StudentGrid.DataSource = null;
            StudentGrid.DataSource = students;
        }

        private void ResetFields()
        {
            Sci_box.SelectedIndex = 0;
            Math_box.SelectedIndex = 0;
            Eng_box.SelectedIndex = 0;
            Tech_box.SelectedIndex = 0;
            Name_box.Clear();
            ID_box.Clear();
        }
        private void Search_button_Click(object sender, EventArgs e)
        {
            string found = "";
            foreach (var s in students)
                if (s.Name.Contains(Name_box.Text))
                    found += ($"Name: {s.Name} ID: {s.ID} Science: {s.Sci} Technology: {s.Tech} English: {s.Eng} Math: {s.Math}");

            if (found != "")
                MessageBox.Show(found, "Found!!");
            else MessageBox.Show("No names match", "Not Found...");
           

            Name_box.ForeColor = System.Drawing.Color.DarkSlateGray;
            Name_box.Text = "Name";
            

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Permanent Action", MessageBoxButtons.YesNoCancel);
                if(result == DialogResult.Yes)
            {
                students.RemoveAt(StudentGrid.CurrentRow.Index);
                RefreshGrid();

            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if ((Name_box.Text != String.Empty && Name_box.Text != "Name" && ID_box.Text != "Student ID") && EnumCheck())
            {
                Student nextStu = new Student();
                nextStu.Name = Name_box.Text;
                nextStu.ID = int.Parse(ID_box.Text);
                nextStu.Sci = (Student.grade)Sci_box.SelectedIndex;
                nextStu.Tech = (Student.grade)Tech_box.SelectedIndex;
                nextStu.Eng = (Student.grade)Eng_box.SelectedIndex;
                nextStu.Math = (Student.grade)Math_box.SelectedIndex;

                students.Add(nextStu);
                
                RefreshGrid();
                ResetFields();

            }
            else { MessageBox.Show("Please fill all required fields", "Missing field"); }

        }

        private bool EnumCheck()
        {
            bool b1 = (Student.grade)Sci_box.SelectedIndex != Student.grade.N;
            bool b2 = (Student.grade)Math_box.SelectedIndex != Student.grade.N;
            bool b3 = (Student.grade)Tech_box.SelectedIndex != Student.grade.N;
            bool b4 = (Student.grade)Eng_box.SelectedIndex != Student.grade.N;

            return (b1&&b2&&b3&&b4);
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (UserBox.Text == teacher.UserName && PassBox.Text == teacher.PassWord)
                PageLoad(true);
            else MessageBox.Show("Please check your login information", "Login Error");
        }

        private void UserBox_Leave(object sender, EventArgs e)
        {
            if (UserBox.Text == string.Empty)
            {
                UserBox.ForeColor = System.Drawing.Color.DarkSlateGray;
                UserBox.Text = "User Name";
            }
                
        }

        private void PassBox_Leave(object sender, EventArgs e)
        {
            if (PassBox.Text == string.Empty)
            {
                PassBox.ForeColor = System.Drawing.Color.DarkSlateGray;
                PassBox.Text = "Password";
            }

        }

        private void Star_button_Click(object sender, EventArgs e)
        {
            Student first = new Student();
            foreach(var s in students)
                if(s.GPA > first.GPA)
                    first = s;
            FileExport.StarStudentFile(first);
        }

        private void ID_box_Validating(object sender, CancelEventArgs e)
        {
            int value;
            if (!int.TryParse(ID_box.Text, out value))
            {
                MessageBox.Show("Please enter a numeric value.");
                e.Cancel = true;
                ID_box.Clear();
            }
            else if (students.Exists(x => x.ID == value))
            {
                MessageBox.Show("That ID is already in use.");
                e.Cancel = true;
                ID_box.Clear();
            }
            //exists // # only
        }

        private void ID_box_Enter(object sender, EventArgs e)
        {
            ID_box.Clear();
            ID_box.ForeColor = Color.White;
        }

        private void Name_box_Enter(object sender, EventArgs e)
        {
            Name_box.Clear();
            Name_box.ForeColor = Color.White;
        }
    }
}
