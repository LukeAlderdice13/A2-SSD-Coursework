using A2_SSD_Coursework;
using Microsoft.Reporting.WinForms;
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
    public partial class VehicleSalesReport : UserControl
    {
        public VehicleSalesReport()
        {
            InitializeComponent();

            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            Dictionary<int, string> VehicleData = new Dictionary<int, string>();
            VehicleData.Add(-1, "All Vehicles");
            foreach (Vehicle v in Vehicle.vehicles)
            {
                if (v.Sold)
                    VehicleData.Add(v.Id, $"{v.make.Name} {v.Model}");
            }
            Vehicles_cb.DataSource = VehicleData.ToArray();

            Vehicles_cb.DisplayMember = "Value";
            Vehicles_cb.ValueMember = "Key";

            Vehicles_cb.SelectedIndex = 0;

            Dictionary<int, string> MakeData = new Dictionary<int, string>();
            MakeData.Add(-1, "All Makes");
            foreach (Make m in Make.makes)
            {
                MakeData.Add(m.MakeID, m.Name);
            }
            Makes_cb.DataSource = MakeData.ToArray();

            Makes_cb.DisplayMember = "Value";
            Makes_cb.ValueMember = "Key";

            Makes_cb.SelectedIndex = 0;
        }

        private void VehicleSalesReport_Load(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            ReportData data = new ReportData();

            Vehicle.vehicles.Sort((v1, v2) => v1.DateSold.CompareTo(v2.DateSold));

            List<Vehicle> vehicleList = new List<Vehicle>();

            foreach (Vehicle vehicle in Vehicle.vehicles)
            {
                if (vehicle.Sold && CheckVehicle(vehicle))
                {
                    vehicleList.Add(vehicle);
                }
            }

            if (vehicleList.Count > 0)
            {
                vehicleList.Sort((v1, v2) => v2.DateSold.CompareTo(v1.DateSold));

                foreach (Vehicle vehicle in vehicleList)
                {
                    var row = data.VehicleSales.NewDataRow();
                    row["Make"] = vehicle.make.Name;
                    row["Model"] = vehicle.Model;
                    row["SoldDate"] = vehicle.DateSold;
                    row["OriginalPrice"] = vehicle.Price;
                    row["SellPrice"] = vehicle.SoldPrice;
                    row["Customer"] = Customer.GetCustomerFromID(vehicle.CustomerID).FullName;
                    row["Employee"] = Employee.GetEmployeeFromID(vehicle.EmployeeID).FullName;
                    row["SelectedVehicle"] = Vehicles_cb.Text;
                    row["SelectedMake"] = Makes_cb.Text;

                    data.VehicleSales.Rows.Add(row);
                }

                var rds = new ReportDataSource("VehicleSale_ds", data.VehicleSales);

                VehicleSales_rv.LocalReport.DataSources.Clear();
                VehicleSales_rv.LocalReport.DataSources.Add(rds);

                VehicleSales_rv.RefreshReport();
            }
            else
            {
                MessageBox.Show("Report Empty", "Report Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckVehicle(Vehicle vehicle)
        {
            if (Vehicles_cb.SelectedIndex == 0 && Makes_cb.SelectedIndex == 0)
                return true;
            else if (Vehicles_cb.SelectedIndex != 0 && Makes_cb.SelectedIndex != 0)
            {
                if (vehicle.Id == (int)Vehicles_cb.SelectedValue && vehicle.make.MakeID == (int)Makes_cb.SelectedValue)
                    return true;
                else
                    return false;
            }
            else if (Vehicles_cb.SelectedIndex != 0)
            {
                if (vehicle.Id == (int)Vehicles_cb.SelectedValue)
                    return true;
                else
                    return false;
            }
            else
            {
                if (vehicle.make.MakeID == (int)Makes_cb.SelectedValue)
                    return true;
                else
                    return false;
            }
        }

        private void GenerateReport_btn_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }
    }
}
