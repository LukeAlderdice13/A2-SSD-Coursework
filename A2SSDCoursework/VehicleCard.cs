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
        private Color colour = new Color();
        public VehicleCard()
        {
            InitializeComponent();
        }

        public VehicleCard(Vehicle vehicle, Color color)
        {
            InitializeComponent();

            BackColor = color;
            colour = color;
            Backing_lbl.BackColor = color;
            this.vehicle = vehicle;

            Make_lbl.Text = vehicle.make.Name;
            Model_lbl.Text = vehicle.Model;
            Colour_lbl.Text = $"Colour: {vehicle.Colour}";
            EngineSize_lbl.Text = $"Engine Size: {vehicle.EngineSize}";
            FuelType_lbl.Text = $"Fuel Type: {vehicle.FuelType}";
            Plate_lbl.Text = $"Plate: {vehicle.RegistrationPlate}";
            Price_lbl.Text = vehicle.Sold ? $"Sold For: £{vehicle.SoldPrice}" : $"Price: £{vehicle.Price}";

            AddMouseEvents(this);
        }

        private void AddMouseEvents(Control parent)
        {
            parent.MouseEnter += VehicleCard_MouseEnter;
            parent.MouseLeave += VehicleCard_MouseLeave;

            foreach (Control c in parent.Controls)
            {
                AddMouseEvents(c);
            }
        }

        private void ViewVehicle_btn_Click(object sender, EventArgs e)
        {
            MainMenu.MenuInstance.ChangeMainDisplay(new ViewVehicle(vehicle));
        }

        private void ViewVehicle_btn_MouseEnter(object sender, EventArgs e)
        {
            ViewVehicle_btn.ForeColor = Color.White;
        }

        private void ViewVehicle_btn_MouseLeave(object sender, EventArgs e)
        {
            ViewVehicle_btn.ForeColor = Color.Black;
        }

        private void VehicleCard_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void VehicleCard_MouseLeave(object sender, EventArgs e)
        {
            BackColor = colour;
        }
    }
}
