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
    public partial class ViewEmployeePublicInfo : UserControl
    {
        public Employee employee = new Employee();

        public ViewEmployeePublicInfo()
        {
            InitializeComponent();
        }

        public ViewEmployeePublicInfo(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            PopulatePublicPnl();
        }

        private void PopulatePublicPnl()
        {
            FirstName_lbl.Text = employee.FirstName;
            Surname_lbl.Text = employee.Surname;
            Gender_lbl.Text = employee.Gender;
            Email_lbl.Text = employee.Email;
            PhoneNo_lbl.Text = employee.TelephoneNo;
            Status_lbl.Text = employee.status.StatusName;
            EmployeeID_lbl.Text = employee.EmployeeID.ToString();
            CarsSold_lbl.Text = $"{employee.SoldVehicles.Count}";
            Services_lbl.Text = employee.NumServices.ToString();

            foreach (Role role in employee.Roles)
            {
                Role_lbx.Items.Add(role.RoleName);
            }
            if (employee.Roles.Count == 0)
            {
                Role_lbx.Items.Add("No Roles");
            }
        }
    }
}
