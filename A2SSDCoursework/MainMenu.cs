using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2SSDCoursework
{
    public partial class MainMenu : Form
    {
        public static MainMenu MenuInstance = new MainMenu();
        public static UserControl CurrentDisplay = new UserControl();
        public static List<UserControl> History = new List<UserControl>();
        public static HomePage homePage = new HomePage();
        public MainMenu()
        {
            InitializeComponent();

            CurrentDisplay = null;

            MenuInstance = this;

            MenuOptions menuOptions = new MenuOptions();
            MenuOptions_pnl.Controls.Add(menuOptions);
            
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
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        public void ClearHistory()
        {
            History.Clear();
            History.Add(homePage);
        }

        public void ChangeMainDisplay(UserControl display)
        {            
            if(History.Count > 0)
            {
                if (History[History.Count - 1] != display)
                {
                    History.Add(display);
                }
            } else
            {
                History.Add(display);
            }
            CurrentDisplay = display;
            MainDisplay_pnl.Controls.Clear();
            MainDisplay_pnl.Controls.Add(display);
            CurrentControl_lbl.Text = display.Tag != null ? display.Tag.ToString() : "Null";
            ReturnArrow_pb.Visible = History.Count > 1 ? true : false;
        }

        public void ReturnToPreviousDisplay()
        {
            History.RemoveAt(History.Count - 1);
            ChangeMainDisplay(History[History.Count - 1]);
        }

        public void ReloadDisplay(UserControl display)
        {
            History.RemoveAt(History.Count - 1);
            ChangeMainDisplay(display);
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
            ReturnToPreviousDisplay();
        }

        private void HomeIcon_pb_MouseEnter(object sender, EventArgs e)
        {
            HomeIcon_pb.Image = HomeIcon_il.Images[1];
        }

        private void HomeIcon_pb_MouseLeave(object sender, EventArgs e)
        {
            HomeIcon_pb.Image = HomeIcon_il.Images[0];
        }

        private void HomeIcon_pb_Click(object sender, EventArgs e)
        {
            History.Clear();
            MenuInstance.ChangeMainDisplay(new HomePage());
        }
    }
}
