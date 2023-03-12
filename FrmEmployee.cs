using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTaskApplication
{
    public partial class FrmEmployee : Form
    {
        Employee employee;
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Globals.Employees;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedEmployee = listBox1.SelectedIndex;
            employee = Globals.Employees[selectedEmployee];

            tbName.Text = employee.FullName.ToString();
            tbEmail.Text = employee.Email.ToString();
            tbPhone.Text = employee.PhoneNumber.ToString();
            dtpDateOfBirth.Value = employee.DateOfBirth;
            tbSalary.Text = employee.MonthlySalary.ToString();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            int id = Globals.Employees.Last().Id + 1;
            string fullName = tbName.Text;
            string email = tbEmail.Text;
            string phone = tbPhone.Text;
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            double monthlySalary = float.Parse(tbSalary.Text);

            employee = new Employee(id, fullName, email, phone, dateOfBirth, monthlySalary);
            Globals.Employees.Add(employee);

            SaveToFile();

            MessageBox.Show("New employee successfully added.");
            Close();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            employee = Globals.Employees[listBox1.SelectedIndex];
            string fullName = tbName.Text;
            string email = tbEmail.Text;
            string phone = tbPhone.Text;
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            double monthlySalary = float.Parse(tbSalary.Text);

            employee.FullName = fullName;
            employee.Email = email;
            employee.PhoneNumber = phone;
            employee.DateOfBirth = dateOfBirth;
            employee.MonthlySalary = monthlySalary;

            SaveToFile();

            MessageBox.Show("Employee data successfully updated.");
            Close();

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            employee = Globals.Employees[listBox1.SelectedIndex];
            Globals.Employees.Remove(employee);

            SaveToFile();

            MessageBox.Show("Employee successfully removed.");
            Close();
        }

        private void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter("employees.txt"))
            {
                foreach (Employee emp in Globals.Employees)
                {
                    sw.WriteLine(emp.ToString());
                }
            }
        }
    }
}
