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
    public partial class MakeCard : UserControl
    {
        Color colour = new Color();
        Make make = new Make();
        bool DeleteVisibility;
        public MakeCard()
        {
            InitializeComponent();
        }

        public MakeCard(Make make, Color colour)
        {
            InitializeComponent();

            this.make = make;
            this.colour = colour;
            this.BackColor = this.colour;

            MakeName_lbl.Text = make.Name;
            Info_pnl.BackColor = this.colour;
            DeleteVisibility = !Vehicle.IsMakeUsed(make.MakeID);
            DeleteMake_btn.Visible = DeleteVisibility;
        }

        private void MakeCard_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void MakeCard_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void ConfirmEdit_btn_Click(object sender, EventArgs e)
        {
            EditName();
        }

        private void EditName_btn_Click(object sender, EventArgs e)
        {

        }

        public void EditName()
        {

        }

        public void ResetButtons()
        {
            MakeName_lbl.Visible = true;
            MakeName_lbl.Text = make.Name;
            MakeName_tbx.Visible = false;
            MakeName_tbx.Text = make.Name;

            EditName_btn .Visible = true;
            DeleteMake_btn.Visible = DeleteVisibility;

            ConfirmEdit_btn .Visible = false;
            Reset_btn .Visible = false;
        }

        private void DeleteMake_btn_Click(object sender, EventArgs e)
        {

        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            ResetButtons();
        }

        private void MakeName_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditName();
            }
        }
    }
}
