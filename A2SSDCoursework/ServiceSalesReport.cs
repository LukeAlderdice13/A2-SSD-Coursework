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
    public partial class ServiceSalesReport : UserControl
    {
        public ServiceSalesReport()
        {
            InitializeComponent();

            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            Dictionary<int, string> VehicleData = new Dictionary<int, string>();
            VehicleData.Add(-1, "All Vehicles");
            foreach(Vehicle v in Vehicle.vehicles)
            {
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

            Dictionary<int, string> EmployeeData = new Dictionary<int, string>();
            EmployeeData.Add(-1, "All Employees");
            foreach (Employee e in Employee.employees)
            {
                EmployeeData.Add(e.EmployeeID, e.FullName);
            }
            Employees_cb.DataSource = EmployeeData.ToArray();

            Employees_cb.DisplayMember = "Value";
            Employees_cb.ValueMember = "Key";

            Employees_cb.SelectedIndex = 0;
        }

        private void ServiceSales_rv_Load(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            ReportData data = new ReportData();

            List<Service> Services = new List<Service>();

            foreach (Vehicle v in Vehicle.vehicles)
            {
                if (CheckVehicle(v))
                {
                    foreach(Service s in v.ServiceHistory)
                    {
                        if (Employees_cb.SelectedIndex == 0 || s.employee.EmployeeID == (int)Employees_cb.SelectedValue)
                            Services.Add(s);
                    }
                }
            }

            if (Services.Count > 0)
            {
                Services.Sort((v1, v2) => v2.ServiceDate.CompareTo(v1.ServiceDate));

                foreach (Service service in Services)
                {
                    var row = data.ServiceSales.NewDataRow();
                    row["Make"] = service.vehicle.make.Name;
                    row["Model"] = service.vehicle.Model;
                    row["Type"] = service.ServiceType;
                    row["Employee"] = service.employee.FullName;
                    row["Date"] = service.ServiceDate;
                    row["Price"] = service.Cost;
                    if (service.vehicle.Sold)
                    {
                        row["Internal"] = service.vehicle.DateSold <= service.ServiceDate ? "Yes" : "No";
                    }
                    else
                    {
                        row["Internal"] = "No";
                    }
                    row["SelectedVehicle"] = Vehicles_cb.Text;
                    row["SelectedMake"] = Makes_cb.Text;
                    row["SelectedEmployee"] = Employees_cb.Text;

                    data.ServiceSales.Rows.Add(row);
                }

                var rds = new ReportDataSource("ServiceSales_ds", data.ServiceSales);

                ServiceSales_rv.LocalReport.DataSources.Clear();
                ServiceSales_rv.LocalReport.DataSources.Add(rds);

                ServiceSales_rv.RefreshReport();
            }
            else
            {
                MessageBox.Show("Report Empty", "Report Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateReport_btn_Click(object sender, EventArgs e)
        {
            GenerateReport();
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
    }
}
