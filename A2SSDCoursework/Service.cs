using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SSDCoursework
{
    public class Service
    {
        public int ServiveID { get; set; }
        public int VehicleID { get; set; }
        public DateTime ServiceDate { get; set; }
        public int EmployeeID { get; set; }

        public Service()
        {

        }

        public Service(int serviveID, int vehicleID, DateTime serviceDate, int employeeID)
        {
            ServiveID = serviveID;
            VehicleID = vehicleID;
            ServiceDate = serviceDate;
            EmployeeID = employeeID;
        }
    }
}
