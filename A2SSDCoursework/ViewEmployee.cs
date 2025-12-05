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
    public partial class ViewEmployee : UserControl
    {
        public Employee employee = new Employee();
        List<int> AddedRoleIDs = new List<int>();
        List<int> RemovedRoleIDs = new List<int>();
        public ViewEmployee()
        {
            InitializeComponent();
        }

        public ViewEmployee(Employee employee)
        {
            InitializeComponent();

            FirstName_tbx.Text = employee.FirstName;
            Surname_tbx.Text = employee.Surname;
            Gender_tbx.Text = employee.Gender;
            Address_tbx.Text = employee.Address;
            DateOfBirth_dtp.Value = employee.DateOfBirth;
            Email_tbx.Text = employee.Email;
            TelephoneNo_tbx.Text = employee.TelephoneNo;
            Username_tbx.Text = employee.Username;
            Password_tbx.Text = employee.Password;
            DateHired_dtp.Value = employee.DateHired;
            Salary_tbx.Text = employee.Salary.ToString();

            foreach(Role role in employee.Roles)
            {
                Roles_cb.Items.Add(role.RoleName);
                RemoveRole_cb.Items.Add(role.RoleName);
            }
            if (employee.Roles.Count == 0)
            {
                Roles_cb.Items.Add("No roles");
                RemoveRole_cb.Items.Add("No roles to remove");
            }

            Roles_cb.SelectedIndex = 0;
            RemoveRole_cb.SelectedIndex = 0;

            foreach (Role role in Role.roles)
            {
                if (!Roles_cb.Items.Contains(role.RoleName))
                {
                    AddRole_cb.Items.Add(role.RoleName);
                }
            }

            if(AddRole_cb.Items.Count == 0)
            {
                AddRole_cb.Items.Add("No available roles");
            }
            AddRole_cb.SelectedIndex = 0;

            foreach (Status status in Status.statuses)
            {
                Status_cb.Items.Add(status.StatusName);
            }

            Status_cb.SelectedItem = employee.status.StatusName;

            this.employee = employee;
        }

        private void AddRole_btn_Click(object sender, EventArgs e)
        {
            if (AddRole_cb.SelectedItem.ToString() != "No available roles")
            {
                Role role = new Role();

                foreach(Role findRole in Role.roles)
                {
                    if (findRole.RoleName == AddRole_cb.SelectedItem.ToString())
                    {
                        role = findRole;
                        break;
                    }
                }

                AddRole_cb.Items.Remove(role.RoleName);
                if (AddRole_cb.Items.Count == 0)
                {
                    AddRole_cb.Items.Add("No available roles");
                }

                AddRole_cb.SelectedIndex = 0;

                employee.Roles.Add(role);
                if (Roles_cb.Items.Contains("No roles"))
                {
                    Roles_cb.Items.Clear();
                }
                Roles_cb.Items.Add(role.RoleName);
   
                if (RemoveRole_cb.Items.Contains("No roles to remove"))
                {
                    RemoveRole_cb.Items.Clear();
                }
                RemoveRole_cb.Items.Add(role.RoleName);

                if (RemovedRoleIDs.Contains(role.RoleID))
                {
                    RemovedRoleIDs.Remove(role.RoleID);
                } else
                {
                    AddedRoleIDs.Add(role.RoleID);
                }

                Roles_cb.SelectedIndex = 0;
                RemoveRole_cb.SelectedIndex = 0;
            }
        }

        private void RemoveRole_btn_Click(object sender, EventArgs e)
        {
            if (RemoveRole_cb.SelectedItem.ToString() != "No roles to remove")
            {
                Role role = new Role();

                foreach(Role findRole in employee.Roles)
                {
                    if (findRole.RoleName ==  RemoveRole_cb.SelectedItem.ToString())
                    {
                        role = findRole;
                        break;
                    }
                }
                AddRole_cb.Items.Add(role.RoleName);
                RemoveRole_cb.Items.Remove(role.RoleName);
                Roles_cb.Items.Remove(role.RoleName);

                employee.Roles.Remove(role);

                if (AddedRoleIDs.Contains(role.RoleID))
                {
                    AddedRoleIDs.Remove(role.RoleID);
                }
                else
                {
                    RemovedRoleIDs.Add(role.RoleID);
                }

                if (RemoveRole_cb.Items.Count == 0)
                {
                    RemoveRole_cb.Items.Add("No roles to remove");
                }
                if (Roles_cb.Items.Count == 0)
                {
                    Roles_cb.Items.Add("No roles");
                }

                if (AddRole_cb.Items.Contains("No available roles"))
                {
                    AddRole_cb.Items.Remove("No available roles");
                }
                AddRole_cb.SelectedIndex = 0;
                Roles_cb.SelectedIndex = 0;
                RemoveRole_cb.SelectedIndex = 0;
            }
        }

        private void UpdateButton_btn_Click(object sender, EventArgs e)
        {
            int index = employee.GetListIndex(employee.EmployeeID);
            Employee.employees[index].FirstName = FirstName_tbx.Text;
            Employee.employees[index].Surname = Surname_tbx.Text;
            Employee.employees[index].Gender = Gender_tbx.Text;
            Employee.employees[index].Address = Address_tbx.Text;
            Employee.employees[index].DateOfBirth = DateOfBirth_dtp.Value.Date;
            Employee.employees[index].Email = Email_tbx.Text;
            Employee.employees[index].TelephoneNo = TelephoneNo_tbx.Text;
            Employee.employees[index].Username = Username_tbx.Text;
            Employee.employees[index].Password = Password_tbx.Text;
            Employee.employees[index].DateHired = DateHired_dtp.Value.Date;
            Employee.employees[index].Salary = Convert.ToDecimal(Salary_tbx.Text);
            
            foreach(Status status in Status.statuses)
            {
                if (status.StatusName == Status_cb.SelectedItem.ToString())
                {
                    Employee.employees[index].status = status;
                    break;
                }
            }

            Employee.employees[index].Roles = employee.Roles;

            ProjectDal.UpdateEmployeeInfo(employee);
            ProjectDal.AddNewEmployeeRoles(employee.EmployeeID, AddedRoleIDs, RemovedRoleIDs);
            ProjectDal.GetEmployees();
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
    }
}
