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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ProjectDal.GetEmployees();
            ProjectDal.GetRoles();
            ProjectDal.GetEmploymentStatuses();
            ProjectDal.GetMakes();
            ProjectDal.GetVehicles();
            ProjectDal.GetCustomers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            LoginEnter();
        }

        private void LoginEnter()
        {
            string username = username_tbx.Text;
            string password = password_tbx.Text;
            bool isLoginValid = false;

            foreach (Employee employee in Employee.employees)
            {
                if (username == employee.Username && password == employee.Password)
                {
                    MessageBox.Show($"Logged in to employee {employee.EmployeeID}");
                    isLoginValid = true;
                    for(int i = 0; i < Employee.employees.Count; i++)
                    {
                        if (Employee.employees[i].EmployeeID == employee.EmployeeID)
                        {
                            Employee.currentEmployee = i;
                            break;
                        }
                    }
                    break;
                }
            }
            if (!isLoginValid)
            {
                MessageBox.Show("Incorrect username or password.");
            } 
            else {
                MainMenu menu = new MainMenu();
                Hide();
                menu.Show();
            }
        }

        private void password_tbx_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void password_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoginEnter();
            }
            else if (e.KeyCode == Keys.Up)
            {
                username_tbx.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                Login_btn.Focus();
            }
        }

        private void username_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                password_tbx.Focus();
            }           
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void NavBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void NavBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void NavBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
            }
}
