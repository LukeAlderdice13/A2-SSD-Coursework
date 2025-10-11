using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_SSD_Coursework
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string TelephoneNo { get; set; }

        public List<Vehicle> BoughtVehicles { get; set; }

        public Customer()
        {

        }

        public Customer(int customerID, string firstName, string surname, string address, string email, string telephoneNo, List<Vehicle> boughtVehicles)
        {
            CustomerID = customerID;
            FirstName = firstName;
            Surname = surname;
            Address = address;
            Email = email;
            TelephoneNo = telephoneNo;
            BoughtVehicles = boughtVehicles;
        }
    }
}
