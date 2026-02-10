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
    public partial class ManageRoles : UserControl
    {
        public Role CurrentRole = new Role();
        public ManageRoles()
        {
            InitializeComponent();

            PopulateRoles();
        }

        public void PopulateRoles()
        {
            Dictionary<int, string> roles = new Dictionary<int, string>();
            foreach (Role role in Role.roles)
            {
                roles.Add(role.RoleID, role.RoleName);
            }

            Roles_lb.DataSource = roles.ToArray();

            Roles_lb.DisplayMember = "Value";
            Roles_lb.ValueMember = "Key";

            if (Roles_lb.Items.Count > 0)
            {
                Roles_lb.SelectedIndex = 0;
                UpdateInfo();
            }
            else
            {
                Info_pnl.Visible = false;
            }
        }

        private void Roles_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();   
        }

        private void UpdateInfo()
        {
            int ID = 0;
            if (int.TryParse(Roles_lb.SelectedValue.ToString(), out ID))
            {                
                List<int> employeeIDs = new List<int>();
                CurrentRole = Role.GetFromID(ID);
                EditName_tbx.Text = "";
                EditAccessLevel_nud.Value = CurrentRole.AccessLevel;
                SelectedRole_lbl.Text = CurrentRole.RoleName;
                decimal Profit = 0;
                int StaffCount = 0;
                decimal TotalSalary = 0;
                decimal MaxSalary = 0;
                decimal MinSalary = 0;

                foreach (Employee employee in Employee.employees)
                {
                    foreach (Role r in employee.Roles)
                    {
                        if (r.RoleID == ID)
                        {
                            employeeIDs.Add(employee.EmployeeID);
                            if (employee.Salary > MaxSalary)
                            {
                                MaxSalary = employee.Salary;
                            }
                            if (employee.Salary < MinSalary || MinSalary == 0)
                            {
                                MinSalary = employee.Salary;
                            }
                            StaffCount++;
                            TotalSalary += employee.Salary;
                            Profit += employee.Profit;
                            break;
                        }
                    }
                }

                AccessLevel_lbl.Text = CurrentRole.AccessLevel.ToString();
                Profit_lbl.Text = $"£{Profit}";
                StaffCount_lbl.Text = StaffCount.ToString();
                AverageSalary_lbl.Text = StaffCount == 0 ? "£0" : $"£{Math.Round(TotalSalary / StaffCount, 2)}";
                Highest_lbl.Text = $"£{MaxSalary}";
                Lowest_lbl.Text = $"£{MinSalary}";

                if (CurrentRole.AccessLevel == 3 && employeeIDs.Contains(Employee.employees[Employee.currentEmployee].EmployeeID))
                {
                    DeleteRole_btn.Visible = false;
                    DeleteUnderline_pnl.Visible = false;
                    DeleteRole_lbl.Visible = false;
                }
                else
                {
                    DeleteRole_btn.Visible = true;
                    DeleteUnderline_pnl.Visible = true;
                    DeleteRole_lbl.Visible = true;
                }

                EditAccessLevel_nud.Value = CurrentRole.AccessLevel;
            }
        }

        private void EditName_tbx_TextChanged(object sender, EventArgs e)
        {
            CheckEdit();
        }

        private void CheckEdit()
        {
            if (EditName_tbx.Text.Trim() == "" && (int)EditAccessLevel_nud.Value == CurrentRole.AccessLevel)
            {
                EditRole_btn.BackColor = Color.Firebrick;
            }
            else if (EditName_tbx.Text.Trim() != "")
            {
                if (CurrentRole.RoleName != EditName_tbx.Text.Trim())
                {
                    if (Role.IsNameTaken(EditName_tbx.Text.Trim()))
                    {
                        EditRole_btn.BackColor = Color.Firebrick;
                    }
                    else
                    {
                        EditRole_btn.BackColor = Color.SteelBlue;
                    }
                }
                else
                {
                    if ((int)EditAccessLevel_nud.Value == CurrentRole.AccessLevel)
                    {
                        EditRole_btn.BackColor = Color.Firebrick;
                    }
                    else
                    {
                        EditRole_btn.BackColor = Color.SteelBlue;
                    }                
                }
            }
            else
            {
                EditRole_btn.BackColor = Color.SteelBlue;
            }
        }

        private void NewName_tbx_TextChanged(object sender, EventArgs e)
        {
            if (NewName_tbx.Text.Trim() == "" || Role.IsNameTaken(NewName_tbx.Text.Trim()))
            {
                AddRole_btn.BackColor = Color.Firebrick;
            }
            else
            {
                AddRole_btn.BackColor = Color.SteelBlue;
            }
        }

        private void AddRole_btn_Click(object sender, EventArgs e)
        {
            if (NewName_tbx.Text.Trim() != "" && !Role.IsNameTaken(NewName_tbx.Text.Trim()))
            {
                Role role = new Role(Role.NextID(), NewName_tbx.Text, (int)AccessLevel_nud.Value);
                ProjectDal.AddRole(role);
                Role.roles.Add(role);
                MessageBox.Show("Role added", "Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.MenuInstance.ReloadDisplay(new ManageRoles());
            }
        }

        private void EditAccessLevel_nud_ValueChanged(object sender, EventArgs e)
        {
            CheckEdit();
        }

        private void EditRole_btn_Click(object sender, EventArgs e)
        {
            if (EditRole_btn.BackColor == Color.SteelBlue)
            {
                Role role = new Role(CurrentRole.RoleID, EditName_tbx.Text.Trim() == "" ? CurrentRole.RoleName : EditName_tbx.Text.Trim(), (int)EditAccessLevel_nud.Value);
                Role.EditRole(role);
                ProjectDal.EditRole(role);

                foreach(Employee employee in Employee.employees)
                {
                    foreach(Role r in employee.Roles)
                    {
                        if (r.RoleID == role.RoleID)
                        {
                            r.RoleName = role.RoleName;
                            break;
                        }
                    }
                }

                MessageBox.Show("Role edited", "Edit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.MenuInstance.ReloadDisplay(new ManageRoles());
            }
        }

        private void DeleteRole_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Confirm Deletion of '{CurrentRole.RoleName}' role.", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Role.RemoveRole(CurrentRole.RoleID);
                ProjectDal.DeleteRole(CurrentRole.RoleID);
                MessageBox.Show("Role deleted", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.MenuInstance.ReloadDisplay(new ManageRoles());
            } 
        }
    }
}
