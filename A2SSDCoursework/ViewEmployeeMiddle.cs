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
    public partial class ViewEmployeeMiddle : UserControl
    {
        Employee employee = new Employee();
        public ViewEmployeeMiddle()
        {
            InitializeComponent();
        }

        public ViewEmployeeMiddle(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            FirstName_lbl.Text = employee.FirstName;
            Surname_lbl.Text = employee.Surname;
            Gender_lbl.Text = employee.Gender;
            Email_lbl.Text = employee.Email;
            PhoneNo_lbl.Text = employee.TelephoneNo;
            DateHired_lbl.Text = employee.DateHired.ToString("dd/MM/yyyy");
            Salary_lbl.Text = employee.Salary.ToString();
            Status_lbl.Text = employee.status.StatusName;
            CarsSold_lbl.Text = $"{employee.SoldVehicles.Count}";
            Services_lbl.Text = employee.NumServices.ToString();
            Profit_lbl.Text = $"£{employee.Profit}";
            EmployeeID_lbl.Text = employee.EmployeeID.ToString();

            foreach(Role role in employee.Roles)
            {
                Role_lbx.Items.Add(role.RoleName);
            }
            if (employee.Roles.Count == 0)
            {
                Role_lbx.Items.Add("No Roles");
            }
        }

        private void SalesReport_btn_Click(object sender, EventArgs e)
        {
            MainMenu.MenuInstance.ChangeMainDisplay(new IndividualSalesReport(employee));
        }
    }
}
