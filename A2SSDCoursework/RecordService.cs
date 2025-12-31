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
    public partial class RecordService : UserControl
    {
        public Vehicle vehicle = new Vehicle();
        public int employeeIndex = 0;
        public int storedIndex = 0;

        public RecordService()
        {
            InitializeComponent();
        }

        public RecordService(Vehicle vehicle)
        {
            InitializeComponent();

            this.vehicle = vehicle;

            PopulateEmployees();
        }

        private void RecordService_btn_Click(object sender, EventArgs e)
        {
            if (CheckValues())
            {
                Service service = new Service(vehicle, Date_dtp.Value, Employee.GetEmployeeFromID(Convert.ToInt32(Employees_cb.SelectedValue)), Type_tbx.Text.Trim(), Cost_nud.Value);

                Vehicle.AddService(vehicle.Id, service);

                ProjectDal.AddService(service);

                MessageBox.Show("Service Successfully Added", "Service Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Type_tbx.Text = "";
                Cost_nud.Value = 0;
            }
        }

        private bool CheckValues()
        {
            if(Type_tbx.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }

        private void Type_tbx_TextChanged(object sender, EventArgs e)
        {
            RecordService_btn.BackColor = CheckValues() ? Color.SteelBlue : Color.Firebrick;
        }

        private void RecordService_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                PopulateEmployees();
            }
        }

        private void PopulateEmployees()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            foreach (Employee employee in Employee.employees)
            {
                myDictionary.Add(employee.EmployeeID, $"{employee.FullName}. ID: {employee.EmployeeID}");
            }
            Employees_cb.DataSource = myDictionary.ToArray();

            Employees_cb.DisplayMember = "Value";
            Employees_cb.ValueMember = "Key";

            Employees_cb.SelectedIndex = storedIndex;
        }

        private void Employees_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeeIndex = Convert.ToInt32(Employees_cb.SelectedIndex);
        }

        private void ViewEmployee_lbl_MouseEnter(object sender, EventArgs e)
        {
            ViewEmployee_lbl.ForeColor = Color.Teal;
            ViewEmployee_lbl.Font = new Font("Microsoft Sans Serif", ViewEmployee_lbl.Font.Size, FontStyle.Underline);
        }

        private void ViewEmployee_lbl_MouseLeave(object sender, EventArgs e)
        {
            ViewEmployee_lbl.ForeColor = Color.Black;
            ViewEmployee_lbl.Font = new Font("Microsoft Sans Serif", ViewEmployee_lbl.Font.Size);
        }

        private void ViewEmployee_lbl_Click(object sender, EventArgs e)
        {
            storedIndex = employeeIndex;
            Employee employee = Employee.GetEmployeeFromID(Convert.ToInt32(Employees_cb.SelectedValue));
            MainMenu.MenuInstance.ChangeMainDisplay(new ViewEmployee(employee));
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
