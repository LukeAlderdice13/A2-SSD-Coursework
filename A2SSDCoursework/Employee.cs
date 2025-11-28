using A2_SSD_Coursework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SSDCoursework
{
    public class Employee
    {
        public static List<Employee> employees = new List<Employee>();
        public static int currentEmployee;

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string TelephoneNo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DateHired { get; set; }
        public decimal Salary { get; set; }
        public Status status = new Status();
        public List<Role> Roles = new List<Role>();
        public List<Vehicle> SoldVehicles = new List<Vehicle>();
        public string FullName
        {
            get
            {
                return $"{FirstName} {Surname}";
            }
        }

        public Employee()
        {

        }

        public Employee(int employeeID, string Username, string Password)
        {
            EmployeeID = employeeID;
            this.Username = Username;
            this.Password = Password;
        }

        public Employee(int employeeID, string firstName, string surname, string gender, string address, DateTime dateOfBirth, string email, string telephoneNo, string username, string password, DateTime dateHired, decimal salary, Status status)
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
            Password = password;
            DateHired = dateHired;
            Salary = salary;
            this.status = status;
        }

        public static bool CheckIfExists(int ID)
        {
            foreach(Employee employee in employees)
            {
                if(employee.EmployeeID == ID)
                {
                    return false;
                }
            }

            return true;
        }

        public static void AddRole(int ID, Role role)
        {
            foreach(Employee employee in employees)
            {
                if (employee.EmployeeID == ID)
                {
                    employee.Roles.Add(role);
                }
            }
        }

        public bool IsManagement()
        {
            foreach(Role role in Roles)
            {
                if(role.RoleID == Role.ManagementID)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetListIndex(int ID)
        {
            for(int i = 0; i < employees.Count; i++)
            {
                if (employees[i].EmployeeID == ID)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
