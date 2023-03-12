using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTaskApplication
{
    public static class Globals
    {
        private static List<Employee> employees = new List<Employee>();
        internal static List<Employee> Employees { get => employees; set => employees = value; }

        private static List<Task> tasks = new List<Task>();
        internal static List<Task> Tasks { get => tasks; set => tasks = value; }

        private static List<Project> projects = new List<Project>();
        internal static List<Project> Projects { get => projects; set => projects = value; }
    }
}
