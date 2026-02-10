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
    public partial class IndividualSalesReport : UserControl
    {
        private Employee employee = new Employee();
        public IndividualSalesReport()
        {
            InitializeComponent();
        }

        public IndividualSalesReport(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            SalesType_cb.SelectedIndex = 0;
        }

        private void GenerateReport()
        {
            ReportData data = new ReportData();

            List<IndividualEmployeeSales> Sales = new List<IndividualEmployeeSales>();
            
            if (SalesType_cb.SelectedIndex != 2)
            {
                foreach (Vehicle v in employee.SoldVehicles)
                {
                    IndividualEmployeeSales individualEmployeeSales = new IndividualEmployeeSales(employee.FullName, employee.status.StatusName, "Sale", v.SoldPrice, v.DateSold);
                    Sales.Add(individualEmployeeSales);
                }
            }

            if (SalesType_cb.SelectedIndex != 1)
            {
                foreach (Service s in employee.Services)
                {
                    IndividualEmployeeSales individualEmployeeSales = new IndividualEmployeeSales(employee.FullName, employee.status.StatusName, "Service", s.Cost, s.ServiceDate);
                    Sales.Add(individualEmployeeSales);
                }
            }

            if (Sales.Count > 0)
            {
                Sales.Sort((v1, v2) => v2.Date.CompareTo(v1.Date));

                foreach (IndividualEmployeeSales s in Sales)
                {
                    var row = data.IndividualSales.NewDataRow();
                    row["Name"] = s.Name;
                    row["Status"] = s.Status;
                    row["Type"] = s.Type;
                    row["Price"] = s.Price;
                    row["Date"] = s.Date;

                    data.IndividualSales.Rows.Add(row);
                }

                var rds = new ReportDataSource("IndividualEmployee_ds", data.IndividualSales);

                EmployeeReport_rv.LocalReport.DataSources.Clear();
                EmployeeReport_rv.LocalReport.DataSources.Add(rds);

                EmployeeReport_rv.RefreshReport();
            }
            else if (SalesType_cb.SelectedIndex == 0)
            {
                MessageBox.Show("Report Empty", "Report Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainMenu.MenuInstance.ReturnToPreviousDisplay();
            }
            else
            {
                MessageBox.Show("Report Empty", "Report Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeReport_rv_Load(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport_btn_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }
    }
}
