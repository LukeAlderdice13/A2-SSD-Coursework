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

            if (!vehicle.Sold && Employee.employees[Employee.currentEmployee].MaxAccessLevel == 3)
            {
                Edit_pnl.Visible = true;

                if (vehicle.ServiceHistory.Count > 0)
                {
                    Delete_btn.Visible = false;
                }
                UpdateInfo_btn.Visible = true;

                Dictionary<int, string> data = new Dictionary<int, string>();
                foreach (Make make in Make.makes)
                {
                    data.Add(make.MakeID, make.Name);
                }
                Make_cb.DataSource = data.ToArray();

                Make_cb.DisplayMember = "Value";
                Make_cb.ValueMember = "Key";

                Make_cb.SelectedValue = vehicle.make.MakeID;

                Model_tbx.Text = $"{vehicle.Model}";
                YearMade_tbx.Text = $"{vehicle.YearMade}";
                Colour_tbx.Text = $"{vehicle.Colour}";
                EngineSize_nud.Value = vehicle.EngineSize;
                PlateNumber_tbx.Text = $"{vehicle.RegistrationPlate}";
                Vin_tbx.Text = $"{vehicle.VIN}";
                FuelType_tbx.Text = $"{vehicle.FuelType}";
                Price_nud.Value = vehicle.Price;
                DatePurchased_dtp.Value = vehicle.DatePurchased;
            }
            else
            {
                Make_lbl.Text = $"{vehicle.make.Name}";
                Model_lbl.Text = $"{vehicle.Model}";
                YearMade_lbl.Text = $"{vehicle.YearMade}";
                Colour_lbl.Text = $"{vehicle.Colour}";
                EngineSize_lbl.Text = $"{vehicle.EngineSize}";
                Plate_lbl.Text = $"{vehicle.RegistrationPlate}";
                Vin_lbl.Text = $"{vehicle.VIN}";
                FuelType_lbl.Text = $"{vehicle.FuelType}";
                Price_lbl.Text = $"£{vehicle.Price}";
                DatePurchased_lbl.Text = $"{vehicle.DatePurchased.ToString("dd/MM/yyyy")}";
            }

            if (vehicle.Sold)
            {
                SalesInfo_pnl.Visible = true;

                Delete_btn.Visible = false;
                Sell_btn.Visible = false;
                MinSellPrice_lbl.Visible = false;

                DateSold_lbl.Text = $"{vehicle.DateSold.ToString("dd/MM/yyyy")}";
                SoldPrice_lbl.Text = $"£{vehicle.SoldPrice}";
                Employee_lbl.Text = Employee.GetEmployeeFromID(vehicle.EmployeeID).FullName;
                Customer_lbl.Text = Customer.GetCustomerFromID(vehicle.CustomerID).FullName;
            }
            else
            {
                Controls_pnl.Left = 235;
                DateTime currentDate = DateTime.Now;

                TimeSpan duration = currentDate - vehicle.DatePurchased;

                decimal years = Math.Floor((decimal)duration.TotalDays / 365);
                decimal PriceReduction = 1 - (years / 100);

                minSellPrice = Convert.ToInt32(Math.Floor(vehicle.Price * PriceReduction));
                MinSellPrice_lbl.Text = $"£{minSellPrice}";
                MinSellPriceEdit_lbl.Text = $"£{minSellPrice}";
            }
        }

        private void RecordService_btn_Click(object sender, EventArgs e)
        {
            MainMenu.MenuInstance.ChangeMainDisplay(new RecordService(vehicle));
        }

        private void ServiceHistory_btn_Click(object sender, EventArgs e)
        {
            MainMenu.MenuInstance.ChangeMainDisplay(new ServiceHistory(vehicle));
        }

        private void Sell_btn_Click(object sender, EventArgs e)
        {
            MainMenu.MenuInstance.ChangeMainDisplay(new SellVehicle(vehicle));
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Confirm Deletion of Vehicle", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Vehicle.RemoveVehicle(vehicle.Id);
                ProjectDal.DeleteVehicle(vehicle.Id);
                MessageBox.Show("Vehicle deleted", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.MenuInstance.ClearHistory();
                MainMenu.MenuInstance.ChangeMainDisplay(new AvailableVehicles());
            }
        }

        private void ChangeUpdateColour()
        {
            UpdateInfo_btn.BackColor = Color.DimGray;
            foreach (Control c in Edit_pnl.Controls)
            {
                if (c is Label l)
                {
                    if (l.ForeColor == Color.Green)
                    {
                        UpdateInfo_btn.BackColor = Color.DarkGreen;
                    }
                    else if (l.ForeColor == Color.Firebrick)
                    {
                        UpdateInfo_btn.BackColor = Color.Firebrick;
                        break;
                    }
                }
            }
        }

        private void Make_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            int value = 0;
            if(int.TryParse(Make_cb.SelectedValue.ToString(), out value))
            {
                if (value == vehicle.make.MakeID)
                {
                    MakeEdit_lbl.ForeColor = Color.Black;
                }
                else
                {
                    MakeEdit_lbl.ForeColor = Color.Green;
                }
            }
            ChangeUpdateColour();
        }

        private void Model_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Model_tbx.Text.Trim() == vehicle.Model)
            {
                ModelEdit_lbl.ForeColor = Color.Black;
            }
            else if (!Validation.Model(Model_tbx.Text.Trim()))
            {
                ModelEdit_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                ModelEdit_lbl.ForeColor = Color.Green;
            }
            ChangeUpdateColour();
        }

        private void YearMade_tbx_TextChanged(object sender, EventArgs e)
        {
            if (YearMade_tbx.Text.Trim() == vehicle.YearMade)
            {
                YearMadeEdit_lbl.ForeColor = Color.Black;
            }
            else if (!Validation.YearMade(YearMade_tbx.Text.Trim()))
            {
                YearMadeEdit_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                YearMadeEdit_lbl.ForeColor = Color.Green;
            }
            ChangeUpdateColour();
        }

        private void Colour_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Colour_tbx.Text.Trim() == vehicle.Colour)
            {
                ColourEdit_lbl.ForeColor = Color.Black;
            }
            else if (!Validation.Colour(Colour_tbx.Text.Trim()))
            {
                ColourEdit_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                ColourEdit_lbl.ForeColor = Color.Green;
            }
            ChangeUpdateColour();
        }

        private void EngineSize_nud_ValueChanged(object sender, EventArgs e)
        {
            if (EngineSize_nud.Value == vehicle.EngineSize)
            {
                EngineSizeEdit_lbl.ForeColor = Color.Black;
            }
            else if (EngineSize_nud.Value == 0)
            {
                EngineSizeEdit_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                EngineSizeEdit_lbl.ForeColor = Color.Green;
            }
            ChangeUpdateColour();
        }

        private void Price_nud_ValueChanged(object sender, EventArgs e)
        {
            if (Price_nud.Value == vehicle.Price)
            {
                PriceEdit_lbl.ForeColor = Color.Black;
            }
            else if (Price_nud.Value == 0)
            {
                PriceEdit_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                PriceEdit_lbl.ForeColor = Color.Green;
            }
            ChangeUpdateColour();
        }

        private void Vin_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Vin_tbx.Text.Trim() == vehicle.VIN)
            {
                VinEdit_lbl.ForeColor = Color.Black;
            }
            else if (!Validation.PlateVin(Vin_tbx.Text.Trim()))
            {
                VinEdit_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                VinEdit_lbl.ForeColor = Color.Green;
            }
            ChangeUpdateColour();
        }

        private void FuelType_tbx_TextChanged(object sender, EventArgs e)
        {
            if (FuelType_tbx.Text.Trim() == vehicle.FuelType)
            {
                FuelTypeEdit_lbl.ForeColor = Color.Black;
            }
            else if (!Validation.FuelType(FuelType_tbx.Text.Trim()))
            {
                FuelTypeEdit_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                FuelTypeEdit_lbl.ForeColor = Color.Green;
            }
            ChangeUpdateColour();
        }

        private void PlateNumber_tbx_TextChanged(object sender, EventArgs e)
        {
            if (PlateNumber_tbx.Text.Trim() == vehicle.RegistrationPlate)
            {
                PlateNumberEdit_lbl.ForeColor = Color.Black;
            }
            else if (!Validation.PlateVin(PlateNumber_tbx.Text.Trim()))
            {
                PlateNumberEdit_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                PlateNumberEdit_lbl.ForeColor = Color.Green;
            }
            ChangeUpdateColour();
        }

        private void DatePurchased_dtp_ValueChanged(object sender, EventArgs e)
        {
            if (DatePurchased_dtp.Value == vehicle.DatePurchased)
            {
                DatePurchasedEdit_lbl.ForeColor = Color.Black;
            }
            else
            {
                DatePurchasedEdit_lbl.ForeColor = Color.Green;
            }
            ChangeUpdateColour();
        }

        private void UpdateInfo_btn_Click(object sender, EventArgs e)
        {
            if (UpdateInfo_btn.BackColor == Color.DarkGreen)
            {
                Make make = Make.MakeFromID((int)Make_cb.SelectedValue);
                vehicle.make = make;
                vehicle.Model = Model_tbx.Text.Trim();
                vehicle.YearMade = YearMade_tbx.Text.Trim();
                vehicle.Colour = Colour_tbx.Text.Trim();
                vehicle.EngineSize = EngineSize_nud.Value;
                vehicle.Price = Price_nud.Value;
                vehicle.VIN = Vin_tbx.Text.Trim();
                vehicle.FuelType = FuelType_tbx.Text.Trim();
                vehicle.RegistrationPlate = PlateNumber_tbx.Text.Trim();
                vehicle.DatePurchased = DatePurchased_dtp.Value;

                ProjectDal.EditVehicle(vehicle);

                MessageBox.Show("Vehicle edited", "Edit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.MenuInstance.ReloadDisplay(new ViewVehicle(vehicle));
            }
        }
    }
}
