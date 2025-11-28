using A2_SSD_Coursework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2SSDCoursework
{
    public partial class ViewVehicle : UserControl
    {
        public Vehicle vehicle = new Vehicle();
        public ViewVehicle()
        {
            InitializeComponent();
        }

        public ViewVehicle(Vehicle vehicle)
        {
            InitializeComponent();

            this.vehicle = vehicle;
        }
    }
}
