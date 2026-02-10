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
    public partial class SellVehicle : UserControl
    {
        public Vehicle vehicle = new Vehicle();
        public int customerIndex = 0;
        public int storedCustomerIndex = 0;
        public int employeeIndex = 0;
        public int storedEmployeeIndex = 0;
        public SellVehicle()
        {
            InitializeComponent();
        }

        public SellVehicle(Vehicle vehicle)
        {
            InitializeComponent();

            this.vehicle = vehicle;

            DateTime currentDate = DateTime.Now;

            TimeSpan duration = currentDate - vehicle.DatePurchased;

            decimal years = Math.Floor((decimal)duration.TotalDays / 365);
            decimal PriceReduction = 1 - (years / 100);

            int minPrice = Convert.ToInt32(Math.Floor(vehicle.Price * PriceReduction));

            Price_nud.Value = vehicle.Price;
            Price_nud.Minimum = minPrice;

            PopulateCustomers();
            PopulateEmployees();
        }

        public void PopulateCustomers()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            foreach (Customer customer in Customer.customers)
            {
                myDictionary.Add(customer.CustomerID, $"{customer.FullName}");
            }
            Customers_cb.DataSource = myDictionary.ToArray();

            Customers_cb.DisplayMember = "Value";
            Customers_cb.ValueMember = "Key";

            if (storedCustomerIndex < Customers_cb.Items.Count)
            {
                Customers_cb.SelectedIndex = storedCustomerIndex;
            }
            else
            {
                Customers_cb.SelectedIndex = 0;
            }
        }

        private void PopulateEmployees()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            foreach (Employee employee in Employee.employees)
            {
                myDictionary.Add(employee.EmployeeID, $"{employee.FullName}. ID: {employee.EmployeeID}");
            }
            Employees_cb.DataSource = myDictionary.ToArray();

            Employees_cb.DisplayMember = "Value";
            Employees_cb.ValueMember = "Key";

            if (storedEmployeeIndex < Employees_cb.Items.Count)
            {
                Employees_cb.SelectedIndex = storedEmployeeIndex;
            }
            else
            {
                Employees_cb.SelectedIndex = 0;
            }
        }

        private void ViewCustomer_lbl_Click(object sender, EventArgs e)
        {
            storedCustomerIndex = customerIndex;
            Customer customer = Customer.GetCustomerFromID(Convert.ToInt32(Customers_cb.SelectedValue));
            MainMenu.MenuInstance.ChangeMainDisplay(new ViewCustomer(customer));
        }

        private void Customers_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerIndex = Convert.ToInt32(Customers_cb.SelectedIndex);
        }

        private void Customers_cb_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                PopulateCustomers();
                PopulateEmployees();
            }
        }

        private void ViewCustomer_lbl_MouseEnter(object sender, EventArgs e)
        {
            ViewCustomer_lbl.ForeColor = Color.Teal;
            ViewCustomer_lbl.Font = new Font("Microsoft Sans Serif", ViewCustomer_lbl.Font.Size, FontStyle.Underline);
        }

        private void ViewCustomer_lbl_MouseLeave(object sender, EventArgs e)
        {
            ViewCustomer_lbl.ForeColor = Color.Black;
            ViewCustomer_lbl.Font = new Font("Microsoft Sans Serif", ViewCustomer_lbl.Font.Size);
        }

        private void Employees_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeeIndex = Employees_cb.SelectedIndex;
        }

        private void ViewEmployee_lbl_Click(object sender, EventArgs e)
        {
            storedEmployeeIndex = employeeIndex;
            Employee employee = Employee.GetEmployeeFromID(Convert.ToInt32(Employees_cb.SelectedValue));
            if (Employee.employees[Employee.currentEmployee].MaxAccessLevel == 3)
            {
                ViewEmployee viewEmployee = new ViewEmployee(employee);
                MainMenu.MenuInstance.ChangeMainDisplay(viewEmployee);
            }
            else if (Employee.employees[Employee.currentEmployee].MaxAccessLevel == 2)
            {
                MainMenu.MenuInstance.ChangeMainDisplay(new ViewEmployeeMiddle(employee));
            }
            else
            {
                MainMenu.MenuInstance.ChangeMainDisplay(new ViewEmployeePublicInfo(employee));
            }
        }

        private void ViewEmployee_lbl_MouseEnter(object sender, EventArgs e)
        {
            ViewEmployee_lbl.ForeColor = Color.Teal;
            ViewEmployee_lbl.Font = new Font("Microsoft Sans Serif", ViewEmployee_lbl.Font.Size, FontStyle.Underline);
        }

        private void ViewEmployee_lbl_MouseLeave(object sender, EventArgs e)
        {
            ViewEmployee_lbl.ForeColor = Color.Black;
            ViewEmployee_lbl.Font = new Font("Microsoft Sans Serif", ViewEmployee_lbl.Font.Size);
        }

        private void Sell_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Can you confirm you wish to sell the {vehicle.make.Name} {vehicle.Model} at a price of £{Price_nud.Value}?", "Confirm Sale",MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==  DialogResult.Yes)
            {
                vehicle.EmployeeID = Convert.ToInt32(Employees_cb.SelectedValue);
                vehicle.CustomerID = Convert.ToInt32(Customers_cb.SelectedValue);
                vehicle.SoldPrice = Convert.ToDecimal(Price_nud.Value);
                vehicle.DateSold = Date_dtp.Value;
                vehicle.Sold = true;

                ProjectDal.SellVehicle(vehicle);
                Customer.AddBoughtVehicle(Convert.ToInt32(Customers_cb.SelectedValue), vehicle.Id);
                Employee.AddSoldVehicle(Convert.ToInt32(Employees_cb.SelectedValue), vehicle);
                MessageBox.Show("Vehicle Sold", "Sale Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.MenuInstance.ReturnToPreviousDisplay();
                MainMenu.MenuInstance.ReloadDisplay(new ViewVehicle(vehicle));
            }
        }

        private void AddNewCustomer_lbl_MouseEnter(object sender, EventArgs e)
        {
            AddNewCustomer_lbl.ForeColor = Color.Teal;
            AddNewCustomer_lbl.Font = new Font("Microsoft Sans Serif", ViewEmployee_lbl.Font.Size, FontStyle.Underline);
        }

        private void AddNewCustomer_lbl_MouseLeave(object sender, EventArgs e)
        {
            AddNewCustomer_lbl.ForeColor = Color.Black;
            AddNewCustomer_lbl.Font = new Font("Microsoft Sans Serif", ViewEmployee_lbl.Font.Size);
        }

        private void AddNewCustomer_lbl_Click(object sender, EventArgs e)
        {
            storedCustomerIndex = customerIndex;
            MainMenu.MenuInstance.ChangeMainDisplay(new AddCustomer());
        }

        private void Price_nud_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SellVehicle_Load(object sender, EventArgs e)
        {
            
        }
    }
}
