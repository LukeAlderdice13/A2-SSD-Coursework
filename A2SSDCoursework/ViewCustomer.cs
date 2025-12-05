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
    public partial class ViewCustomer : UserControl
    {
        Customer customer = new Customer();
        public ViewCustomer()
        {
            InitializeComponent();
        }

        public ViewCustomer(Customer customer)
        {
            InitializeComponent();

            this.customer = customer;

            PopulateVehicles();
        }

        private void PopulateVehicles()
        {
            List<Vehicle> vehicles = Vehicle.GetVehiclesFromIDs(customer.BoughtVehicles);

            int i = 0;
            int j = 0;
            int panelWidth = this.ClientSize.Width - 23;
            int panelHeight = 253;
            int panelSpacing = 5;
            int currentY = 5;

            Panel panel = null;

            foreach (Vehicle vehicle in vehicles)
            {
                if (i == 0)
                {
                    panel = new Panel();
                    BoughtVehicles_pnl.Controls.Add(panel);

                    panel.Size = new Size(panelWidth, panelHeight);
                    panel.Location = new Point(5, currentY);

                    currentY += panelHeight + panelSpacing; // update Y for next panel
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

                VehicleCard vehicleCard = new VehicleCard(vehicle, color);

                vehicleCard.Dock = DockStyle.Left; // you can keep docking inside the panel
                panel.Controls.Add(vehicleCard);

                if (i == 3)
                {
                    i = 0;
                    j++;
                }
                else
                {
                    i++;
                }
            }

            panel = new Panel();
            BoughtVehicles_pnl.Controls.Add(panel);
            panel.Size = new Size(panelWidth, 5);
            panel.Location = new Point(5, currentY);
        }
    }
}
