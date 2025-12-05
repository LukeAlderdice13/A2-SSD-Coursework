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
    public partial class AvailableVehicles : UserControl
    {
        private int visibleVehicles = 0;
        public AvailableVehicles()
        {
            InitializeComponent();

            SearchIcon_pb.Image = SearchIcon_il.Images[0];

            PopulateComboBoxes();

            PopulateVehicles();
        }

        private void PopulateVehicles()
        {
            Vehicles_pnl.Controls.Clear();
            visibleVehicles = 0;

            int i = 0;
            int j = 0;
            int panelWidth = Vehicles_pnl.Width - 23;
            int panelHeight = 253;
            int panelSpacing = 5;
            int currentY = 5;

            Panel panel = null;

            foreach (Vehicle vehicle in Vehicle.vehicles)
            {
                if (vehicle.Sold == false)
                {
                    if (CheckSearch(vehicle))
                    {
                        visibleVehicles++;
                        if (i == 0)
                        {
                            panel = new Panel();
                            Vehicles_pnl.Controls.Add(panel);

                            panel.Size = new Size(panelWidth, panelHeight);
                            panel.Location = new Point(5, currentY);

                            currentY += panelHeight + panelSpacing; // update Y for next panel
                        }
                        Color color = new Color();

                        if (j % 2 == 0)
                        {
                            if (i % 2 == 0)
                            {
                                color = Color.DimGray;
                            }
                            else
                            {
                                color = Color.Gray;
                            }
                        }
                        else
                        {
                            if (i % 2 == 0)
                            {
                                color = Color.DimGray;
                            }
                            else
                            {
                                color = Color.Gray;
                            }
                        }

                        VehicleCard vehicleCard = new VehicleCard(vehicle, color);

                        vehicleCard.Dock = DockStyle.Left; // you can keep docking inside the panel
                        panel.Controls.Add(vehicleCard);

                        if (i == 2)
                        {
                            i = 0;
                            j++;
                        }
                        else
                        {
                            i++;
                        }
                    }                  
                }             
            }
            if (visibleVehicles > 0)
            {
                panel = new Panel();
                Vehicles_pnl.Controls.Add(panel);
                panel.Size = new Size(panelWidth, 5);
                panel.Location = new Point(5, currentY);
            }
            else
            {
                Label noVehicles = new Label();
                noVehicles.Text = "No Vehicles Found";
                noVehicles.Size = new Size(Vehicles_pnl.Width, 60);
                noVehicles.Font = new Font("Adobe Hebrew", 40);
                Vehicles_pnl.Controls.Add(noVehicles);
                noVehicles.Location = new Point(0, 10);
                noVehicles.ForeColor = Color.Red;
                noVehicles.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void PopulateComboBoxes()
        {
            Makes_cb.Items.Clear();
            Makes_cb.Items.Add("All Makes");
            foreach(Make make in Make.makes)
            {
                Makes_cb.Items.Add(make.Name);
            }
            Makes_cb.SelectedIndex = 0;

            Colour_cb.Items.Clear();
            Colour_cb.Items.Add("All Colours");
            List<string> colours = Vehicle.GetVehicleColours();
            foreach(string colour in colours)
            {
                Colour_cb.Items.Add(colour);
            }
            Colour_cb.SelectedIndex = 0;

            FuelType_cb.Items.Clear();
            FuelType_cb.Items.Add("Any Fuel Type");
            List<string> fuelTypes = Vehicle.GetFuelTypes();
            foreach(string f in fuelTypes)
            {
                FuelType_cb.Items.Add(f);
            }
            FuelType_cb.SelectedIndex = 0;

            MaxPrice_nud.Maximum = Vehicle.GetMaxPrice();
            MaxPrice_nud.Value = MaxPrice_nud.Maximum;
        }

        private void SearchIcon_pb_MouseEnter(object sender, EventArgs e)
        {
            SearchIcon_pb.Image = SearchIcon_il.Images[1];
        }

        private void SearchIcon_pb_MouseLeave(object sender, EventArgs e)
        {
            SearchIcon_pb.Image = SearchIcon_il.Images[0];
        }

        private bool CheckSearch(Vehicle vehicle)
        {
            if (Makes_cb.SelectedItem.ToString() != "All Makes" && vehicle.make.Name != Makes_cb.SelectedItem.ToString())
                return false;
            if (!vehicle.Model.ToLower().Contains(ModelName_tbx.Text.ToLower()))
                return false;
            if (Colour_cb.SelectedItem.ToString() != "All Colours" && vehicle.Colour != Colour_cb.SelectedItem.ToString())
                return false;
            if (FuelType_cb.SelectedItem.ToString() != "Any Fuel Type" && vehicle.FuelType != FuelType_cb.SelectedItem.ToString())
                return false;
            if (vehicle.Price > MaxPrice_nud.Value) 
                return false;
            return true;
        }

        private void SearchIcon_pb_Click(object sender, EventArgs e)
        {
            PopulateVehicles();
        }

        private void Search_pnl_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Search_pnl_MouseLeave(object sender, EventArgs e)
        {

        }

        private void ResetSearch_lbl_MouseEnter(object sender, EventArgs e)
        {
            ResetSearch_lbl.ForeColor = Color.White;
        }

        private void ResetSearch_lbl_MouseLeave(object sender, EventArgs e)
        {
            ResetSearch_lbl.ForeColor = Color.Red;
        }

        private void ResetSearch_lbl_Click(object sender, EventArgs e)
        {
            Makes_cb.SelectedIndex = 0;
            Colour_cb.SelectedIndex = 0;
            FuelType_cb.SelectedIndex = 0;
            ModelName_tbx.Text = "";
            MaxPrice_nud.Value = MaxPrice_nud.Maximum;

            PopulateVehicles();
        }
    }
}
