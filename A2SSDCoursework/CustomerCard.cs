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
    public partial class CustomerCard : UserControl
    {
        public Customer customer = new Customer();
        public CustomerCard()
        {
            InitializeComponent();
        }

        public CustomerCard(Customer customer, Color color)
        {
            InitializeComponent();

            this.customer = customer;

            BackColor = color;

            CustomerName_lbl.Text = $"{customer.FirstName} {customer.Surname}";
            VehiclesBought_lbl.Text = $"Vehicles Bought: {customer.BoughtVehicles.Count}";
            int moneySpent = 0;
            foreach(int ID in customer.BoughtVehicles)
            {
                moneySpent += Vehicle.GetSoldPrice(ID);
            }
            MoneySpent_lbl.Text = $"Spent: £{moneySpent}";
        }

        private void ViewCustomer_lbl_Click(object sender, EventArgs e)
        {
            MainMenu.MenuInstance.ChangeMainDisplay(new ViewCustomer(customer));
        }
    }
}
