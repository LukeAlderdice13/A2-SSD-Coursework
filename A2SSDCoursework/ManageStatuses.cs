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
    public partial class ManageStatuses : UserControl
    {
        Status CurrentStatus = new Status();
        int StatusValue = 0;
        public ManageStatuses()
        {
            InitializeComponent();

            PopulateStatuses();
        }

        private void PopulateStatuses()
        {
            Dictionary<int, string> data = new Dictionary<int, string>();
            foreach(Status status in Status.statuses)
            {
                data.Add(status.StatusId, status.StatusName);
            }
            Statuses_lb.DataSource = data.ToArray();

            Statuses_lb.DisplayMember = "Value";
            Statuses_lb.ValueMember = "Key";

            if (Statuses_lb.Items.Count > 0 )
            {
                Statuses_lb.SelectedIndex = StatusValue;
                UpdateInfo();
            }
            else
            {
                Info_pnl.Visible = false;
            }
        }

        private void UpdateInfo()
        {
            int ID = 0;
            if (int.TryParse(Statuses_lb.SelectedValue.ToString(), out ID))
            {
                List<Employee> employees = new List<Employee>();
                CurrentStatus = Status.GetFromID(ID);
                EditName_tbx.Text = "";
                SelectedStatus_lbl.Text = CurrentStatus.StatusName;

                foreach (Employee employee in Employee.employees)
                {
                    if(employee.status.StatusId == CurrentStatus.StatusId)
                    {
                        employees.Add(employee);
                    }
                }

                StaffCount_lbl.Text = employees.Count.ToString();

                if (employees.Count > 0)
                {
                    DeleteStatus_btn.Visible = false;
                    DeleteUnderline_pnl.Visible = false;
                    DeleteStatus_lbl.Visible = false;

                    Dictionary<int, string> data = new Dictionary<int, string>();
                    foreach (Employee employee in employees)
                    {
                        data.Add(employee.EmployeeID, employee.FullName);
                    }
                    Employees_lb.DataSource = data.ToArray();

                    Employees_lb.DisplayMember = "Value";
                    Employees_lb.ValueMember = "Key";
                }
                else
                {
                    DeleteStatus_btn.Visible = true;
                    DeleteUnderline_pnl.Visible = true;
                    DeleteStatus_lbl.Visible = true;

                    Dictionary<int, string> data = new Dictionary<int, string>();
                    data.Add(-1, "No Employees");
                    Employees_lb.DataSource = data.ToArray();

                    Employees_lb.DisplayMember = "Value";
                    Employees_lb.ValueMember = "Key";
                }
            }
        }

        private void Statuses_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void Employees_lb_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Employees_lb.SelectedValue) != -1)
            {
                StatusValue = Convert.ToInt32(Statuses_lb.SelectedIndex);
                MainMenu.MenuInstance.ChangeMainDisplay(new ViewEmployee(Employee.GetEmployeeFromID(Convert.ToInt32(Employees_lb.SelectedValue))));
            }
        }

        private void Employees_lb_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void ManageStatuses_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                PopulateStatuses();
            }
        }

        private void ManageStatuses_Load(object sender, EventArgs e)
        {
            
        }

        private void AddStatus_btn_Click(object sender, EventArgs e)
        {
            if (CheckNewName())
            {
                Status status = new Status(Status.GetNextID(), NewName_tbx.Text.Trim());
                Status.statuses.Add(status);
                ProjectDal.AddStatus(status);
                MessageBox.Show("Status added", "Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.MenuInstance.ReloadDisplay(new ManageStatuses());
            }
        }

        private void NewName_tbx_TextChanged(object sender, EventArgs e)
        {
            if (CheckNewName())
            {
                AddStatus_btn.BackColor = Color.SteelBlue;
            }
            else
            {
                AddStatus_btn.BackColor = Color.Firebrick;
            }
        }

        private bool CheckNewName()
        {
            if (NewName_tbx.Text.Trim() == "")
                return false;
            if (!Status.IsNameTaken(NewName_tbx.Text.Trim()))
                return false;
            return true;
        }

        private void DeleteStatus_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Confirm Deletion of '{CurrentStatus.StatusName}' status.", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Status.RemoveStatus(CurrentStatus.StatusId);
                ProjectDal.DeleteStatus(CurrentStatus.StatusId);
                MessageBox.Show("Status deleted", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.MenuInstance.ReloadDisplay(new ManageStatuses());
            }
        }

        private void EditName_tbx_TextChanged(object sender, EventArgs e)
        {
            if (CheckEditName())
            {
                EditStatus_btn.BackColor = Color.SteelBlue;
            }
            else
            {
                EditStatus_btn.BackColor = Color.Firebrick;
            }
        }

        private bool CheckEditName()
        {
            if (EditName_tbx.Text.Trim() == "")
                return false;
            else if (EditName_tbx.Text.Trim() != CurrentStatus.StatusName)
            {
                if (!Status.IsNameTaken(EditName_tbx.Text.Trim()))
                {
                    return false;
                }
            }
            else 
            {
                return false;
            }
            return true;
        }

        private void EditStatus_btn_Click(object sender, EventArgs e)
        {
            if (CheckEditName())
            {
                Status status = new Status(CurrentStatus.StatusId, EditName_tbx.Text.Trim());
                Status.EditStatus(status);
                ProjectDal.EditStatus(status);

                foreach(Employee employee in Employee.employees)
                {
                    if (employee.status.StatusId == status.StatusId)
                    {
                        employee.status = status;
                    }
                }

                MessageBox.Show("Status edited", "Edit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.MenuInstance.ReloadDisplay(new ManageStatuses());
            }
        }

        private void Info_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
