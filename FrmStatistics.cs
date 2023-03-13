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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTopEmployees_Click(object sender, EventArgs e)
        {
            List<Employee> topEmployeeList = new List<Employee>();
            List<Task> tasks = new List<Task>();

            foreach (Task t in Globals.Tasks)
                if (t.DueDate.Month < DateTime.Today.Month && t.DueDate.Month > DateTime.Today.Month - 2)
                    tasks.Add(t);

            var group = tasks.GroupBy(i => i.AssigneeId).OrderByDescending(group => group.Count());
            var groupTop5 = group.Take(5);

            string message = "";

            foreach (var grp in groupTop5)
            {
                Employee emp = Globals.Employees.Find(x => x.Id == grp.Key);

                message += $"{emp.FullName}: {grp.Count()}\n";
            }
            MessageBox.Show(message, "Top 5 employees with the most tasks in the past month");
        }

        private void btnCurrMonth_Click(object sender, EventArgs e)
        {
            List<Employee> topEmployeeList = new List<Employee>();
            List<Task> tasks = new List<Task>();

            foreach (Task t in Globals.Tasks)
                if (t.DueDate.Month == DateTime.Today.Month)
                    tasks.Add(t);

            var group = tasks.GroupBy(i => i.AssigneeId).OrderByDescending(group => group.Count());
            var groupTop5 = group.Take(5);

            string message = "";

            foreach (var grp in groupTop5)
            {
                Employee emp = Globals.Employees.Find(x => x.Id == grp.Key);

                message += $"{emp.FullName}: {grp.Count()}\n";
            }
            MessageBox.Show(message, "Top 5 employees with the most tasks this month");
        }

        private void btnTopSalary_Click(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();
            employees = Globals.Employees;

            employees = employees.OrderByDescending(emp => emp.MonthlySalary).ToList();
            var employeesTop5 = employees.Take(5);

            string message = "";
            foreach (Employee emp in employeesTop5)
            {
                message += $"{emp.FullName}: {emp.MonthlySalary}\n";
            }
            MessageBox.Show(message, "Top 5 earning employees");
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            List<Project> projects = new List<Project>();
            projects = Globals.Projects.OrderByDescending(p=>p.Tasks.Count()).ToList();
            var projectsTop5 = projects.Take(5);

            string message = "";
            foreach (Project pro in projectsTop5)
            {
                message += $"{pro.Title}: {pro.Tasks.Count()}\n";
            }
            MessageBox.Show(message, "Top 5 projects with the most tasks");
        }
    }
}
