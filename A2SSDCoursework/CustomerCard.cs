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
        private Color colour = new Color();
        public CustomerCard()
        {
            InitializeComponent();
        }

        public CustomerCard(Customer customer, Color colour)
        {
            InitializeComponent();

            this.customer = customer;

            BackColor = colour;
            this.colour = colour;

            CustomerName_lbl.Text = $"{customer.FirstName} {customer.Surname}";
            VehiclesBought_lbl.Text = $"Vehicles Bought: {customer.BoughtVehicles.Count}";
            int moneySpent = 0;
            foreach(int ID in customer.BoughtVehicles)
            {
                moneySpent += Vehicle.GetSoldPrice(ID);
            }
            MoneySpent_lbl.Text = $"Spent: £{moneySpent}";

            AddMouseEvents(this);
        }

        private void AddMouseEvents(Control parent)
        {
            parent.MouseEnter += CustomerCard_MouseEnter;
            parent.MouseLeave += CustomerCard_MouseLeave;

            foreach (Control c in parent.Controls)
            {
                AddMouseEvents(c);
            }
        }

        private void ViewCustomer_lbl_Click(object sender, EventArgs e)
        {
            MainMenu.MenuInstance.ChangeMainDisplay(new ViewCustomer(customer));
        }

        private void ViewCustomer_lbl_MouseEnter(object sender, EventArgs e)
        {
            ViewCustomer_lbl.ForeColor = Color.White;
        }

        private void ViewCustomer_lbl_MouseLeave(object sender, EventArgs e)
        {
            ViewCustomer_lbl.ForeColor = Color.Black;
        }

        private void CustomerCard_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void CustomerCard_MouseLeave(object sender, EventArgs e)
        {
            BackColor = colour;
        }
    }
}
