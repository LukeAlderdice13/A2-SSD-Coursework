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
    public partial class AddEmployee : UserControl
    {
        public AddEmployee()
        {
            InitializeComponent();

            foreach(Status status in Status.statuses)
            {
                Status_cb.Items.Add(status.StatusName);
            }
            Status_cb.SelectedIndex = 0;

            Roles_cb.Items.Add("No Current Roles");
            Roles_cb.SelectedIndex = 0;

            foreach (Role role in Role.roles)
            {
                AddRole_cb.Items.Add(role.RoleName);
            }
            AddRole_cb.SelectedIndex = 0;

            RemoveRole_cb.Items.Add("No Roles to Remove");
            RemoveRole_cb.SelectedIndex = 0;
        }
    }
}
