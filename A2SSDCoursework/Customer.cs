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
    }
}
