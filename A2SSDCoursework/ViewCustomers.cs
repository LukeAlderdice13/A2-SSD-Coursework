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
    public partial class ViewCustomers : UserControl
    {
        public ViewCustomers()
        {
            InitializeComponent();

            PopulateCustomers();
        }

        private void PopulateCustomers()
        {
            int i = 0;
            int j = 0;
            int panelWidth = this.ClientSize.Width - 23;
            int panelHeight = 143;
            int panelSpacing = 5;
            int currentY = 5;

            Panel panel = null;

            foreach (Customer customer in Customer.customers)
            {
                if (i == 0)
                {
                    panel = new Panel();
                    Customers_pnl.Controls.Add(panel);

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

                CustomerCard customerCard = new CustomerCard(customer, color);

                customerCard.Dock = DockStyle.Left;
                panel.Controls.Add(customerCard);

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
            Customers_pnl.Controls.Add(panel);
            panel.Size = new Size(panelWidth, 5);
            panel.Location = new Point(5, currentY);
        }
    }
}
