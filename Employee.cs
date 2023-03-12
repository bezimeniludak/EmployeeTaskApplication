using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTaskApplication
{
    internal class Employee
    {
        private int _id;
        private string _fullName;
        private string _email;
        private string _phoneNumber;
        private DateTime _dateOfBirth;
        private double _monthlySalary;

        public Employee(int id, string fullName, string email, string phoneNumber, DateTime dateOfBirth, double monthlySalary)
        {
            _id = id;
            _fullName = fullName;
            _email = email;
            _phoneNumber = phoneNumber;
            _dateOfBirth = dateOfBirth;
            _monthlySalary = monthlySalary;
        }
        public int Id { get => _id; set => _id = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public string Email { get => _email; set => _email = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public double MonthlySalary { get => _monthlySalary; set => _monthlySalary = value; }

        public override string ToString()
        {
            return $"{Id}, {FullName}, {Email}, {PhoneNumber}, {DateOfBirth.ToShortDateString()}, {MonthlySalary}";
        }
    }
}
