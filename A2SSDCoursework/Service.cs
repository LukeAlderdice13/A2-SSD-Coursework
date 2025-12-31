using A2_SSD_Coursework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SSDCoursework
{
    public class Service
    {
        public int ServiceID { get; set; }
        public Vehicle vehicle = new Vehicle();
        public DateTime ServiceDate { get; set; }
        public Employee employee = new Employee();
        public string ServiceType { get; set; }
        public decimal Cost { get; set; }

        public Service()
        {

        }

        public Service(int serviceID, Vehicle vehicle, DateTime serviceDate, Employee employee, string type, decimal cost)
        {
            ServiceID = serviceID;
            this.vehicle = vehicle;
            ServiceDate = serviceDate;
            this.employee = employee;
            ServiceType = type;
            Cost = cost;
        }

        public Service(Vehicle vehicle, DateTime serviceDate, Employee employee, string type, decimal cost)
        {
            this.vehicle = vehicle;
            ServiceDate = serviceDate;
            this.employee = employee;
            ServiceType = type;
            Cost = cost;
        }
    }
}
