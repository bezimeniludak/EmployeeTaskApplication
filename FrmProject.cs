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
    public partial class FrmProject : Form
    {
        Project project;
        List<int> taskIds = new List<int>();
        public FrmProject()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProject_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Globals.Projects;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedProject = listBox1.SelectedIndex;
            project = Globals.Projects[selectedProject];

            tbTitle.Text = project.Title.ToString();
            tbDescription.Text = project.Description.ToString();
            dtpStartDate.Value = project.StartDate;
            dtpEndDate.Value = project.EndDate;
            tbBudget.Text = project.Budget.ToString();

            taskIds.Clear();
            cbTaskId.Items.Clear();
            foreach (Task t in project.Tasks)
            {
                cbTaskId.Items.Add(t.Id);
                taskIds.Add(t.Id);
            }
            cbTaskId.SelectedIndex = 0;
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            int id = Globals.Projects.Last().Id + 1;
            string title = tbTitle.Text;
            string description = tbDescription.Text;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            float budget = float.Parse(tbBudget.Text);

            List<Task> tasks = new List<Task>();
            foreach (int taskId in taskIds)
            {
                tasks.Add(Globals.Tasks.Find(x => x.Id == taskId));
            }

            project = new Project(id, title, description, startDate, endDate, budget, tasks);
            Globals.Projects.Add(project);

            SaveToFile();

            MessageBox.Show("New project successfully added.");
            Close();
        }
        private void btnUpdateProject_Click(object sender, EventArgs e)
        {
            project = Globals.Projects[listBox1.SelectedIndex];
            string title = tbTitle.Text;
            string description = tbDescription.Text;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            float budget = float.Parse(tbBudget.Text);

            List<Task> tasks = new List<Task>();
            foreach (int taskId in taskIds)
            {
                if (Globals.Tasks.Find(x => x.Id == taskId) == null)
                {
                    MessageBox.Show("Could not find task.");
                    return;
                }
                tasks.Add(Globals.Tasks.Find(x => x.Id == taskId));
            }

            project.Title = title;
            project.Description = description;
            project.StartDate = startDate;
            project.EndDate = endDate;
            project.Budget = budget;
            project.Tasks = tasks;

            SaveToFile();

            MessageBox.Show("Project successfully updated.");
            Close();
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            project = Globals.Projects[listBox1.SelectedIndex];

            foreach(int taskId in taskIds)
            {
                Globals.Tasks.Remove(Globals.Tasks.Find(x=>x.Id==taskId));
            }

            Globals.Projects.Remove(project);

            SaveToFile();

            MessageBox.Show("Project successfully removed.");
            Close();
        }

        private void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter("projects.txt"))
            {
                foreach (Project p in Globals.Projects)
                {
                    sw.WriteLine(p.ToString());
                }
            }
            using (StreamWriter sw = new StreamWriter("tasks.txt"))
            {
                foreach (Task t in Globals.Tasks)
                {
                    sw.WriteLine(t.ToString());
                }
            }
        }

        private void cbTaskId_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTaskTitle.Text = Globals.Tasks.Find(x => x.Id == int.Parse(cbTaskId.Text)).Title;
        }
    }
}
