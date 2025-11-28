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
    public partial class EmployeeCard : UserControl
    {
        private Color color = new Color();
        Employee employee = new Employee();
        public EmployeeCard()
        {
            InitializeComponent();
        }

        public EmployeeCard(Employee employee, Color color)
        {
            InitializeComponent();

            this.BackColor = color;
            this.color = color;
            this.employee = employee;
            EmployeeName_lbl.Text = employee.FullName;
            EmploymentStatus_lbl.Text = $"Status: {employee.status.StatusName}";
            JoinDate_lbl.Text = $"Joined {employee.DateHired.ToShortDateString()}";
            Salary_lbl.Text = $"Salary: £{employee.Salary}";

            AddMouseEvents(this);
        }

        private void AddMouseEvents(Control parent)
        {
            parent.MouseEnter += EmployeeCard_MouseEnter;
            parent.MouseLeave += EmployeeCard_MouseLeave;

            foreach (Control c in parent.Controls)
            {
                AddMouseEvents(c);
            }
        }

        private void EmployeeCard_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void EmployeeCard_Leave(object sender, EventArgs e)
        {
            
        }

        private void EmployeeCard_MouseLeave(object sender, EventArgs e)
        {
            BackColor = color;
        }

        private void Info_pnl_Enter(object sender, EventArgs e)
        {
            
        }

        private void ViewEmployee_btn_Click(object sender, EventArgs e)
        {
            ViewEmployee viewEmployee = new ViewEmployee(employee);
            MainMenu.MenuInstance.ChangeMainDisplay(viewEmployee);
        }
    }
}
