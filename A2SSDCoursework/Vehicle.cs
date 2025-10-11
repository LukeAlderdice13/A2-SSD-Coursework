using A2SSDCoursework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_SSD_Coursework
{
    public class Vehicle
    {
        public int Id { get; set; }
        public Brand brand = new Brand();
        public Make make = new Make();
        public string YearMade { get; set; }
        public string Colour { get; set; }
        public int EngineSize { get; set; }
        public string RegistrationPlate { get; set; }
        public string VIN { get; set; }
        public string FuelType { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public decimal SoldPrice { get; set; }
        public DateTime DateSold { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public List<Service> ServiceHistory = new List<Service>();

        public Vehicle()
        {

        }

        public Vehicle(int id, Brand brand, Make make, string yearMade, string colour, int engineSize, string registrationPlate, string vIN, string fuelType, decimal price)
        {
            Id = id;
            this.brand = brand;
            this.make = make;
            YearMade = yearMade;
            Colour = colour;
            EngineSize = engineSize;
            RegistrationPlate = registrationPlate;
            VIN = vIN;
            FuelType = fuelType;
            Price = price;
        }

        public Vehicle(int id, string brand, string make, string yearMade, string colour, int engineSize, string registrationPlate, string vIN, string fuelType, decimal price, bool sold, decimal soldPrice, DateTime dateSold, int employeeID, int customerID)
        {
            Id = id;
            Brand = brand;
            Make = make;
            YearMade = yearMade;
            Colour = colour;
            EngineSize = engineSize;
            RegistrationPlate = registrationPlate;
            VIN = vIN;
            FuelType = fuelType;
            Price = price;
            Sold = sold;
            SoldPrice = soldPrice;
            DateSold = dateSold;
            EmployeeID = employeeID;
            CustomerID = customerID;
        }
    }
}
