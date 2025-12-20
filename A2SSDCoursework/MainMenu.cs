using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        public void ChangeMainDisplay(UserControl display)
        {
            if (!History.Contains(display))
            {
                History.Add(CurrentDisplay);
            }
                
            CurrentDisplay = display;
            MainDisplay_pnl.Controls.Clear();
            MainDisplay_pnl.Controls.Add(display);
        }

        public void ReturnToPreviousDisplay()
        {
            History.Remove(CurrentDisplay);
            ChangeMainDisplay(History[History.Count - 1]);
        }
    }
}
