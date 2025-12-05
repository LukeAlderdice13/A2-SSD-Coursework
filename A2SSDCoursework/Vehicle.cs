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
        public static List<Vehicle> vehicles = new List<Vehicle>();
        public int Id { get; set; }
        public Make make = new Make();
        public string Model { get; set; }
        public string YearMade { get; set; }
        public string Colour { get; set; }
        public decimal EngineSize { get; set; }
        public string RegistrationPlate { get; set; }
        public string VIN { get; set; }
        public string FuelType { get; set; }
        public decimal Price { get; set; }
        public DateTime DatePurchased { get; set; }
        public bool Sold { get; set; }
        public decimal SoldPrice { get; set; }
        public DateTime DateSold { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public List<Service> ServiceHistory = new List<Service>();

        public Vehicle()
        {

        }

        public Vehicle(int id,string Model, Make make, string yearMade, string colour, decimal engineSize, string registrationPlate, string VIN, string fuelType, decimal price, DateTime DatePurchased)
        {
            Id = id;
            this.Model = Model;
            this.make = make;
            YearMade = yearMade;
            Colour = colour;
            EngineSize = engineSize;
            RegistrationPlate = registrationPlate;
            this.VIN = VIN;
            FuelType = fuelType;
            Price = price;
            Sold = false;
            this.DatePurchased = DatePurchased;
        }

        public Vehicle(int id, string Model, Make make, string yearMade, string colour, decimal engineSize, string registrationPlate, string VIN, string fuelType, decimal price, bool sold, decimal soldPrice, DateTime dateSold, int employeeID, int customerID)
        {
            Id = id;
            this.Model = Model;
            this.make = make;
            YearMade = yearMade;
            Colour = colour;
            EngineSize = engineSize;
            RegistrationPlate = registrationPlate;
            this.VIN = VIN;
            FuelType = fuelType;
            Price = price;
            Sold = sold;
            SoldPrice = soldPrice;
            DateSold = dateSold;
            EmployeeID = employeeID;
            CustomerID = customerID;
        }

        public static bool CheckIfExists(int ID)
        {
            foreach(Vehicle vehicle in vehicles)
            {
                if (vehicle.Id == ID)
                {
                    return false;
                }
            }

            return true;
        }

        public static void AddService(int VehicleID, Service service)
        {
            foreach(Vehicle vehicle in vehicles)
            {
                if (vehicle.Id == VehicleID)
                {
                    vehicle.ServiceHistory.Add(service);
                }
            }
        }

        public static int GetSoldPrice(int VehicleID)
        {
            foreach(Vehicle vehicle in vehicles)
            {
                if (vehicle.Id == VehicleID)
                {
                    return (int)vehicle.SoldPrice;
                }
            }
            return 0;
        }

        public static List<Vehicle> GetVehiclesFromIDs(List<int> IDs)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            foreach(int id in IDs)
            {
                foreach(Vehicle v in vehicles)
                {
                    if(v.Id == id)
                    {
                        vehicleList.Add(v);
                        break;
                    }
                }
            }
            return vehicleList;
        }

        public static List<string> GetVehicleColours()
        {
            List<string> colours = new List<string>();
            foreach(Vehicle vehicle in vehicles)
            {
                if (!colours.Contains(vehicle.Colour))
                {
                    colours.Add(vehicle.Colour);
                }
            }
            return colours;
        }

        public static List<string> GetFuelTypes()
        {
            List<string> FuelTypes = new List<string>();
            foreach (Vehicle vehicle in vehicles)
            {
                if (!FuelTypes.Contains(vehicle.FuelType))
                {
                    FuelTypes.Add(vehicle.FuelType);
                }
            }
            return FuelTypes;
        }

        public static int GetMaxPrice()
        {
            decimal maxPrice = 0;
            foreach(Vehicle v in vehicles)
            {
                if (v.Price > maxPrice)
                    maxPrice = v.Price;
            }
            return (int)maxPrice;
        }
    }
}
