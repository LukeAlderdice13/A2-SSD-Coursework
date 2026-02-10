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
    public partial class AddEmployee : UserControl
    {
        private string NoAddRoles = "No Roles Available";
        private string NoRemoveRoles = "No Roles to Remove";
        private string NoCurrentRoles = "No Current Roles";
        public AddEmployee()
        {
            InitializeComponent();

            Gender_cb.SelectedIndex = 0;
            foreach(Status status in Status.statuses)
            {
                Status_cb.Items.Add(status.StatusName);
            }
            Status_cb.SelectedIndex = 0;

            foreach (Role role in Role.roles)
            {
                Roles_clb.Items.Add(role.RoleName);
            }

        }

        private bool CheckTextBoxes()
        {
            if (!Validation.Name(FirstName_tbx.Text.Trim()))
                return false;
            if (!Validation.Name(Surname_tbx.Text.Trim()))
                return false;
            if (!Validation.Address(Address_tbx.Text.Trim()))
                return false;
            if (!Validation.Email(Email_tbx.Text.Trim()))
                return false;
            if (!Validation.PhoneNo(TelephoneNo_tbx.Text.Trim()))
                return false;
            if (!Validation.Username(Username_tbx.Text.Trim()))
                return false;
            if (!Validation.Password(Password_tbx.Text.Trim()))
                return false;
            if (Salary_nud.Value == 0)
                return false;
            return true;
        }

        private void UpdateAddColour()
        {
            if (CheckTextBoxes())
            {
                AddEmployee_btn.BackColor = Color.SteelBlue;
            }
            else
            {
                AddEmployee_btn.BackColor = Color.Firebrick;
            }
        }

        private void TextChangedEvent(object sender, EventArgs e)
        {
            AddEmployee_btn.BackColor = CheckTextBoxes() ? Color.SteelBlue : Color.Firebrick;
        }

        private void Salary_nud_ValueChanged(object sender, EventArgs e)
        {
            AddEmployee_btn.BackColor = CheckTextBoxes() ? Color.SteelBlue : Color.Firebrick;
        }

        private void FirstName_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                Surname_tbx.Focus();
            }
        }

        private void Surname_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                Address_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                FirstName_tbx.Focus();
            }
        }

        private void Address_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                DateOfBirth_dtp.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Surname_tbx.Focus();
            }
        }

        private void DateOfBirth_dtp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Email_tbx.Focus();
            }
        }

        private void Email_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                TelephoneNo_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                DateOfBirth_dtp.Focus();
            }
        }


        private void TelephoneNo_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                Username_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Email_tbx.Focus();
            }
        }

        private void Username_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                Password_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                TelephoneNo_tbx.Focus();
            }
        }

        private void Password_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                DateHired_dtp.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Username_tbx.Focus();
            }
        }

        private void DateHired_dtp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Salary_nud.Focus();
            }
        }

        private void Salary_nud_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FirstName_tbx_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.Name(FirstName_tbx.Text.Trim()))
            {
                FirstName_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                FirstName_lbl.ForeColor = Color.Black;
            }
            UpdateAddColour();
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
            UpdateAddColour();
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
            UpdateAddColour();
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
            UpdateAddColour();
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
            UpdateAddColour();
        }

        private void Username_tbx_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.Username(Username_tbx.Text.Trim()))
            {
                Username_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                Username_lbl.ForeColor = Color.Black;
            }
            UpdateAddColour();
        }

        private void Password_tbx_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.Password(Password_tbx.Text.Trim()))
            {
                Password_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                Password_lbl.ForeColor = Color.Black;
            }
            UpdateAddColour();
        }

        private void Salary_nud_ValueChanged_1(object sender, EventArgs e)
        {
            if (Salary_nud.Value == 0)
            {
                Salary_lbl.ForeColor = Color.Firebrick;
            }
            else
            {
                Salary_lbl.ForeColor = Color.Black;
            }
            UpdateAddColour();
        }

        private void AddEmployee_btn_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                List<Role> roles = new List<Role>();
                foreach (var item in Roles_clb.CheckedItems)
                {
                    roles.Add(Role.GetFromName(item.ToString()));
                }
                Status status = Status.GetFromName(Status_cb.SelectedItem.ToString());
                Employee emp = new Employee(FirstName_tbx.Text.Trim(), Surname_tbx.Text.Trim(), Gender_cb.SelectedItem.ToString(), Address_tbx.Text.Trim(), DateOfBirth_dtp.Value, Email_tbx.Text.Trim(), TelephoneNo_tbx.Text.Trim(), Username_tbx.Text.Trim(), Password_tbx.Text.Trim(), DateHired_dtp.Value, Salary_nud.Value, status, roles);
                ProjectDal.AddEmployee(emp);
                MessageBox.Show("New Employee Added", "Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.MenuInstance.ReloadDisplay(new AddEmployee());
            }
        }
    }
}
