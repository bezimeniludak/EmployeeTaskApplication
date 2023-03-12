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
    public partial class FrmTask : Form
    {
        Task task;
        public FrmTask()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTask_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Globals.Tasks;
            foreach (Employee emp in Globals.Employees)
            {
                cbAssigneeName.Items.Add(emp.FullName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTask = listBox1.SelectedIndex;
            task = Globals.Tasks[selectedTask];

            tbTitle.Text = task.Title.ToString();
            tbDescription.Text = task.Description.ToString();
            dtpDueDate.Value = task.DueDate;
            tbAssigneeId.Text = task.AssigneeId.ToString();
            cbAssigneeName.Text = task.AssigneeName.ToString();
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            int id = Globals.Tasks.Last().Id + 1;
            string title = tbTitle.Text;
            string description = tbDescription.Text;
            DateTime DueDate = dtpDueDate.Value;
            string assigneeName = cbAssigneeName.Text;
            int assigneeId = 0;
            if (assigneeName == "" || Globals.Employees.Find(i => i.FullName == assigneeName) == null)
            {
                MessageBox.Show("Assignee name not in employee list.");
                return;
            }
            else if (Globals.Employees.Find(i => i.FullName == assigneeName) != null)
            {
                assigneeId = Globals.Employees.Find(x => x.FullName == assigneeName).Id;
            }

            task = new Task(id, title, description, DueDate, assigneeId, assigneeName);
            Globals.Tasks.Add(task);

            SaveToFile();

            MessageBox.Show("New task successfully added.");
            Close();
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            task = Globals.Tasks[listBox1.SelectedIndex];
            string title = tbTitle.Text;
            string description = tbDescription.Text;
            DateTime dueDate = dtpDueDate.Value;
            string assigneeName = cbAssigneeName.Text;
            int assigneeId = 0;
            if (assigneeName == "" || Globals.Employees.Find(i => i.FullName == assigneeName) == null)
            {
                MessageBox.Show("Assignee name not in employee list.");
                return;
            }
            else if (Globals.Employees.Find(i => i.FullName == assigneeName) != null)
            {
                assigneeId = Globals.Employees.Find(x => x.FullName == assigneeName).Id;
            }

            task.Title = title;
            task.Description = description;
            task.DueDate = dueDate;
            task.AssigneeId = assigneeId;
            task.AssigneeId = assigneeId;
            task.AssigneeName = assigneeName;

            SaveToFile();

            MessageBox.Show("Task data successfully updated.");
            Close();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            task = Globals.Tasks[listBox1.SelectedIndex];
            Globals.Tasks.Remove(task);

            SaveToFile();

            MessageBox.Show("Task successfully removed.");
            Close();
        }

        private void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter("tasks.txt"))
            {
                foreach (Task t in Globals.Tasks)
                {
                    sw.WriteLine(t.ToString());
                }
            }
        }

        private void cbAssigneeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbAssigneeId.Text = Globals.Employees.Find(x => x.FullName == cbAssigneeName.Text).Id.ToString();
        }
    }
}
