using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace A2SSDCoursework
{
    public partial class ViewEmployee : UserControl
    {
        public Employee employee = new Employee(); 
        private List<int> AddedRoleIDs = new List<int>();
        private List<int> RemovedRoleIDs = new List<int>();

        Color ChangedInfo = Color.Green;
        public ViewEmployee()
        {
            InitializeComponent();
        }

        public ViewEmployee(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            if (employee.SoldVehicles.Count == 0 && employee.NumServices == 0)
            {
                DeleteEmployee_btn.Visible = true;
            }

            PopulateManagementPnl();          
        }

        private void PopulateManagementPnl()
        {
            FirstName_tbx.Text = employee.FirstName;
            Surname_tbx.Text = employee.Surname;
            Gender_lbl.Text = employee.Gender;
            Address_tbx.Text = employee.Address;
            DateOfBirth_dtp.Value = employee.DateOfBirth;
            Email_tbx.Text = employee.Email;
            TelephoneNo_tbx.Text = employee.TelephoneNo;
            Username_tbx.Text = employee.Username;
            Password_tbx.Text = employee.Password;
            DateHired_dtp.Value = employee.DateHired;
            Salary_nud.Value = employee.Salary;

            foreach(Role role in Role.roles)
            {
                Roles_clb.Items.Add(role.RoleName);
                foreach(Role er in employee.Roles)
                {
                    if (role.RoleID == er.RoleID)
                    {
                        Roles_clb.SetItemChecked(Roles_clb.Items.Count - 1, true);
                        break;
                    }
                }
            }

            foreach (Status status in Status.statuses)
            {
                Status_cb.Items.Add(status.StatusName);
            }

            Status_cb.SelectedItem = employee.status.StatusName;
            CarsSold_lbl.Text = $"{employee.SoldVehicles.Count}";
            Services_lbl.Text = employee.NumServices.ToString();
            Profit_lbl.Text = $"£{employee.Profit}";
            EmployeeID_lbl.Text = $"{employee.EmployeeID}";
        }      

        private void UpdateButton_btn_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            if (CheckInputs())
            {
                MessageBox.Show("All fields must be completed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Validation.Username(employee.EmployeeID, Username_tbx.Text.Trim()))
            {
                MessageBox.Show("That username is already taken.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (FirstName_tbx.Text.Trim() != employee.FirstName || Surname_tbx.Text.Trim() != employee.Surname
                    || Address_tbx.Text.Trim() != employee.Address || DateOfBirth_dtp.Value != employee.DateOfBirth
                    || Email_tbx.Text.Trim() != employee.Email || TelephoneNo_tbx.Text.Trim() != employee.TelephoneNo
                    || Username_tbx.Text.Trim() != employee.Username || Password_tbx.Text.Trim() != employee.Password
                    || DateHired_dtp.Value != employee.DateHired || Status_cb.SelectedItem.ToString() != employee.status.StatusName || Salary_nud.Value != employee.Salary || RolesChanged())
                {
                    employee.FirstName = FirstName_tbx.Text.Trim();
                    employee.Surname = Surname_tbx.Text.Trim();
                    employee.Address = Address_tbx.Text.Trim();
                    employee.DateOfBirth = DateOfBirth_dtp.Value.Date;
                    employee.Email = Email_tbx.Text.Trim();
                    employee.TelephoneNo = TelephoneNo_tbx.Text.Trim();
                    employee.Username = Username_tbx.Text.Trim();
                    employee.Password = Password_tbx.Text.Trim();
                    employee.DateHired = DateHired_dtp.Value.Date;
                    employee.Salary = Convert.ToDecimal(Salary_nud.Value);

                    if(RolesChanged())
                    {                    
                        List<Role> roles = new List<Role>();
                        foreach(var i in Roles_clb.CheckedItems)
                        {
                            Role r = Role.GetFromName(i.ToString());
                            roles.Add(r);
                        }
                        foreach(Role r in employee.Roles)
                        {
                            if (!Roles_clb.CheckedItems.Contains(r.RoleName))
                            {
                                RemovedRoleIDs.Add(r.RoleID);
                            }
                        }
                        foreach(Role r in roles)
                        {
                            bool check = true;
                            foreach(Role er in employee.Roles)
                            {
                                if (er.RoleName == r.RoleName)
                                {
                                    check = false;
                                    break;
                                }
                            }
                            if(check)
                            {
                                AddedRoleIDs.Add(r.RoleID);
                            }
                        }
                        employee.Roles = roles;
                    }

                    foreach (Status status in Status.statuses)
                    {
                        if (status.StatusName == Status_cb.SelectedItem.ToString())
                        {
                            employee.status = status;
                            break;
                        }
                    }

                    ProjectDal.UpdateEmployeeInfo(employee);
                    ProjectDal.AddNewEmployeeRoles(employee.EmployeeID, AddedRoleIDs, RemovedRoleIDs);
                    AddedRoleIDs.Clear();
                    RemovedRoleIDs.Clear();

                    ViewEmployees.Instance.PopulateEmployees();

                    MessageBox.Show("Employee Information Updated", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (Control c in Employee_pnl.Controls)
                    {
                        if (c is Label)
                        {
                            c.ForeColor = Color.Black;
                        }
                    }

                    UpdateButton_btn.BackColor = Color.SteelBlue;
                }
            }
        }

        private void Surname_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Address_tbx.Focus();
                Address_tbx.SelectionStart = Address_tbx.Text.Length;
            }
            else if (e.KeyCode == Keys.Up)
            {
                FirstName_tbx.Focus();
                FirstName_tbx.SelectionStart = FirstName_tbx.Text.Length;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                UpdateInfo();
            }
        }

        private void Address_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Email_tbx.Focus();
                Email_tbx.SelectionStart = Email_tbx.Text.Length;
            }
            else if (e.KeyCode == Keys.Up)
            {
                Surname_tbx.Focus();
                Surname_tbx.SelectionStart = Surname_tbx.Text.Length;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                UpdateInfo();
            }
        }

        private void DateOfBirth_dtp_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Email_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                TelephoneNo_tbx.Focus();
                TelephoneNo_tbx.SelectionStart = TelephoneNo_tbx.Text.Length;
            }
            else if (e.KeyCode == Keys.Up)
            {
                Address_tbx.Focus();
                Address_tbx.SelectionStart = Address_tbx.Text.Length;
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
                Username_tbx.Focus();
                Username_tbx.SelectionStart = Username_tbx.Text.Length;
            }
            else if (e.KeyCode == Keys.Up)
            {
                Email_tbx.Focus();
                Email_tbx.SelectionStart = Email_tbx.Text.Length;
            }
        }

        private void Username_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Password_tbx.Focus();
                Password_tbx.SelectionStart = Password_tbx.Text.Length;
            }
            else if (e.KeyCode == Keys.Up)
            {
                TelephoneNo_tbx.Focus();
                TelephoneNo_tbx.SelectionStart = TelephoneNo_tbx.Text.Length;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                UpdateInfo();
            }
        }

        private void Password_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                FirstName_tbx.Focus();
                FirstName_tbx.SelectionStart = FirstName_tbx.Text.Length;
            }
            else if (e.KeyCode == Keys.Up)
            {
                Username_tbx.Focus();
                Username_tbx.SelectionStart = Username_tbx.Text.Length;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                UpdateInfo();
            }
        }

        private void Surname_tbx_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.Name(Surname_tbx.Text.Trim()))
            {
                Surname_lbl.ForeColor = Color.Firebrick;
            }
            else if (employee.Surname != Surname_tbx.Text.Trim())
            {
                Surname_lbl.ForeColor = ChangedInfo;
            }
            else
            {
                Surname_lbl.ForeColor = Color.Black;
            }
            SetUpdateColour();
        }

        private void Address_tbx_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.Address(Address_tbx.Text.Trim()))
            {
                Address_lbl.ForeColor = Color.Firebrick;
            }
            else if (employee.Address != Address_tbx.Text.Trim())
            {
                Address_lbl.ForeColor = ChangedInfo;
            }
            else
            {
                Address_lbl.ForeColor = Color.Black;
            }
            SetUpdateColour();
        }

        private void DateOfBirth_dtp_ValueChanged(object sender, EventArgs e)
        {
            if (employee.DateOfBirth != DateOfBirth_dtp.Value)
            {
                DateOfBirth_lbl.ForeColor = ChangedInfo;
            }
            else
            {
                DateOfBirth_lbl.ForeColor = Color.Black;
            }
            SetUpdateColour();
        }

        private void Email_tbx_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.Email(Email_tbx.Text.Trim()))
            {
                Email_lbl.ForeColor = Color.Firebrick;
            }
            else if (employee.Email != Email_tbx.Text.Trim())
            {
                Email_lbl.ForeColor = ChangedInfo;
            }
            else
            {
                Email_lbl.ForeColor = Color.Black;
            }
            SetUpdateColour();
        }

        private void TelephoneNo_tbx_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.PhoneNo(TelephoneNo_tbx.Text.Trim()))
            {
                TelephoneNo_lbl.ForeColor = Color.Firebrick;
            }
            else if (employee.TelephoneNo != TelephoneNo_tbx.Text.Trim())
            {
                TelephoneNo_lbl.ForeColor = ChangedInfo;
            }
            else
            {
                TelephoneNo_lbl.ForeColor = Color.Black;
            }
            SetUpdateColour();
        }

        private void Username_tbx_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.Username(employee.EmployeeID, Username_tbx.Text.Trim()))
            {
                Username_lbl.ForeColor = Color.Firebrick;
            }
            else if (employee.Username != Username_tbx.Text.Trim())
            {
                Username_lbl.ForeColor = ChangedInfo;
            }
            else
            {
                Username_lbl.ForeColor = Color.Black;
            }
            SetUpdateColour();
        }

        private void Password_tbx_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.Password(Password_tbx.Text.Trim()))
            {
                Password_lbl.ForeColor = Color.Firebrick;
            }
            else if (employee.Password != Password_tbx.Text.Trim())
            {
                Password_lbl.ForeColor = ChangedInfo;
            }
            else
            {
                Password_lbl.ForeColor = Color.Black;
            }
            SetUpdateColour();
        }

        private void DateHired_dtp_ValueChanged(object sender, EventArgs e)
        {
            if (employee.DateHired != DateHired_dtp.Value)
            {
                DateHired_lbl.ForeColor = ChangedInfo;
            }
            else
            {
                DateHired_lbl.ForeColor = Color.Black;
            }
            SetUpdateColour();
        }

        private void Salary_nud_ValueChanged(object sender, EventArgs e)
        {
            if (Salary_nud.Value == 0)
            {
                Salary_lbl.ForeColor = Color.Firebrick;
            }
            else if (employee.Salary != Salary_nud.Value)
            {
                Salary_lbl.ForeColor = ChangedInfo;
            }
            else
            {
                Salary_lbl.ForeColor = Color.Black;
            }
            SetUpdateColour();
        }

        private void Status_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Status_cb.SelectedItem != null)
            {
                if (employee.status.StatusName != Status_cb.SelectedItem.ToString())
                {
                    Status_lbl.ForeColor = ChangedInfo;
                }
                else
                {
                    Status_lbl.ForeColor = Color.Black;
                }
            }
            SetUpdateColour();
        }

        private void SetUpdateColour()
        {
            if(!CheckInputs())
            {
                UpdateButton_btn.BackColor = Color.Firebrick;
            }
            else
            {
                UpdateButton_btn.BackColor = Color.SteelBlue;
                foreach (Control c in Employee_pnl.Controls)
                {
                    if (c is Label && c.Tag != null)
                    {
                        if (c.ForeColor == ChangedInfo)
                        {
                            UpdateButton_btn.BackColor = ChangedInfo;
                        }
                    }
                }
            }
        }

        private bool CheckInputs()
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
            if (!Validation.Username(employee.EmployeeID, Username_tbx.Text.Trim()))
                return false;
            if (!Validation.Password(Password_tbx.Text.Trim()))
                return false;
            return true;
        }

        private void Salary_nud_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void SalesReport_Click(object sender, EventArgs e)
        {
            MainMenu.MenuInstance.ChangeMainDisplay(new IndividualSalesReport(employee));
        }

        private void Roles_clb_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void Roles_clb_Click(object sender, EventArgs e)
        {

        }

        private void Roles_clb_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private bool RolesChanged()
        {
            if (Roles_clb.CheckedItems.Count == employee.Roles.Count)
            {
                foreach(Role role in employee.Roles)
                {
                    if (!Roles_clb.CheckedItems.Contains(role.RoleName))
                    {
                        return true;
                    }
                }
                return false;
            }
            return true;
        }

        private void FirstName_tbx_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Password_tbx.Focus();
                Password_tbx.SelectionStart = FirstName_tbx.Text.Length;
            }
            else if (e.KeyCode == Keys.Up)
            {
                Surname_tbx.Focus();
                Surname_tbx.SelectionStart = Username_tbx.Text.Length;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                UpdateInfo();
            }
        }

        private void FirstName_tbx_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.Name(FirstName_tbx.Text.Trim()))
            {
                FirstName_lbl.ForeColor = Color.Firebrick;
            }
            else if (employee.FirstName != FirstName_tbx.Text.Trim())
            {
                FirstName_lbl.ForeColor = ChangedInfo;
            }
            else
            {
                FirstName_lbl.ForeColor = Color.Black;
            }
            SetUpdateColour();
        }

        private void DeleteEmployee_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Confirm Deletion of {employee.FullName}'s account.", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Employee.DeleteEmployee(employee.EmployeeID);
                ProjectDal.DeleteEmployee(employee.EmployeeID);
                MessageBox.Show("Employee deleted", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViewEmployees.Instance.PopulateEmployees();
                MainMenu.MenuInstance.ReturnToPreviousDisplay();
            }
        }

        private void CarsSold_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
