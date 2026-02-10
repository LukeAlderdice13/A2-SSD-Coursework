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
    public partial class AddVehicle : UserControl
    {
        public int MakeID = -1;
        public AddVehicle()
        {
            InitializeComponent();
        }

        public AddVehicle(int MakeID)
        {
            InitializeComponent();

            this.MakeID = MakeID;
        }

        private void PopulateMakes()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            foreach (Make make in Make.makes)
            {
                myDictionary.Add(make.MakeID, $"{make.Name}");
            }
            Makes_cb.DataSource = myDictionary.ToArray();

            Makes_cb.DisplayMember = "Value";
            Makes_cb.ValueMember = "Key";

            if (MakeID != -1)
            {
                Makes_cb.SelectedValue = MakeID;
            }
            else
            {
                if (Makes_cb.Items.Count > 0)
                {
                    Makes_cb.SelectedIndex = MakeID;
                }
                else
                {
                    MessageBox.Show("You must add a vehicle make before creating a vehicle", "Unable to Create New Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MainMenu.MenuInstance.ReloadDisplay(new ViewMakes());
                }
            }

        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {
            PopulateMakes();
        }

        private void AddVehicle_btn_Click(object sender, EventArgs e)
        {
            if (AddVehicle_btn.BackColor == Color.SteelBlue)
            {
                Make make = Make.MakeFromID((int)Makes_cb.SelectedValue);
                Vehicle vehicle = new Vehicle(Vehicle.NextID(), Model_tbx.Text.Trim(), make, YearMade_tbx.Text.Trim(), Colour_tbx.Text.Trim(), Math.Round(EngineSize_nud.Value, 2), Registration_tbx.Text.Trim(), Vin_tbx.Text.Trim(), FuelType_tbx.Text.Trim(), Math.Round(Price_nud.Value, 2), DatePurchased_dtp.Value);
                Vehicle.vehicles.Add(vehicle);
                ProjectDal.AddVehicle(vehicle);
                MessageBox.Show("Vehicle added", "Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.MenuInstance.ReloadDisplay(new AddVehicle());
            }
        }

        private void Model_tbx_TextChanged(object sender, EventArgs e)
        {
            if(Validation.Model(Model_tbx.Text.Trim()))
            {
                Model_lbl.ForeColor = Color.Black;
            }
            else
            {
                Model_lbl.ForeColor = Color.Firebrick;
            }
            UpdateColour();
        }

        private void YearMade_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Validation.YearMade(YearMade_tbx.Text.Trim()))
            {
                YearMade_lbl.ForeColor = Color.Black;
            }
            else
            {
                YearMade_lbl.ForeColor = Color.Firebrick;
            }
            UpdateColour();
        }

        private void Colour_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Validation.Colour(Colour_tbx.Text.Trim()))
            {
                Colour_lbl.ForeColor = Color.Black;
            }
            else
            {
                Colour_lbl.ForeColor = Color.Firebrick;
            }
            UpdateColour();
        }

        private void Registration_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Validation.PlateVin(Registration_tbx.Text.Trim()))
            {
                Registration_lbl.ForeColor = Color.Black;
            }
            else
            {
                Registration_lbl.ForeColor = Color.Firebrick;
            }
            UpdateColour();
        }

        private void Vin_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Validation.PlateVin(Vin_tbx.Text.Trim()))
            {
                Vin_lbl.ForeColor = Color.Black;
            }
            else
            {
                Vin_lbl.ForeColor = Color.Firebrick;
            }
            UpdateColour();
        }

        private void FuelType_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Validation.FuelType(FuelType_tbx.Text.Trim()))
            {
                FuelType_lbl.ForeColor = Color.Black;
            }
            else
            {
                FuelType_lbl.ForeColor = Color.Firebrick;
            }
            UpdateColour();
        }

        private void YearMade_tbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Price_nud_ValueChanged(object sender, EventArgs e)
        {
            if (Price_nud.Value > 0)
            {
                Price_lbl.ForeColor = Color.Black;
            }
            else
            {
                Price_lbl.ForeColor = Color.Firebrick;
            }
            UpdateColour();
        }

        private void EngineSize_nud_ValueChanged(object sender, EventArgs e)
        {
            if (EngineSize_nud.Value > 0)
            {
                EngineSize_lbl.ForeColor = Color.Black;
            }
            else
            {
                EngineSize_lbl.ForeColor = Color.Firebrick;
            }
            UpdateColour();
        }

        private void Model_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                YearMade_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                FuelType_tbx.Focus();
            }
        }

        private void YearMade_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Colour_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Model_tbx.Focus();
            }
        }

        private void Colour_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Registration_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                YearMade_tbx.Focus();
            }
        }

        private void Registration_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Vin_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Colour_tbx.Focus();
            }
        }

        private void Vin_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                FuelType_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Registration_tbx.Focus();
            }
        }

        private void FuelType_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Model_tbx.Focus();  
            }
            else if (e.KeyCode == Keys.Up)
            {
                Vin_tbx.Focus();
            }
        }

        private void UpdateColour()
        {
            AddVehicle_btn.BackColor = Color.SteelBlue;
            foreach(Control c in this.Controls)
            {
                if (c is NumericUpDown n)
                {
                    if (n.Value == 0)
                    {
                        AddVehicle_btn.BackColor = Color.Firebrick;
                        return;
                    }
                }
            }
            if (!Validation.Model(Model_tbx.Text.Trim()))
            {
                AddVehicle_btn.BackColor = Color.Firebrick;
                return;
            }
            if (!Validation.YearMade(YearMade_tbx.Text.Trim()))
            {
                AddVehicle_btn.BackColor = Color.Firebrick;
                return;
            }           
            if (!Validation.Colour(Colour_tbx.Text.Trim()))
            {
                AddVehicle_btn.BackColor = Color.Firebrick;
                return;
            }               
            if (!Validation.PlateVin(Registration_tbx.Text.Trim()))
            {
                AddVehicle_btn.BackColor = Color.Firebrick;
                return;
            }
            if (!Validation.PlateVin(Vin_tbx.Text.Trim()))
            {
                AddVehicle_btn.BackColor = Color.Firebrick;
                return;
            }
            if (!Validation.FuelType(FuelType_tbx.Text.Trim()))
            {
                AddVehicle_btn.BackColor = Color.Firebrick;
                return;
            }
        }
    }
}
