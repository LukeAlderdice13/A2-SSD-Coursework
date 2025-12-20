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
    public partial class ViewCustomer : UserControl
    {
        Customer customer = new Customer();
        public ViewCustomer()
        {
            InitializeComponent();
        }

        public ViewCustomer(Customer customer)
        {
            InitializeComponent();

            this.customer = customer;

            FirstName_tbx.Text = customer.FirstName;
            Surname_tbx.Text = customer.Surname;
            Email_tbx.Text = customer.Email;
            Address_tbx.Text = customer.Address;
            TelephoneNo_tbx.Text = customer.TelephoneNo;

            PopulateVehicles();
        }

        private void PopulateVehicles()
        {
            List<Vehicle> vehicles = Vehicle.GetVehiclesFromIDs(customer.BoughtVehicles);

            int i = 0;
            int j = 0;
            int panelWidth = BoughtVehicles_pnl.Width - 23;
            int panelHeight = 253;
            int panelSpacing = 5;
            int currentY = 5;

            Panel panel = null;

            foreach (Vehicle vehicle in vehicles)
            {
                if (i == 0)
                {
                    panel = new Panel();
                    BoughtVehicles_pnl.Controls.Add(panel);

                    panel.Size = new Size(panelWidth, panelHeight);
                    panel.Location = new Point(5, currentY);

                    currentY += panelHeight + panelSpacing; // update Y for next panel
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

                VehicleCard vehicleCard = new VehicleCard(vehicle, color);

                vehicleCard.Dock = DockStyle.Left;
                panel.Controls.Add(vehicleCard);

                if (i == 3)
                {
                    i = 0;
                    j++;
                }
                else
                {
                    i++;
                }
            }

            if(vehicles.Count > 0)
            {
                panel = new Panel();
                BoughtVehicles_pnl.Controls.Add(panel);
                panel.Size = new Size(panelWidth, 5);
                panel.Location = new Point(5, currentY);
            }
            else
            {
                Label noVehicles = new Label();
                noVehicles.Text = "No Vehicles Bought";
                noVehicles.Size = new Size(BoughtVehicles_pnl.Width, 80);
                noVehicles.Font = new Font("Adobe Hebrew", 40);
                BoughtVehicles_pnl.Controls.Add(noVehicles);
                noVehicles.Location = new Point(0, 10);
                noVehicles.ForeColor = Color.Red;
                noVehicles.TextAlign = ContentAlignment.MiddleCenter;
            }
            
        }

        private void ReturnArrow_pb_MouseEnter(object sender, EventArgs e)
        {
            ReturnArrow_pb.Image = ReturnArrow_il.Images[1];
        }

        private void ReturnArrow_pb_MouseLeave(object sender, EventArgs e)
        {
            ReturnArrow_pb.Image = ReturnArrow_il.Images[0];
        }

        private void ReturnArrow_pb_Click(object sender, EventArgs e)
        {
            MainMenu.MenuInstance.ReturnToPreviousDisplay();
        }

        private void UpdateButton_btn_Click(object sender, EventArgs e)
        {
            if (FirstName_tbx.Text != customer.FirstName || Surname_tbx.Text != customer.Surname || Address_tbx.Text != customer.Address || Email_tbx.Text != customer.Email || TelephoneNo_tbx.Text != customer.TelephoneNo)
            {
                Customer.customers[Customer.GetCustomerIndex(customer)].FirstName = FirstName_tbx.Text;
                Customer.customers[Customer.GetCustomerIndex(customer)].Surname = Surname_tbx.Text;
                Customer.customers[Customer.GetCustomerIndex(customer)].Address = Address_tbx.Text;
                Customer.customers[Customer.GetCustomerIndex(customer)].Email = Email_tbx.Text;
                Customer.customers[Customer.GetCustomerIndex(customer)].TelephoneNo = TelephoneNo_tbx.Text;

                ProjectDal.UpdateCustomerInfo(Customer.customers[Customer.GetCustomerIndex(customer)]);
                ViewCustomers.instance.PopulateCustomers();
                UpdateButton_btn.BackColor = Color.SteelBlue;
            }
        }

        private void CheckTextBoxes()
        {
            if (FirstName_tbx.Text != customer.FirstName || Surname_tbx.Text != customer.Surname || Address_tbx.Text != customer.Address || Email_tbx.Text != customer.Email || TelephoneNo_tbx.Text != customer.TelephoneNo)
            {
                UpdateButton_btn.BackColor = Color.OrangeRed;
            }
            else
            {
                UpdateButton_btn.BackColor = Color.SteelBlue;
            }
            
        }

        private void FirstName_tbx_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void TelephoneNo_tbx_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void Address_tbx_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void Email_tbx_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void Surname_tbx_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }
    }
}
