using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EmployeeTaskApplication
{
    internal class Task
    {
        private int _id;
        private string _title;
        private string _description;
        private DateTime _dueDate;
        private int _assigneeId;
        private string _assigneeName;

        public Task(int id, string title, string description, DateTime dueDate, int assigneeiD, string assigneeName)
        {
            _id = id;
            _title = title;
            _description = description;
            _dueDate = dueDate;
            _assigneeId = assigneeiD;
            _assigneeName = assigneeName;
        }

        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime DueDate { get => _dueDate; set => _dueDate = value; }
        public int AssigneeId { get => _assigneeId; set => _assigneeId = value; }
        public string AssigneeName { get => _assigneeName; set => _assigneeName = value; }

        public override string ToString()
        {
            return $"{Id}, {Title}, {Description}, {DueDate.ToShortDateString()}, {AssigneeId}, {AssigneeName}";
        }
    }
}
