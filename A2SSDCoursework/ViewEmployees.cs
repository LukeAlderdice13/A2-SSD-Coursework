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
    public partial class ViewEmployees : UserControl
    {
        public static ViewEmployees Instance = new ViewEmployees();
        private int visibleEmployees = 0;
        public ViewEmployees()
        {
            InitializeComponent();

            Instance = this;

            SearchIcon_pb.Image = SearchIcon_il.Images[0];

            PopulateComboBoxes();

            PopulateEmployees();
        }

        public void PopulateEmployees()
        {
            Employees_pnl.Controls.Clear();
            visibleEmployees = 0;
            int i = 0;
            int j = 0;
            int panelWidth = Employees_pnl.Width - 23;
            int panelHeight = 170;
            int panelSpacing = 5;
            int currentY = 5;

            Panel panel = null;

            foreach (Employee employee in Employee.employees)
            {
                if (CheckSearch(employee))
                {
                    visibleEmployees++;
                    if (i == 0)
                    {
                        panel = new Panel();
                        Employees_pnl.Controls.Add(panel);

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

                    EmployeeCard employeeCard = new EmployeeCard(employee, color);

                    employeeCard.Dock = DockStyle.Left;
                    panel.Controls.Add(employeeCard);

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
            if(visibleEmployees > 0)
            {
                panel = new Panel();
                Employees_pnl.Controls.Add(panel);
                panel.Size = new Size(panelWidth, 5);
                panel.Location = new Point(5, currentY);
            } else
            {
                Label noEmployees = new Label();
                noEmployees.Text = "No Employees Found";
                noEmployees.Size = new Size(Employees_pnl.Width, 80);
                noEmployees.Font = new Font("Adobe Hebrew", 40);
                Employees_pnl.Controls.Add(noEmployees);
                noEmployees.Location = new Point(0, 10);
                noEmployees.ForeColor = Color.Red;
                noEmployees.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void PopulateComboBoxes()
        {
            Gender_cb.SelectedIndex = 0;

            Role_cb.Items.Clear();
            Role_cb.Items.Add("Any Role");
            Role_cb.Items.Add("No Role");
            foreach(Role role in Role.roles)
            {
                Role_cb.Items.Add(role.RoleName);
            }
            Role_cb.SelectedIndex = 0;

            Status_cb.Items.Add("Any Status");
            foreach(Status status in Status.statuses)
            {
                Status_cb.Items.Add(status.StatusName);
            }
            Status_cb.SelectedIndex = 0;

            MinSalary_nud.Minimum = Employee.MinSalary();            

            MaxSalary_nud.Maximum = Employee.MaxSalary();        

            MaxSalary_nud.Minimum = MinSalary_nud.Minimum + 1;
            MinSalary_nud.Maximum = MaxSalary_nud.Maximum - 1;

            MaxSalary_nud.Value = MaxSalary_nud.Maximum;
            MinSalary_nud.Value = MinSalary_nud.Minimum;
        }

        private bool CheckSearch(Employee employee)
        {
            if (!employee.FullName.ToLower().Contains(Name_tbx.Text.ToLower()))
                return false;
            if (Gender_cb.SelectedIndex != 0 && employee.Gender != Gender_cb.SelectedItem.ToString())
                return false;
            if (Role_cb.SelectedIndex == 1)
            {
                if (employee.Roles.Count > 0)
                {
                    return false;
                }
            }
            else if (Role_cb.SelectedIndex != 0)
            {
                if (employee.Roles.Count == 0)
                {
                    return false;
                }
                bool hasRole = false;
                foreach (Role role in employee.Roles)
                {
                    if (role.RoleName == Role_cb.SelectedItem.ToString())
                    {
                        hasRole = true;
                    }
                    if (!hasRole)
                    {
                        return false;
                    }
                }               
            }          
            if (Status_cb.SelectedIndex != 0)
            {
                if (employee.status.StatusName != Status_cb.SelectedItem.ToString())
                {
                    return false;
                }
            }
            if (employee.Salary > MaxSalary_nud.Value || employee.Salary < MinSalary_nud.Value)
                return false;
            return true;
        }

        private void SearchIcon_pb_MouseEnter(object sender, EventArgs e)
        {
            SearchIcon_pb.Image = SearchIcon_il.Images[1];
        }

        private void SearchIcon_pb_MouseLeave(object sender, EventArgs e)
        {
            SearchIcon_pb.Image = SearchIcon_il.Images[0];
        }

        private void SearchIcon_pb_Click(object sender, EventArgs e)
        {
            PopulateEmployees();
        }

        private void MinSalary_nud_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (MinSalary_nud.Value > MaxSalary_nud.Value)
                {
                    MaxSalary_nud.Value = MinSalary_nud.Value + 1;
                }
            }
            catch
            {

            }
        }

        private void MaxSalary_nud_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (MaxSalary_nud.Value < MinSalary_nud.Value)
                {
                    MinSalary_nud.Value = MaxSalary_nud.Value - 1;
                }
            }
            catch
            {

            }
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
            Gender_cb.SelectedIndex = 0;
            Role_cb.SelectedIndex = 0;

            MaxSalary_nud.Value = MaxSalary_nud.Maximum;
            MinSalary_nud.Value = MinSalary_nud.Minimum;

            PopulateEmployees();
        }
    }
}
