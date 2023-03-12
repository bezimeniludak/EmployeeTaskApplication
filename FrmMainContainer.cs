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
    public partial class FrmMainContainer : Form
    {
        public FrmMainContainer()
        {
            InitializeComponent();
        }

        private void FrmMainContainer_Load(object sender, EventArgs e)
        {
            string[] array;
            string? row = "";
            using (StreamReader sr = new StreamReader("employees.txt"))
            {
                while (row != null)
                {
                    row = sr.ReadLine();
                    if (row != null)
                    {
                        array = row.Split(", ");
                        int id = int.Parse(array[0]);
                        string fullName = array[1];
                        string email = array[2];
                        string phoneNumber = array[3];
                        DateTime dateOfBirth = DateTime.Parse(array[4].Trim());
                        double monthlySalary = float.Parse(array[5]);

                        Employee employee = new Employee(id, fullName, email, phoneNumber, dateOfBirth, monthlySalary);

                        Globals.Employees.Add(employee);
                    }
                }
            }

            using (StreamReader sr = new StreamReader("tasks.txt"))
            {
                row = "";
                while (row != null)
                {
                    row = sr.ReadLine();
                    if (row != null)
                    {
                        array = row.Split(",");
                        try
                        {
                            int id = int.Parse(array[0]);
                            string title = array[1].Trim();
                            string description = array[2].Trim();
                            DateTime dueDate = DateTime.Parse(array[3].Trim());
                            int assigneeId = int.Parse(array[4].Trim());
                            string assigneeName = array[5].Trim();

                            Task task = new Task(id, title, description, dueDate, assigneeId, assigneeName);
                            Globals.Tasks.Add(task);
                        }
                        catch (Exception exc)
                        {
                            Console.WriteLine("Error parsing task data: " + exc.Message);
                        }
                    }
                }
            }

            using (StreamReader sr = new StreamReader("projects.txt"))
            {
                row = "";
                while (row != null)
                {
                    row = sr.ReadLine();
                    if (row != null)
                    {
                        array = row.Split(", ");
                        int id = int.Parse(array[0]);
                        string title = array[1];
                        string description = array[2];
                        DateTime startDate = DateTime.Parse(array[3]);
                        DateTime endDate = DateTime.Parse(array[4]);
                        float budget = float.Parse(array[5]);
                        string[] taskIds = array[6].Split(":");
                        List<Task> tasks = new List<Task>();

                        foreach (string taskId in taskIds)
                        {
                            foreach (Task task in Globals.Tasks)
                            {
                                if (task.Id == int.Parse(taskId))
                                {
                                    tasks.Add(task);
                                }
                            }
                        }
                        Project project = new Project(id, title, description, startDate, endDate, budget, tasks);
                        Globals.Projects.Add(project);
                    }
                }
            }

            MainMenu();
        }

        private void MainMenu()
        {
            FrmMainMenu f = new FrmMainMenu();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
    }
}
