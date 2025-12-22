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
            BackColor = colour;

            Date_lbl.Text = service.ServiceDate.ToString("dd/ff/yyyy");
            Cost_lbl.Text = $"£{service.Cost}";
            Employee_lbl.Text = service.employee.FullName;
            ServiceType_lbl.Text = service.ServiceType;

            if (service.vehicle.Sold)
            {
                Sold_lbl.Text = service.vehicle.DateSold > service.ServiceDate ? "No" : "Yes";
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
            MainMenu.MenuInstance.ChangeMainDisplay(new ViewEmployee(service.employee));
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
    }
}
