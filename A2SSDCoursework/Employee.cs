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
        public static Employee nullEmployee = new Employee("Null", "");

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
        public decimal Profit
        {
            get
            {
                return Sales + ServiceProfit;
            }
        }

        public int NumServices
        {
            get
            {
                int services = 0;

                foreach (Vehicle vehicle in Vehicle.vehicles)
                {
                    foreach (Service service in vehicle.ServiceHistory)
                    {
                        if (service.employee.EmployeeID == EmployeeID)
                        {
                            services++;
                        }
                    }
                }

                return services;
            }
        }

        public List<Service> Services
        {
            get
            {
                List<Service> services = new List<Service>(); 
                foreach (Vehicle vehicle in Vehicle.vehicles)
                {
                    foreach (Service service in vehicle.ServiceHistory)
                    {
                        if (service.employee.EmployeeID == EmployeeID)
                        {
                            services.Add(service);
                        }
                    }
                }
                return services;
            }
        }

        public decimal Sales
        {
            get
            {
                decimal profit = 0;
                foreach (Vehicle vehicle in SoldVehicles)
                {
                    profit += vehicle.SoldPrice;
                }
                return profit;
            }
        }

        public decimal ServiceProfit
        {
            get
            {
                decimal profit = 0;
                foreach (Vehicle vehicle in Vehicle.vehicles)
                {
                    foreach (Service service in vehicle.ServiceHistory)
                    {
                        if (service.employee.EmployeeID == EmployeeID)
                        {
                            profit += service.Cost;
                        }
                    }
                }
                return profit;
            }
        }

        public int MaxAccessLevel
        {
            get
            {
                int accessLevel = 1;
                foreach(Role role in Roles)
                {
                    if (accessLevel < role.AccessLevel)
                    {
                        accessLevel = role.AccessLevel;
                    }
                }
                return accessLevel;
            }
        }
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

        public Employee(string firstName, string surname)
        {
            FirstName = firstName;
            Surname = surname;
        }

        public Employee(string firstName, string surname, string gender, string address, DateTime dateOfBirth, string email, string telephoneNo, string username, string password, DateTime dateHired, decimal salary, Status status, List<Role> roles)
        {
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
            Roles = roles;
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

        public static int GetListIndex(int ID)
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
        public static decimal MaxSalary()
        {
            decimal max = 0;
            foreach(Employee e in employees)
            {
                if (e.Salary > max)
                {
                    max = e.Salary;
                }
            }
            return max;
        }

        public static decimal MinSalary()
        {
            decimal min = MaxSalary();
            foreach(Employee e in employees)
            {
                if (e.Salary < min)
                {
                    min = e.Salary;
                }
            }
            return min;
        }

        public static Employee GetEmployeeFromID(int ID)
        {
            foreach(Employee e in employees)
            {
                if (e.EmployeeID == ID)
                {
                    return e;
                }
            }
            return null;
        }

        public static bool IsUsernameTaken(int ID, string username)
        {
            foreach(Employee e in employees)
            {
                if (e.EmployeeID != ID)
                {
                    if (e.Username == username)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool IsUsernameTaken(string username)
        {
            foreach (Employee e in employees)
            {
                if (e.Username == username)
                {
                    return true;
                }
            }
            return false;
        }

        public static void DeleteEmployee(int ID)
        {
            Employee e = new Employee();
            foreach(Employee employee in employees)
            {
                if (employee.EmployeeID == ID)
                {
                    e = employee;
                    break;
                }
            }

            employees.Remove(e);
        }

        public static void AddSoldVehicle(int ID, Vehicle vehicle)
        {
            foreach(Employee employee in employees)
            {
                if (employee.EmployeeID == ID)
                {
                    employee.SoldVehicles.Add(vehicle);
                }
            }
        }
    }
}
