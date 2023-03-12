using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EmployeeTaskApplication
{
    internal class Project
    {
        private int _id;
        private string _title;
        private string _description;
        private DateTime _startDate;
        private DateTime _endDate;
        private float _budget;
        private List<Task> _tasks;

        public Project(int id, string title, string description, DateTime startDate, DateTime endDate, float budget, List<Task> tasks)
        {
            _id = id;
            _title = title;
            _description = description;
            _startDate = startDate;
            _endDate = endDate;
            _budget = budget;
            _tasks = tasks;
        }

        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }
        public float Budget { get => _budget; set => _budget = value; }
        internal List<Task> Tasks { get => _tasks; set => _tasks = value; }

        public override string ToString()
        {
            string stringTasks = "";
            foreach (Task t in Tasks)
            {
                stringTasks += $"{t.Id}:";
            }
            stringTasks = stringTasks.TrimEnd(':');
            return $"{Id}, {Title}, {Description}, {StartDate.ToShortDateString()}, {EndDate.ToShortDateString()}, {Budget}, {stringTasks}";
        }
    }
}
