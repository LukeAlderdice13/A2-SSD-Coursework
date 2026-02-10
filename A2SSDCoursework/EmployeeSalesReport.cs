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
    public partial class EmployeeSalesReport : UserControl
    {
        public EmployeeSalesReport()
        {
            InitializeComponent();

            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            Dictionary<int, string> StatusData = new Dictionary<int, string>();
            StatusData.Add(-1, "All Statuses");
            foreach (Status s in Status.statuses)
            {
                StatusData.Add(s.StatusId, s.StatusName);
            }
            Statuses_cb.DataSource = StatusData.ToArray();

            Statuses_cb.DisplayMember = "Value";
            Statuses_cb.ValueMember = "Key";

            Statuses_cb.SelectedIndex = 0;

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

        private void EmployeeSalesReport_Load(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private bool CheckEmployee(Employee employee)
        {
            if (Employees_cb.SelectedIndex == 0 && Statuses_cb.SelectedIndex == 0)
                return true;
            else if (Employees_cb.SelectedIndex != 0 && Statuses_cb.SelectedIndex != 0)
            {
                if (employee.EmployeeID == (int)Employees_cb.SelectedValue && employee.status.StatusId == (int)Statuses_cb.SelectedValue)
                    return true;
                else
                    return false;
            }
            else if (Employees_cb.SelectedIndex != 0)
            {
                if (employee.EmployeeID == (int)Employees_cb.SelectedValue)
                    return true;
                else
                    return false;
            }
            else
            {
                if (employee.status.StatusId == (int)Statuses_cb.SelectedValue)
                    return true;
                else
                    return false;
            }
        }

        private void GenerateReport()
        {
            ReportData data = new ReportData();

            List<Employee> employees = new List<Employee>();

            foreach (Employee e in Employee.employees)
            {
                if (CheckEmployee(e))
                {
                    employees.Add(e);
                }
            }

            if (employees.Count > 0)
            {
                employees.Sort((v1, v2) => v2.Profit.CompareTo(v1.Profit));

                foreach (Employee employee in employees)
                {
                    var row = data.EmployeeSales.NewDataRow();
                    row["Name"] = employee.FullName;
                    row["Status"] = employee.status.StatusName;
                    row["Salary"] = employee.Salary;
                    row["Sales"] = employee.Sales;
                    row["Services"] = employee.ServiceProfit;
                    row["Total"] = employee.Profit;
                    row["SelectedEmployee"] = Employees_cb.Text;
                    row["SelectedStatus"] = Statuses_cb.Text;

                    data.EmployeeSales.Rows.Add(row);
                }

                var rds = new ReportDataSource("EmployeeSales_ds", data.EmployeeSales);

                EmployeeSales_rv.LocalReport.DataSources.Clear();
                EmployeeSales_rv.LocalReport.DataSources.Add(rds);

                EmployeeSales_rv.RefreshReport();
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
    }
}
