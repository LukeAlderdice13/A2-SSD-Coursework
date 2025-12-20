using A2_SSD_Coursework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2SSDCoursework
{
    public partial class ViewCustomers : UserControl
    {
        public static ViewCustomers instance = new ViewCustomers();
        public ViewCustomers()
        {
            InitializeComponent();

            instance = this;

            PopulateCustomers();
        }

        public void PopulateCustomers()
        {
            Customers_pnl.Controls.Clear();

            int i = 0;
            int j = 0;
            int panelWidth = Customers_pnl.Width - 23;
            int panelHeight = 143;
            int panelSpacing = 5;
            int currentY = 5;

            Panel panel = null;

            foreach (Customer customer in Customer.customers)
            {
                if(CheckSearch(customer))
                {
                    if (i == 0)
                    {
                        panel = new Panel();
                        Customers_pnl.Controls.Add(panel);

                        panel.Size = new Size(panelWidth, panelHeight);
                        panel.Location = new Point(5, currentY);

                        currentY += panelHeight + panelSpacing;
                    }
                    Color color = new Color();

                    if (j % 2 == 0)
                    {
                        if (i % 2 == 0)
                        {
                            color = Color.DimGray;
                        }
                        else
                        {
                            color = Color.Gray;
                        }
                    }
                    else
                    {
                        if (i % 2 == 0)
                        {
                            color = Color.DimGray;
                        }
                        else
                        {
                            color = Color.Gray;
                        }
                    }

                    CustomerCard customerCard = new CustomerCard(customer, color);

                    customerCard.Dock = DockStyle.Left;
                    panel.Controls.Add(customerCard);

                    if (i == 2)
                    {
                        i = 0;
                        j++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            panel = new Panel();
            Customers_pnl.Controls.Add(panel);
            panel.Size = new Size(panelWidth, 5);
            panel.Location = new Point(5, currentY);
        }

        private void SearchIcon_pb_MouseEnter(object sender, EventArgs e)
        {
            SearchIcon_pb.Image = SearchIcon_il.Images[1];
        }

        private void SearchIcon_pb_MouseLeave(object sender, EventArgs e)
        {
            SearchIcon_pb.Image = SearchIcon_il.Images[0];
        }

        private bool CheckSearch(Customer customer)
        {
            if (!customer.FirstName.ToLower().Contains(Name_tbx.Text.ToLower()))
            {
                return false;
            }
            if (customer.BoughtVehicles.Count < CarsBought_nud.Value)
            {
                return false;
            }
            decimal moneySpent = 0;
            List<Vehicle> vehicles = Vehicle.GetVehiclesFromIDs(customer.BoughtVehicles);
            foreach(Vehicle vehicle in vehicles)
            {
                moneySpent += vehicle.SoldPrice;
            }

            if (moneySpent < MoneySpent_nud.Value)
            {
                return false;
            }
            return true;
        }

        private void SearchIcon_pb_Click(object sender, EventArgs e)
        {
            PopulateCustomers();
        }

        private void ResetSearch_lbl_MouseEnter(object sender, EventArgs e)
        {
            ResetSearch_lbl.ForeColor = Color.White;
        }

        private void ResetSearch_lbl_MouseLeave(object sender, EventArgs e)
        {
            ResetSearch_lbl.ForeColor = Color.Red;
        }

        private void ResetSearch_lbl_Click(object sender, EventArgs e)
        {
            Name_tbx.Text = "";
            CarsBought_nud.Value = 0;
            MoneySpent_nud.Value = 0;

            PopulateCustomers();
        }
    }
}
