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
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();

            PopulateListBoxes();
        }

        public void PopulateListBoxes()
        {
            PopulateOutOfStock();
            PopulateServices();
            PopulateRoles();
        }

        public void PopulateOutOfStock()
        {
            List<string> MakeNames = new List<string>();
            foreach (Vehicle v in Vehicle.vehicles)
            {
                if (!MakeNames.Contains(v.make.Name) && !v.Sold)
                {
                    MakeNames.Add(v.make.Name);
                }
            }

            Dictionary<int, string> data = new Dictionary<int, string>();

            foreach (Make make in Make.makes)
            {
                if (!MakeNames.Contains(make.Name))
                {
                    data.Add(make.MakeID, make.Name);
                }
            }

            if (data.Count == 0)
            {
                data.Add(-1, "None");
            }

            OutOfStock_lb.DataSource = data.ToArray();

            OutOfStock_lb.DisplayMember = "Value";
            OutOfStock_lb.ValueMember = "Key";
        }

        public void PopulateServices()
        {
            Dictionary<int, string> data = new Dictionary<int, string>();

            foreach (Vehicle v in Vehicle.vehicles)
            {
                if (v.ServiceHistory.Count > 0)
                {
                    Service s = v.ServiceHistory[v.ServiceHistory.Count - 1];

                    if (Math.Floor((DateTime.Now - s.ServiceDate).TotalDays) > 365)
                    {
                        data.Add(v.Id, $"{v.make.Name} {v.Model}");
                    }
                }
                else
                {
                    if (Math.Floor((DateTime.Now - v.DatePurchased).TotalDays) > 365)
                    {
                        data.Add(v.Id, $"{v.make.Name} {v.Model}");
                    }
                }
            }

            if (data.Count == 0)
            {
                data.Add(-1, "None");
            }

            Servicing_lb.DataSource = data.ToArray();

            Servicing_lb.DisplayMember = "Value";
            Servicing_lb.ValueMember = "Key";
        }

        public void PopulateRoles()
        {
            Dictionary<int, string> data = new Dictionary<int, string>();

            List<string> roleNames = new List<string>();
            foreach (Employee e in Employee.employees)
            {
                foreach (Role r in e.Roles)
                {
                    if (!roleNames.Contains(r.RoleName))
                    {
                        roleNames.Add(r.RoleName);
                    }
                }
            }

            foreach (Role r in Role.roles)
            {
                if (!roleNames.Contains(r.RoleName))
                {
                    data.Add(r.RoleID, r.RoleName);
                }
            }

            if (data.Count == 0)
            {
                data.Add(-1, "None");
            }

            Roles_lb.DataSource = data.ToArray();

            Roles_lb.DisplayMember = "Value";
            Roles_lb.ValueMember = "Key";
        }

        private void OutOfStock_lb_MouseClick(object sender, MouseEventArgs e)
        {
            if ((int)OutOfStock_lb.SelectedValue != -1)
            {
                MainMenu.MenuInstance.ChangeMainDisplay(new AddVehicle((int)OutOfStock_lb.SelectedValue));
            }
        }

        private void Servicing_lb_MouseClick(object sender, MouseEventArgs e)
        {
            if ((int)Servicing_lb.SelectedValue != -1)
            {
                MainMenu.MenuInstance.ChangeMainDisplay(new RecordService(Vehicle.GetVehicleFromID((int)Servicing_lb.SelectedValue)));
            }
        }

        private void Roles_lb_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void HomePage_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                PopulateListBoxes();
            }
        }

        private void HomePage_EnabledChanged(object sender, EventArgs e)
        {
            
        }
    }
}
