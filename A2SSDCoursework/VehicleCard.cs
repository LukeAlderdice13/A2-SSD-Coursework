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
    public partial class VehicleCard : UserControl
    {
        public Vehicle vehicle = new Vehicle();
        public VehicleCard()
        {
            InitializeComponent();
        }

        public VehicleCard(Vehicle vehicle, Color color)
        {
            InitializeComponent();

            BackColor = color;
            this.vehicle = vehicle;

            Make_lbl.Text = vehicle.make.Name;
            Model_lbl.Text = vehicle.Model;
            Colour_lbl.Text = $"Colour: {vehicle.Colour}";
            EngineSize_lbl.Text = $"Engine Size: {vehicle.EngineSize}";
            FuelType_lbl.Text = $"Fuel Type: {vehicle.FuelType}";
            Plate_lbl.Text = $"Plate: {vehicle.RegistrationPlate}";
            Price_lbl.Text = $"Price: £{vehicle.Price}";
        }

        private void ViewVehicle_btn_Click(object sender, EventArgs e)
        {
            MainMenu.MenuInstance.ChangeMainDisplay(new ViewVehicle(vehicle));
        }
    }
}
