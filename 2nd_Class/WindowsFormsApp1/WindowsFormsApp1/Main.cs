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
    public partial class Main : Form
    {
        List<Employee> employees= new List<Employee>();

        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            employees.Add(new Employee() { EID = 1, Name = "Allen", Salary = 32000, Dept = Department.Finance });

            employees.Add(new Employee() { EID = 2, Name = "Cory", Salary = 43000, Dept = Department.IT });

            employees.Add(new Employee() { EID = 3, Name = "Mark", Salary = 30000, Dept = Department.HR });

            employees.Add(new Employee() { EID = 4, Name = "Chances", Salary = 37000, Dept = Department.Marketing });

            Employee_Grid.DataSource = employees;

            Employee_Dept_Box.DataSource = Enum.GetValues(typeof(Department)); //retrieves dept names
            Employee_Grp.Visible = false;

        }

        private void AddRec_Click(object sender, EventArgs e)
        {
            Employee_Grp.Visible=true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var result=MessageBox.Show("Are you sure you want to delete the record?","Warning!",MessageBoxButtons.YesNo);  
            if(result == DialogResult.Yes)
            {
                employees.RemoveAt(Employee_Grid.CurrentRow.Index);
                RefreshData();
            }

        }

        private void RefreshData()
        {
            Text_ID.Clear(); Text_Name.Clear(); Text_Salary.Clear(); Employee_Dept_Box.SelectedIndex = -1;
            Employee_Grid.DataSource = null;
            Employee_Grid.DataSource = employees;
        }

        private void Submit_Form_Click(object sender, EventArgs e)
        {
            if(Text_ID.Text!=string.Empty && Text_Name.Text!=string.Empty && Text_Salary.Text != string.Empty)
            {
                var newEmp=new Employee();
                newEmp.EID=int.Parse(Text_ID.Text);
                newEmp.Name=Text_Name.Text;
                newEmp.Salary=int.Parse(Text_Salary.Text);
                newEmp.Dept= (Department)(Employee_Dept_Box.SelectedIndex + 1); //converts value box to Dept selection params && casts Department as its type
                employees.Add(newEmp);
                MessageBox.Show("Record added successfully!");
                RefreshData();
                
            }
            
            
        }

        private void Text_ID_Validating(object sender, CancelEventArgs e)
        {
            if(Text_ID.Text.Length != 0)
            {
                int value;
                if(!int.TryParse(Text_ID.Text, out value))
                {
                    MessageBox.Show("Please enter a number value");
                    e.Cancel = true;
                    Text_ID.Clear();
                }
                else if(value ==0 || value > 500)
                {
                    MessageBox.Show("Please enter a number between 1 & 500");
                    e.Cancel = true;
                    Text_ID.Clear();
                }
            }
        }

        private void Text_Salary_Validating(object sender, CancelEventArgs e)
        {
            if (Text_ID.Text.Length != 0)
            {
                int value;
                if (!int.TryParse(Text_ID.Text, out value))
                {
                    MessageBox.Show("Please enter a numeric value");
                    e.Cancel = true;
                    Text_ID.Clear();
                }
            }
        }
    }
}
