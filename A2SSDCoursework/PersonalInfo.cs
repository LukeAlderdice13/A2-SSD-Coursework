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
    public partial class PersonalInfo : UserControl
    {
        public Employee employee = new Employee();
        private List<int> AddedRoleIDs = new List<int>();
        private List<int> RemovedRoleIDs = new List<int>();

        Color ChangedInfo = Color.Green;
        public PersonalInfo()
        {
            InitializeComponent();
        }

        public PersonalInfo(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            PopulatePersonalInfo();
            if (employee.MaxAccessLevel == 3)
            {
                PopulateManagement();
            }
            else
            {
                PopulateNonManagement();
            }
        }

        private void PopulatePersonalInfo()
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
        }

        private void PopulateManagement()
        {
            Role_lbx.Visible = false;
            DateHired_lbl.Visible = false;
            Salary_lbl.Visible = false;
            Status_lbl.Visible = false;

            DateHired_dtp.Value = employee.DateHired;
            Salary_nud.Value = employee.Salary;

            foreach (Role role in Role.roles)
            {
                Roles_clb.Items.Add(role.RoleName);
                foreach (Role er in employee.Roles)
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

        public void PopulateNonManagement()
        {
            Roles_clb.Visible = false;
            DateHired_dtp.Visible = false;
            Salary_nud.Visible = false;
            Status_cb.Visible = false;

            DateHired_lbl.Text = employee.DateHired.ToString("dd/MM/yyyy");
            Salary_lbl.Text = employee.Salary.ToString();
            Status_lbl.Text = employee.status.StatusName;
            CarsSold_lbl.Text = $"{employee.SoldVehicles.Count}";
            Services_lbl.Text = employee.NumServices.ToString();
            Profit_lbl.Text = $"£{employee.Profit}";
            EmployeeID_lbl.Text = employee.EmployeeID.ToString();

            foreach (Role role in employee.Roles)
            {
                Role_lbx.Items.Add(role.RoleName);
            }
            if (employee.Roles.Count == 0)
            {
                Role_lbx.Items.Add("No Roles");
            }
        }

        private void UpdateButton_btn_Click(object sender, EventArgs e)
        {
            if (employee.MaxAccessLevel == 3)
            {
                if (CheckForNulls())
                {
                    MessageBox.Show("All fields must be completed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (UsernameCheck())
                {
                    MessageBox.Show("That username is already taken.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool RoleCheck = true;
                    if (RolesChanged())
                    {
                        List<Role> roles = new List<Role>();
                        foreach (var i in Roles_clb.CheckedItems)
                        {
                            Role r = Role.GetFromName(i.ToString());
                            roles.Add(r);
                        }
                        foreach (Role r in employee.Roles)
                        {
                            if (!Roles_clb.CheckedItems.Contains(r.RoleName))
                            {
                                RemovedRoleIDs.Add(r.RoleID);
                            }
                        }
                        int MaxAccessLevel = 0;
                        foreach (Role r in roles)
                        {
                            if (MaxAccessLevel < r.AccessLevel)
                            {
                                MaxAccessLevel = r.AccessLevel;
                            }
                            bool check = true;
                            foreach (Role er in employee.Roles)
                            {
                                if (er.RoleName == r.RoleName)
                                {
                                    check = false;
                                    break;
                                }
                            }
                            if (check)
                            {
                                AddedRoleIDs.Add(r.RoleID);
                            }
                        }

                        if (MaxAccessLevel != 3)
                        {
                            RoleCheck = false;
                        }
                        else
                        {
                            employee.Roles = roles;

                            ProjectDal.AddNewEmployeeRoles(employee.EmployeeID, AddedRoleIDs, RemovedRoleIDs);
                        }
                    }
                    if (RoleCheck)
                    {
                        if (FirstName_tbx.Text.Trim() != employee.FirstName || Surname_tbx.Text.Trim() != employee.Surname
                        || Address_tbx.Text.Trim() != employee.Address || DateOfBirth_dtp.Value != employee.DateOfBirth
                        || Email_tbx.Text.Trim() != employee.Email || TelephoneNo_tbx.Text.Trim() != employee.TelephoneNo
                        || Username_tbx.Text.Trim() != employee.Username || Password_tbx.Text.Trim() != employee.Password
                        || DateHired_dtp.Value != employee.DateHired || Salary_nud.Value != employee.Salary || RolesChanged())
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

                            foreach (Status status in Status.statuses)
                            {
                                if (status.StatusName == Status_cb.SelectedItem.ToString())
                                {
                                    employee.status = status;
                                    break;
                                }
                            }

                            ProjectDal.UpdateEmployeeInfo(employee);
                            
                            AddedRoleIDs.Clear();
                            RemovedRoleIDs.Clear();

                            ViewEmployees.Instance.PopulateEmployees();

                            MessageBox.Show("Employee Information Updated", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            foreach (Control c in Info_pnl.Controls)
                            {
                                if (c is Label)
                                {
                                    c.ForeColor = Color.Black;
                                }
                            }

                            UpdateButton_btn.BackColor = Color.SteelBlue;
                        }
                    }  
                    else
                    {
                        MessageBox.Show("You cannot remove all management level roles from your account.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);                      
                    }
                }
            }
            else
            {

            }

            AddedRoleIDs.Clear();
            RemovedRoleIDs.Clear();
        }

        private bool CheckForNulls()
        {
            foreach (Control c in Info_pnl.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text.Trim() == "")
                    {
                        return true;
                    }
                }
                else if (c is NumericUpDown)
                {
                    NumericUpDown n = (NumericUpDown)c;
                    if (n.Value == 0 || !n.Visible)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool UsernameCheck()
        {
            if (Employee.IsUsernameTaken(employee.EmployeeID, Username_tbx.Text.Trim()))
            {
                return true;
            }
            return false;
        }

        private bool RolesChanged()
        {
            if (Roles_clb.CheckedItems.Count == employee.Roles.Count)
            {
                foreach (Role role in employee.Roles)
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

        private void FirstName_tbx_TextChanged(object sender, EventArgs e)
        {
            if (FirstName_tbx.Text.Trim() == "")
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

        private void SetUpdateColour()
        {
            if (CheckForNulls() || UsernameCheck())
            {
                UpdateButton_btn.BackColor = Color.Firebrick;
            }
            else
            {
                UpdateButton_btn.BackColor = Color.SteelBlue;
                foreach (Control c in Info_pnl.Controls)
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

        private void Surname_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Surname_tbx.Text.Trim() == "")
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
            if (Address_tbx.Text.Trim() == "")
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

        private void Email_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Email_tbx.Text.Trim() == "")
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
            if (TelephoneNo_tbx.Text.Trim() == "")
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
            if (Username_tbx.Text.Trim() == "" || Employee.IsUsernameTaken(employee.EmployeeID, Username_tbx.Text))
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
            if (Password_tbx.Text.Trim() == "")
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

        private void SalesReport_Click(object sender, EventArgs e)
        {
            MainMenu.MenuInstance.ChangeMainDisplay(new IndividualSalesReport(employee));
        }
    }
}
