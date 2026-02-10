using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SSDCoursework
{
    public class EmployeeSales
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public decimal Salary { get; set; }
        public decimal Sales { get; set; }
        public decimal Services { get; set; }
        public decimal Total { get; set; }
        public string SelectedEmployee { get; set; }
        public string SelectedStatus { get; set; }
    }

    public class IndividualEmployeeSales : EmployeeSales
    {
        public string Type { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public IndividualEmployeeSales()
        {

        }

        public IndividualEmployeeSales(string Name, string Status, string type, decimal price, DateTime date)
        {
            this.Name = Name;
            this.Status = Status;
            Type = type;
            Price = price;
            Date = date;
        }
    }
}
