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
    public partial class ServiceCard : UserControl
    {
        public Service service = new Service();
        public ServiceCard()
        {
            InitializeComponent();
        }

        public ServiceCard(Service service, Color colour)
        {
            InitializeComponent();

            this.service = service;

            BackColor = Color.LightGray;
            Date_lbl.Text = service.ServiceDate.ToString("dd/MM/yyyy");
            Cost_lbl.Text = $"£{service.Cost}";
            Employee_lbl.Text = service.employee.FullName;
            ServiceType_lbl.Text = service.ServiceType;

            if (service.vehicle.Sold)
            {
                Sold_lbl.Text = service.vehicle.DateSold <= service.ServiceDate ? "Yes" : "No";
            }
        }

        private void Employee_lbl_MouseEnter(object sender, EventArgs e)
        {
            Employee_lbl.ForeColor = Color.Teal;
            Employee_lbl.Font = new Font("Microsoft Sans Serif", Employee_lbl.Font.Size, FontStyle.Underline);
        }

        private void Employee_lbl_MouseLeave(object sender, EventArgs e)
        {
            Employee_lbl.ForeColor = Color.Black;
            Employee_lbl.Font = new Font("Microsoft Sans Serif", Employee_lbl.Font.Size);
        }

        private void Employee_lbl_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        public void UpdateEmployeeInfo()
        {
            service.employee = Employee.GetEmployeeFromID(service.employee.EmployeeID);
            Employee_lbl.Text = service.employee.FullName;
        }

        private void Delete_pb_MouseEnter(object sender, EventArgs e)
        {
            Delete_pb.Image = Bin_il.Images[1];
        }

        private void Delete_pb_MouseLeave(object sender, EventArgs e)
        {
            Delete_pb.Image = Bin_il.Images[0];
        }

        private void ServiceCard_MouseEnter(object sender, EventArgs e)
        {

        }

        private void ServiceCard_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Edit_pb_MouseEnter(object sender, EventArgs e)
        {
            Edit_pb.Image = Edit_il.Images[1];
        }

        private void Edit_pb_MouseLeave(object sender, EventArgs e)
        {
            Edit_pb.Image = Edit_il.Images[0];
        }

        private void Delete_pb_Click(object sender, EventArgs e)
        {
            ServiceHistory.instance.ResetAllEdits();
            if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hide();
                ServiceHistory.instance.DeleteService(service);
            }
        }

        private void Edit_pb_Click(object sender, EventArgs e)
        {
            ServiceHistory.instance.ResetAllEdits();
            Edit_pnl.Visible = true;

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            foreach (Employee employee in Employee.employees)
            {
                myDictionary.Add(employee.EmployeeID, $"{employee.FullName}. ID: {employee.EmployeeID}");
            }
            Employees_cb.DataSource = myDictionary.ToArray();

            Employees_cb.DisplayMember = "Value";
            Employees_cb.ValueMember = "Key";

            Employees_cb.SelectedValue = service.employee.EmployeeID;

            Type_tbx.Text = service.ServiceType;
            Cost_nud.Value = service.Cost;
            
        }

        private void Tick_pb_MouseEnter(object sender, EventArgs e)
        {
            Tick_pb.Image = Tick_il.Images[1];
        }

        private void Tick_pb_MouseLeave(object sender, EventArgs e)
        {
            Tick_pb.Image = Tick_il.Images[0];
        }

        private void X_pb_MouseEnter(object sender, EventArgs e)
        {
            X_pb.Image = X_il.Images[1];
        }

        private void X_pb_MouseLeave(object sender, EventArgs e)
        {
            X_pb.Image = X_il.Images[0];
        }

        private void X_pb_Click(object sender, EventArgs e)
        {
            Edit_pnl.Hide();
        }

        private void Tick_pb_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Employees_cb.SelectedValue) != service.employee.EmployeeID
                || Cost_nud.Value != service.Cost
                || Type_tbx.Text != service.ServiceType)
            {
                Service outdatedService = service;
                service.employee = Employee.GetEmployeeFromID(Convert.ToInt32(Employees_cb.SelectedValue));
                service.ServiceType = Type_tbx.Text.Trim();
                service.Cost = Cost_nud.Value;

                Employee_lbl.Text = service.employee.FullName;
                ServiceType_lbl.Text = service.ServiceType;
                Cost_lbl.Text = $"£{service.Cost}";

                Edit_pnl.Visible = false;

                ProjectDal.UpdateService(service);
                ServiceHistory.instance.UpdateService(outdatedService, service);
            } else
            {
                Edit_pnl.Visible = false;
            }

        }

        private void Employees_cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void Employee_lbl_Click(object sender, EventArgs e)
        {
            ServiceHistory.instance.ResetAllEdits();
            MainMenu.MenuInstance.ChangeMainDisplay(new ViewEmployee(service.employee));
        }
    }
}
