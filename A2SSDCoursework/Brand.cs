using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SSDCoursework
{
    public class Brand
    {
        public int BrandID { get; set; }
        public string Name { get; set; }

        public Brand() 
        { 

        }

        public Brand(int brandID, string name)
        {
            BrandID = brandID;
            Name = name;
        }
    }
}
