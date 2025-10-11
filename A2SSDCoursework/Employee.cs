using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SSDCoursework
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string TelephoneNo { get; set; }
        public string Username { get; set; }
        public DateTime DateHired { get; set; }
        public decimal Salary { get; set; }
        public int StatusID { get; set; }
        public string Status { get; set; }
        public List<int> RoleIDs { get; set; }
        public List<string> Roles { get; set; }

        public Employee()
        {

        }

        public Employee(int employeeID, string firstName, string surname, string gender, string address, DateTime dateOfBirth, string email, string telephoneNo, string username, DateTime dateHired, decimal salary, int statusID, string status, List<int> roleIDs, List<string> roles)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            Surname = surname;
            Gender = gender;
            Address = address;
            DateOfBirth = dateOfBirth;
            Email = email;
            TelephoneNo = telephoneNo;
            Username = username;
            DateHired = dateHired;
            Salary = salary;
            StatusID = statusID;
            Status = status;
            RoleIDs = roleIDs;
            Roles = roles;
        }
    }
}
