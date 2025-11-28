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
    public partial class AddMake : UserControl
    {
        public AddMake()
        {
            InitializeComponent();
        }

        private void AddButton_pb_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_pb_MouseEnter(object sender, EventArgs e)
        {
            if (AddButton_pb.Visible)
            {
                AddButtonHover_pb.Visible = true;
                AddButton_pb.Visible = false;
            }
        }

        private void AddButtonHover_pb_MouseLeave(object sender, EventArgs e)
        {
            if (AddButtonHover_pb.Visible)
            {
                AddButton_pb.Visible = true;
                AddButtonHover_pb.Visible = false;
            }
        }

        private void AddButtonHover_pb_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkGray;
            AddButtonHover_pb.Visible = false;
            Info_pnl.Visible = true;

            MakeName_tbx.Focus();
        }

        private void Escape_btn_Click(object sender, EventArgs e)
        {
            Info_pnl.Visible = false;
            MakeName_tbx.Text = "";

            BackColor = Color.FromArgb(192, 192, 255);
            AddButton_pb.Visible = true;
        }

        private void AddButton_pb_MouseHover(object sender, EventArgs e)
        {
            if (AddButton_pb.Visible)
            {
                AddButtonHover_pb.Visible = true;
                AddButton_pb.Visible = false;
            }
        }

        private void AddMake_btn_Click(object sender, EventArgs e)
        {
            if (MakeName_tbx.Text != "" && Make.CheckNameAvailability(MakeName_tbx.Text))
            {
                ProjectDal.AddMake(MakeName_tbx.Text);
                MainMenu.MenuInstance.ChangeMainDisplay(new ViewMakes());
            }
        }
    }
}
