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
    public partial class MenuOptions : UserControl
    {
        private Color BaseColour = Color.Black;
        private Color HoverColour = Color.Cyan;
        public MenuOptions()
        {
            InitializeComponent();

            if (Employee.employees[Employee.currentEmployee].MaxAccessLevel != 3)
            {
                AddEmployee_lbl.Visible = false;
                ManageRoles_lbl.Visible = false;
                ManageStatuses_lbl.Visible = false;
            }
        }

        private void ViewVehicles_lbl_Click(object sender, EventArgs e)
        {
            if(Vehicles_pnl.Visible)
            {
                Vehicles_pnl.Visible = false;
            }
            else
            {
                Customers_pnl.Visible = false;
                Employees_pnl.Visible = false;
                Vehicles_pnl.Visible = true;
            }
        }

        private void PersonalInfo_lbl_MouseEnter(object sender, EventArgs e)
        {
            PersonalInfo_lbl.ForeColor = HoverColour;
        }

        private void PersonalInfo_lbl_MouseLeave(object sender, EventArgs e)
        {
            PersonalInfo_lbl.ForeColor = BaseColour;
        }

        private void ViewVehicles_lbl_MouseEnter(object sender, EventArgs e)
        {
            ViewVehicles_lbl.ForeColor = HoverColour;
        }

        private void ViewVehicles_lbl_MouseLeave(object sender, EventArgs e)
        {
            ViewVehicles_lbl.ForeColor = BaseColour;
        }

        private void AvailableVehicles_lbl_MouseEnter(object sender, EventArgs e)
        {
            AvailableVehicles_lbl.ForeColor = HoverColour;
        }

        private void AvailableVehicles_lbl_MouseLeave(object sender, EventArgs e)
        {
            AvailableVehicles_lbl.ForeColor = BaseColour;
        }

        private void SoldVehicles_lbl_MouseEnter(object sender, EventArgs e)
        {
            SoldVehicles_lbl.ForeColor = HoverColour;
        }

        private void SoldVehicles_lbl_MouseLeave(object sender, EventArgs e)
        {
            SoldVehicles_lbl.ForeColor = BaseColour;
        }

        private void VehicleMakes_lbl_MouseEnter(object sender, EventArgs e)
        {
            VehicleMakes_lbl.ForeColor = HoverColour;
        }

        private void VehicleMakes_lbl_MouseLeave(object sender, EventArgs e)
        {
            VehicleMakes_lbl.ForeColor = BaseColour;
        }

        private void SalesInfo_lbl_MouseEnter(object sender, EventArgs e)
        {
            SalesInfo_lbl.ForeColor = HoverColour;
        }

        private void SalesInfo_lbl_MouseLeave(object sender, EventArgs e)
        {
            SalesInfo_lbl.ForeColor = BaseColour;
        }

        private void Employees_lbl_Click(object sender, EventArgs e)
        {
            if (Employees_pnl.Visible)
            {
                Employees_pnl.Visible = false;
            }
            else
            {
                Customers_pnl.Visible = false;
                Vehicles_pnl.Visible = false;
                Employees_pnl.Visible = true;
            }
        }

        private void Employees_lbl_MouseEnter(object sender, EventArgs e)
        {
            Employees_lbl.ForeColor = HoverColour;
        }

        private void Employees_lbl_MouseLeave(object sender, EventArgs e)
        {
            Employees_lbl.ForeColor = BaseColour;
        }

        private void ViewEmployees_lbl_MouseEnter(object sender, EventArgs e)
        {
            ViewEmployees_lbl.ForeColor = HoverColour;
        }

        private void ViewEmployees_lbl_MouseLeave(object sender, EventArgs e)
        {
            ViewEmployees_lbl.ForeColor = BaseColour;
        }

        private void AddEmployee_lbl_MouseEnter(object sender, EventArgs e)
        {
            AddEmployee_lbl.ForeColor = HoverColour;
        }

        private void AddEmployee_lbl_MouseLeave(object sender, EventArgs e)
        {
            AddEmployee_lbl.ForeColor = BaseColour;
        }

        private void PersonalInfo_lbl_Click(object sender, EventArgs e)
        {
            HideSubMenus();
            MainMenu.MenuInstance.ClearHistory();
            MainMenu.MenuInstance.ChangeMainDisplay(new PersonalInfo(Employee.employees[Employee.currentEmployee]));
        }

        private void AvailableVehicles_lbl_Click(object sender, EventArgs e)
        {
            HideSubMenus();
            MainMenu.MenuInstance.ClearHistory();
            MainMenu.MenuInstance.ChangeMainDisplay(new AvailableVehicles());
        }

        private void SoldVehicles_lbl_Click(object sender, EventArgs e)
        {
            HideSubMenus();
            MainMenu.MenuInstance.ClearHistory();
            MainMenu.MenuInstance.ChangeMainDisplay(new SoldVehicles());

        }

        private void VehicleMakes_lbl_Click(object sender, EventArgs e)
        {
            HideSubMenus();
            MainMenu.MenuInstance.ClearHistory();
            MainMenu.MenuInstance.ChangeMainDisplay(new ViewMakes());

        }

        private void VehicleBrands_lbl_Click(object sender, EventArgs e)
        {
            HideSubMenus();
        }

        private void SalesInfo_lbl_Click(object sender, EventArgs e)
        {
            HideSubMenus();
            MainMenu.MenuInstance.ClearHistory();
            MainMenu.MenuInstance.ChangeMainDisplay(new SalesInfo());
        }

        private void ViewEmployees_lbl_Click(object sender, EventArgs e)
        {
            HideSubMenus();
            MainMenu.MenuInstance.ClearHistory();
            ViewEmployees viewEmployees = new ViewEmployees();
            MainMenu.MenuInstance.ChangeMainDisplay(viewEmployees);
        }

        private void AddEmployee_lbl_Click(object sender, EventArgs e)
        {
            HideSubMenus();
            MainMenu.MenuInstance.ClearHistory();
            MainMenu.MenuInstance.ChangeMainDisplay(new AddEmployee());
        }

        private void HideSubMenus()
        {
            Customers_pnl.Visible = false;
            Employees_pnl.Visible = false;
            Vehicles_pnl.Visible = false;
        }

        private void Customers_lbl_MouseEnter(object sender, EventArgs e)
        {
            Customers_lbl.ForeColor = HoverColour;
        }

        private void Customers_lbl_MouseLeave(object sender, EventArgs e)
        {
            Customers_lbl.ForeColor = BaseColour;
        }

        private void ViewCustomers_lbl_MouseEnter(object sender, EventArgs e)
        {
            ViewCustomers_lbl.ForeColor = HoverColour;
        }

        private void ViewCustomers_lbl_MouseLeave(object sender, EventArgs e)
        {
            ViewCustomers_lbl.ForeColor = BaseColour;
        }

        private void AddCustomer_lbl_MouseEnter(object sender, EventArgs e)
        {
            AddCustomer_lbl.ForeColor = HoverColour;
        }

        private void AddCustomer_lbl_MouseLeave(object sender, EventArgs e)
        {
            AddCustomer_lbl.ForeColor = BaseColour;
        }

        private void Customers_lbl_Click(object sender, EventArgs e)
        {
            if (Customers_pnl.Visible)
            {
                Customers_pnl.Visible = false;
            }
            else
            {
                Vehicles_pnl.Visible = false;
                Employees_pnl.Visible = false;
                Customers_pnl.Visible = true;
            }
        }

        private void ViewCustomers_lbl_Click(object sender, EventArgs e)
        {
            HideSubMenus();
            MainMenu.MenuInstance.ClearHistory();
            MainMenu.MenuInstance.ChangeMainDisplay(new ViewCustomers());
        }

        private void AddCustomer_lbl_Click(object sender, EventArgs e)
        {
            HideSubMenus();
            MainMenu.MenuInstance.ClearHistory();
            MainMenu.MenuInstance.ChangeMainDisplay(new AddCustomer());
        }

        private void LogOut_btn_MouseEnter(object sender, EventArgs e)
        {
            LogOut_btn.ForeColor = HoverColour;
        }

        private void LogOut_btn_MouseLeave(object sender, EventArgs e)
        {
            LogOut_btn.ForeColor = BaseColour;
        }

        private void LogOut_btn_Click(object sender, EventArgs e)
        {
            Login.instance.Show();
            MainMenu.MenuInstance.Close();         
        }

        private void AddVehicle_lbl_Click(object sender, EventArgs e)
        {
            HideSubMenus();
            MainMenu.MenuInstance.ClearHistory();
            MainMenu.MenuInstance.ChangeMainDisplay(new AddVehicle());
        }

        private void AddVehicle_lbl_MouseEnter(object sender, EventArgs e)
        {
            AddVehicle_lbl.ForeColor = HoverColour;
        }

        private void AddVehicle_lbl_MouseLeave(object sender, EventArgs e)
        {
            AddVehicle_lbl.ForeColor = BaseColour;
        }

        private void AddRole_lbl_MouseEnter(object sender, EventArgs e)
        {
            ManageRoles_lbl.ForeColor = HoverColour;
        }

        private void AddRole_lbl_MouseLeave(object sender, EventArgs e)
        {
            ManageRoles_lbl.ForeColor = BaseColour;
        }

        private void AddRole_lbl_Click(object sender, EventArgs e)
        {
            HideSubMenus();
            MainMenu.MenuInstance.ClearHistory();
            MainMenu.MenuInstance.ChangeMainDisplay(new ManageRoles());
        }

        private void ManageStatuses_lbl_MouseEnter(object sender, EventArgs e)
        {
            ManageStatuses_lbl.ForeColor = HoverColour;
        }

        private void ManageStatuses_lbl_MouseLeave(object sender, EventArgs e)
        {
            ManageStatuses_lbl.ForeColor = BaseColour;
        }

        private void ManageStatuses_lbl_Click(object sender, EventArgs e)
        {
            HideSubMenus();
            MainMenu.MenuInstance.ClearHistory();
            MainMenu.MenuInstance.ChangeMainDisplay(new ManageStatuses());
        }
    }
}
