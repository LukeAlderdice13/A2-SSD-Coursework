using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SSDCoursework
{
    public class VehicleSale
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public DateTime SoldDate { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal SellPrice { get; set; }
        public string Customer { get; set; }
        public string Employee { get; set; }
        public string SelectedVehicle { get; set; }
        public string SelectedMake { get; set; }
        public VehicleSale()
        {

        }
    }
}
