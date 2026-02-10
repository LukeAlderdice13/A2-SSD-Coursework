using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace A2SSDCoursework
{
    public class Validation
    {
        private static readonly Regex sWhitespace = new Regex(@"\s+");
        public static string ReplaceWhitespace(string input, string replacement)
        {
            return sWhitespace.Replace(input, replacement);
        }
        public Validation()
        {

        }

        //Employee & Customer
        public static bool Name(string firstName)
        {
            if (firstName.Trim().Length == 0)
                return false;
            return !firstName.Any(char.IsDigit);
        }

        public static bool Email(string email)
        {
            if (!email.Contains('@'))
                return false;
            int firstIndex = email.IndexOf("@");
            if (firstIndex != email.LastIndexOf("@") && firstIndex != -1)
                return false;
            string[] emailArray = email.Split('@');
            foreach(string s in emailArray)
            {
                if (s.Length == 0)
                    return false;
            }
            return true;
        }

        public static bool PhoneNo(string phoneNo)
        {
            if (phoneNo.Trim().Length != 11)
                return false;
            if (!phoneNo.All(char.IsDigit))
                return false;
            return true;
        }

        public static bool Address(string address)
        {
            address = ReplaceWhitespace(address, "");
            if (address.Trim().Length == 0)
                return false;
            if (!address.All(char.IsLetterOrDigit))
                return false;
            return true;
        }

        public static bool Username(string username)
        {
            if (username.Trim().Length  == 0) 
                return false;
            if (!username.All(char.IsLetterOrDigit))
                return false;
            foreach(Employee e in Employee.employees)
            {
                if (e.Username ==  username) 
                    return false;
            }
            return true;
        }

        public static bool Username(int ID, string username)
        {
            if (username.Trim().Length == 0)
                return false;
            if (!username.All(char.IsLetterOrDigit))
                return false;
            foreach (Employee e in Employee.employees)
            {
                if (e.Username == username && e.EmployeeID != ID)
                    return false;
            }
            return true;
        }

        public static bool Password(string password)
        {
            if (password.Trim().Length < 8)
                return false;
            if (!password.Any(char.IsDigit))
                return false;
            if (!password.Any(char.IsLetter))
                return false;
            if (password.All(char.IsLetterOrDigit))
                return false;
            if (!password.Any(char.IsUpper))
                return false;
            return true;
        }
        //

        //Vehicle
        public static bool Model(string model)
        {
            if (model.Trim().Length == 0)
                return false;
            if (!model.Any(char.IsLetter))
                return false;
            return true;
        }

        public static bool YearMade(string yearMade)
        {
            if (yearMade.Trim().Length != 4)
                return false;
            if (!yearMade.All(char.IsDigit))
                return false;
            if (Convert.ToInt32(yearMade) > 2026 || Convert.ToInt32(yearMade) < 1900)
                return false;
            return true;
        }

        public static bool Colour(string colour)
        {
            if (colour.Trim().Length == 0)
                return false;
            if (!colour.All(char.IsLetter))
                return false;
            return true;
        }

        public static bool PlateVin(string plateNumber)
        {
            if (plateNumber.Trim().Length == 0) 
                return false;
            if (plateNumber.All(char.IsDigit) || plateNumber.All(char.IsLetter))
                return false;
            if (!plateNumber.All(char.IsLetterOrDigit))
                return false;
            return true;
        }

        public static bool FuelType(string fuelType)
        {
            if (fuelType.Trim().Length == 0)
                return false;
            if (!fuelType.All(char.IsLetter))
                return false;
            return true;
        }
        //
    }
}
