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

            if (customer.BoughtVehicles.Count > 0)
            {
                DeleteCustomer_btn.Visible = false;
            }

            if (Employee.employees[Employee.currentEmployee].MaxAccessLevel == 3)
            {
                FirstName_tbx.Text = customer.FirstName;
                Surname_tbx.Text = customer.Surname;
                Email_tbx.Text = customer.Email;
                Address_tbx.Text = customer.Address;
                TelephoneNo_tbx.Text = customer.TelephoneNo;
            }
            else
            {
                foreach(Control c in CustomerInfo_pnl.Controls)
                {
                    if(c is TextBox || c is Button)
                    {
                        c.Visible = false;
                    }
                }

                FirstName_lbl.Text = customer.FirstName;
                Surname_lbl.Text = customer.Surname;
                Email_lbl.Text = customer.Email;
                Address_lbl.Text = customer.Address;
                PhoneNo_lbl.Text = customer.TelephoneNo;

                VehiclesBought_lbl.Top = 100;
                VehiclesBoughtUnderline_pnl.Top = 153;
                BoughtVehicles_pnl.Top = 160;
            }

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

        private void UpdateButton_btn_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            if (FirstName_tbx.Text != customer.FirstName || Surname_tbx.Text != customer.Surname || Address_tbx.Text != customer.Address || Email_tbx.Text != customer.Email || TelephoneNo_tbx.Text != customer.TelephoneNo)
            {
                bool nullCheck = false;
                foreach(Control c in CustomerInfo_pnl.Controls)
                {
                    if (c is TextBox)
                    {
                        if(c.Text.Trim() == "")
                        {
                            nullCheck = true;
                            break;
                        }
                    }
                }
                if (nullCheck)
                {
                    MessageBox.Show("All fields must be completed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (Control c in CustomerInfo_pnl.Controls)
                    {
                        if (c is Label && c.ForeColor == Color.Green)
                        {
                            c.ForeColor = Color.Black;
                        }
                    }
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
        }

        private void CheckTextBoxes()
        {
            bool check = true;
            bool nullCheck = false;
            if (!Validation.Name(FirstName_tbx.Text.Trim()))
            {
                FirstNameTitle_lbl.ForeColor = Color.Firebrick;
                nullCheck = true;
            }
            else if (FirstName_tbx.Text.Trim() != customer.FirstName)
            {
                check = false;
                FirstNameTitle_lbl.ForeColor = Color.Green;
            }
            else
            {
                FirstNameTitle_lbl.ForeColor = Color.Black;
            }
            if (!Validation.Name(Surname_tbx.Text.Trim()))
            {
                SurnameTitle_lbl.ForeColor = Color.Firebrick;
                nullCheck = true;
            }
            else if (Surname_tbx.Text.Trim() != customer.Surname)
            {
                check = false;
                SurnameTitle_lbl.ForeColor = Color.Green;
            }
            else
            {
                SurnameTitle_lbl.ForeColor = Color.Black;
            }
            if (!Validation.Address(Address_tbx.Text.Trim()))
            {
                AddressTitle_lbl.ForeColor = Color.Firebrick;
                nullCheck = true;
            }
            else if (Address_tbx.Text.Trim() != customer.Address)
            {
                check = false;
                AddressTitle_lbl.ForeColor = Color.Green;
            } else
            {
                AddressTitle_lbl.ForeColor = Color.Black;
            }
            if (!Validation.Email(Email_tbx.Text.Trim()))
            {
                EmailTitle_lbl.ForeColor = Color.Firebrick;
                nullCheck = true;
            }
            else if (Email_tbx.Text.Trim() != customer.Email)
            {
                check = false;
                EmailTitle_lbl.ForeColor = Color.Green;
            }
            else
            {
                EmailTitle_lbl.ForeColor = Color.Black;
            }
            if (!Validation.PhoneNo(TelephoneNo_tbx.Text.Trim()))
            {
                TelephoneNoTitle_lbl.ForeColor = Color.Firebrick;
                nullCheck = true;
            }
            else if (TelephoneNo_tbx.Text.Trim() != customer.TelephoneNo)
            {
                check = false;
                TelephoneNoTitle_lbl.ForeColor = Color.Green;
            }
            else
            {
                TelephoneNoTitle_lbl.ForeColor = Color.Black;
            }

            if (!nullCheck)
            {
                if (check)
                {
                    UpdateButton_btn.BackColor = Color.SteelBlue;
                }
                else
                {
                    UpdateButton_btn.BackColor = Color.Green;
                }
            }
            else
            {
                UpdateButton_btn.BackColor = Color.Firebrick;
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

        private void FirstName_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Surname_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Email_tbx.Focus();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                UpdateInfo();
            }
        }

        private void Address_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Email_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                TelephoneNo_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                UpdateInfo();
            }
        }

        private void TelephoneNo_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Address_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Surname_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                UpdateInfo();
            }
        }

        private void Surname_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                TelephoneNo_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                FirstName_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                UpdateInfo();
            }
        }

        private void Email_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                FirstName_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Address_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                UpdateInfo();
            }
        }

        private void DeleteCustomer_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Confirm Deletion of {customer.FullName}'s account.", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Customer.DeleteCustomer(customer.CustomerID);
                ProjectDal.DeleteCustomer(customer.CustomerID);
                MessageBox.Show("Customer deleted", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViewCustomers.instance.PopulateCustomers();
                MainMenu.MenuInstance.ReturnToPreviousDisplay();
            }
        }
    }
}
