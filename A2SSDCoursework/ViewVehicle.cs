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
        public int minSellPrice = 0;
        public ViewVehicle()
        {
            InitializeComponent();
        }

        public ViewVehicle(Vehicle vehicle)
        {
            InitializeComponent();

            this.vehicle = vehicle;
 
            if (vehicle.Sold)
            {
                Delete_btn.Visible = false;
                Sell_btn.Visible = false;
            }

            Make_lbl.Text = $"Make: {vehicle.make.Name}";
            Model_lbl.Text = $"Model: {vehicle.Model}";
            YearMade_lbl.Text = $"Year Made: {vehicle.YearMade}";
            Colour_lbl.Text = $"Colour: {vehicle.Colour}";
            EngineSize_lbl.Text = $"Engine Size: {vehicle.EngineSize}";
            Plate_lbl.Text = $"Plate Number: {vehicle.RegistrationPlate}";
            Vin_lbl.Text = $"Vin: {vehicle.VIN}";
            FuelType_lbl.Text = $"Fuel Type: {vehicle.FuelType}";
            Price_lbl.Text = $"Price: £{vehicle.Price}";

            DateTime currentDate = DateTime.Now;

            TimeSpan duration = currentDate - vehicle.DatePurchased;

            decimal years = Math.Floor((decimal)duration.TotalDays / 365);
            decimal PriceReduction = 1 - (years / 100);

            minSellPrice = Convert.ToInt32(Math.Floor(vehicle.Price * PriceReduction));
            minSellPrice_lbl.Text = $"Min Sell Price: £{minSellPrice}";

            DatePurchased_lbl.Text = $"Date Purchased: {vehicle.DatePurchased.ToString("dd/MM/yyyy")}";
        }

        private void VehicleInfo_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ReturnArrow_pb_MouseEnter(object sender, EventArgs e)
        {
            ReturnArrow_pb.Image = ReturnArrow_il.Images[1];
        }

        private void ReturnArrow_pb_MouseLeave(object sender, EventArgs e)
        {
            ReturnArrow_pb.Image = ReturnArrow_il.Images[0];
        }

        private void ReturnArrow_pb_Click(object sender, EventArgs e)
        {
            MainMenu.MenuInstance.ReturnToPreviousDisplay();
        }

        private void RecordService_btn_Click(object sender, EventArgs e)
        {
            MainMenu.MenuInstance.ChangeMainDisplay(new RecordService());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ServiceHistory_btn_Click(object sender, EventArgs e)
        {
            MainMenu.MenuInstance.ChangeMainDisplay(new ServiceHistory(vehicle));
        }
    }
}
