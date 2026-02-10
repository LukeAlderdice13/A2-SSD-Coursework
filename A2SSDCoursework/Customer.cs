using A2SSDCoursework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_SSD_Coursework
{
    public class Customer
    {
        public static List<Customer> customers = new List<Customer>();

        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string TelephoneNo { get; set; }

        public List<int> BoughtVehicles = new List<int>();

        public string FullName
        {
            get
            {
                return $"{FirstName} {Surname}";
            }
        }
        public Customer()
        {

        }

        public Customer(int customerID, string firstName, string surname, string address, string email, string telephoneNo, int boughtVehicle)
        {
            CustomerID = customerID;
            FirstName = firstName;
            Surname = surname;
            Address = address;
            Email = email;
            TelephoneNo = telephoneNo;
            BoughtVehicles.Add(boughtVehicle);
        }

        public Customer(int customerID, string firstName, string surname, string address, string email, string telephoneNo)
        {
            CustomerID = customerID;
            FirstName = firstName;
            Surname = surname;
            Address = address;
            Email = email;
            TelephoneNo = telephoneNo;
        }

        public Customer(string firstName, string surname, string address, string email, string telephoneNo)
        {
            FirstName = firstName;
            Surname = surname;
            Address = address;
            Email = email;
            TelephoneNo = telephoneNo;
        }

        public static bool CheckIfExists(int ID)
        {
            foreach(Customer customer in customers)
            {
                if (customer.CustomerID == ID)
                {
                    return false;
                }
            }
            return true;
        }

        public static void addBoughtVehicle(int CustomerID, int VehicleID)
        {
            foreach(Customer customer in customers)
            {
                if(customer.CustomerID == CustomerID)
                {
                    customer.BoughtVehicles.Add(VehicleID);
                }
            }
        }

        public static int GetCustomerIndex(Customer customer)
        {
            int location = 0;
            foreach(Customer c in customers)
            {
                if (c.CustomerID == customer.CustomerID)
                {
                    break;
                }
                location++;
            }
            return location;
        }

        public static Customer GetCustomerFromID(int ID)
        {
            foreach(Customer customer in customers)
            {
                if (customer.CustomerID == ID)
                {
                    return customer;
                } 
            }
            return null;
        }

        public static int NewID()
        {
            int ID = 0;
            foreach (Customer customer in customers)
            {
                ID++;
            }
            return ID + 1;
        }

        public static void DeleteCustomer(int ID)
        {
            Customer c = new Customer();
            foreach(Customer customer in customers)
            {
                if (customer.CustomerID == ID)
                {
                    c = customer;
                    break;
                }
            }
            customers.Remove(c);
        }

        public static void AddBoughtVehicle(int CustomerID, int VehicleID)
        {
            foreach(Customer c in customers)
            {
                if (c.CustomerID == CustomerID)
                {
                    c.BoughtVehicles.Add(VehicleID);
                    break;
                }
            }
        }
    }
}
