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
    public partial class AddCustomer : UserControl
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void FirstName_tbx_TextChanged(object sender, EventArgs e)
        {
            if(!Validation.Name(FirstName_tbx.Text.Trim()))
            {
                FirstName_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                FirstName_lbl.ForeColor = Color.Black;
            }
            UpdateButtonColour();
        }

        private void Surname_tbx_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.Name(Surname_tbx.Text.Trim()))
            {
                Surname_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                Surname_lbl.ForeColor = Color.Black;
            }
            UpdateButtonColour();
        }

        private void TelephoneNo_tbx_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.PhoneNo(TelephoneNo_tbx.Text.Trim()))
            {
                TelephoneNo_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                TelephoneNo_lbl.ForeColor = Color.Black;
            }
            UpdateButtonColour();
        }

        private void Address_tbx_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.Address(Address_tbx.Text.Trim()))
            {
                Address_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                Address_lbl.ForeColor = Color.Black;
            }
            UpdateButtonColour();
        }

        private void Email_tbx_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.Email(Email_tbx.Text.Trim()))
            {
                Email_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                Email_lbl.ForeColor = Color.Black;
            }
            UpdateButtonColour();
        }

        private void FirstName_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                Surname_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Email_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                AddNewCustomer();
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
                AddNewCustomer();
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
                AddNewCustomer();
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
                AddNewCustomer();
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
                AddNewCustomer();
            }
        }

        private void UpdateButtonColour()
        {
            if (CheckInputs())
            {
                AddCustomer_btn.BackColor = Color.SteelBlue;
            }
            else
            {
                AddCustomer_btn.BackColor = Color.Firebrick;
            }
        }

        private bool CheckInputs()
        {
            if (!Validation.Name(FirstName_tbx.Text.Trim()))
                return false;
            if (!Validation.Name(Surname_tbx.Text.Trim()))
                return false;
            if (!Validation.PhoneNo(TelephoneNo_tbx.Text.Trim()))
                return false;
            if (!Validation.Address(Address_tbx.Text.Trim()))
                return false;
            if (!Validation.Email(Email_tbx.Text.Trim()))
                return false;
            return true;
        }

        private void AddNewCustomer()
        {
            if (!CheckInputs())
            {
                MessageBox.Show("All fields must be completed.", "Process Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Customer customer = new Customer(FirstName_tbx.Text.Trim(), Surname_tbx.Text.Trim(), Address_tbx.Text.Trim(), Email_tbx.Text.Trim(), TelephoneNo_tbx.Text.Trim());
                ProjectDal.AddCustomer(customer);
                MessageBox.Show("Customer Added", "Creation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MainMenu.History.Count == 1)
                {
                    MainMenu.MenuInstance.ReloadDisplay(new AddCustomer());
                }
                else
                {
                    MainMenu.MenuInstance.ReturnToPreviousDisplay();
                }
            }
        }

        private void AddCustomer_btn_Click(object sender, EventArgs e)
        {           
            AddNewCustomer();
        }
    }
}
