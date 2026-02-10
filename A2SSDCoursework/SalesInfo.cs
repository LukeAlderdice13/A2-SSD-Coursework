using A2_SSD_Coursework;
using Microsoft.Reporting.WinForms;
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
    public partial class SalesInfo : UserControl
    {
        int currentReport;
        public SalesInfo()
        {
            InitializeComponent();

            
        }

        private void SalesInfo_Load(object sender, EventArgs e)
        {
            currentReport = 0;
            Report_pnl.Controls.Add(new VehicleSalesReport());
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentReport != 0)
            {
                ResetButtons();
                vehiclesToolStripMenuItem.ForeColor = Color.White;
                currentReport = 0;
                Report_pnl.Controls.Clear();
                Report_pnl.Controls.Add(new VehicleSalesReport());
            }
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentReport != 1)
            {
                ResetButtons();
                employeesToolStripMenuItem.ForeColor = Color.White;
                currentReport = 1;
                Report_pnl.Controls.Clear();
                Report_pnl.Controls.Add(new EmployeeSalesReport());
            }
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentReport != 2)
            {
                ResetButtons();
                servicesToolStripMenuItem.ForeColor = Color.White;
                currentReport = 2;
                Report_pnl.Controls.Clear();
                Report_pnl.Controls.Add(new ServiceSalesReport());
            }
        }

        private void ResetButtons()
        {
            employeesToolStripMenuItem.ForeColor = Color.Black;
            servicesToolStripMenuItem.ForeColor = Color.Black;
            vehiclesToolStripMenuItem.ForeColor = Color.Black;
        }
    }
}
