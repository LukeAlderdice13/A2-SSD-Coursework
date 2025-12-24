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
    public partial class ServiceHistory : UserControl
    {
        public static ServiceHistory instance = new ServiceHistory();
        public Vehicle vehicle = new Vehicle();
        public ServiceHistory()
        {
            InitializeComponent();
        }

        public ServiceHistory(Vehicle vehicle)
        {
            InitializeComponent();

            instance = this;

            this.vehicle = vehicle;

            int i = 0;
            List <Service> orderedHistory = vehicle.ServiceHistory.OrderBy(e => e.ServiceDate).ToList();

            foreach(Service service in orderedHistory)
            {
                Color colour = i % 2 == 0 ? Color.LightGray : Color.DarkGray;
                ServiceCard card = new ServiceCard(service, colour);
                card.Tag = "ServiceCard";
                CustomerInfo_pnl.Controls.Add(card);
                card.Dock = DockStyle.Top;
                i++;
            }
            if (i == 0)
            {
                Date_lbl.Visible = false;
                Employee_lbl.Visible = false;
                Type_lbl.Visible = false;
                Sold_lbl.Visible = false;
                Cost_lbl.Visible = false;

                NoServices_lbl.Visible = true;
            }
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

        private void ServiceHistory_Load(object sender, EventArgs e)
        {
            
        }

        private void ServiceHistory_Enter(object sender, EventArgs e)
        {
            
        }

        private void ServiceHistory_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                foreach(ServiceCard c in CustomerInfo_pnl.Controls)
                {
                    c.UpdateEmployeeInfo();
                }
            }
        }

        public void DeleteService(Service service)
        {
            vehicle.ServiceHistory.Remove(service);
            ProjectDal.DeleteService(service.ServiceID, service.vehicle.Id);

            MessageBox.Show("Record deleted", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ResetAllEdits()
        {
            foreach (ServiceCard c in CustomerInfo_pnl.Controls)
            {
                c.Edit_pnl.Hide();
            }
        }

        public void UpdateService(Service outdated, Service service)
        {
            foreach(Vehicle v in Vehicle.vehicles)
            {
                if (v.Id == vehicle.Id)
                {
                    vehicle.ServiceHistory.Remove(outdated);
                    vehicle.ServiceHistory.Add(service);
                }
            }
        }
    }
}
