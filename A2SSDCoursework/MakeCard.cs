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
            ViewMakes.Instance.ResetMakeCards();

            MakeName_tbx.Text = make.Name;
            MakeName_tbx.Visible = true;
            MakeName_lbl.Visible = false;

            ConfirmEdit_btn.Visible = true;
            Reset_btn.Visible = true;

            EditName_btn.Visible = false;
            DeleteMake_btn.Visible = false;
        }

        public void EditName()
        {
            if (Make.CheckNameAvailability(MakeName_tbx.Text))
            {
                ProjectDal.UpdateMakeName(make, MakeName_tbx.Text);
                make.Name = MakeName_tbx.Text;

                ResetButtons();
            }
            else if (make.Name != MakeName_tbx.Text)
            {
                MessageBox.Show("The make entered already exists.", "Error Updating Make Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ResetButtons();
            }
        }

        public void ResetButtons()
        {
            MakeName_lbl.Visible = true;
            MakeName_lbl.Text = make.Name;
            MakeName_tbx.Visible = false;
            MakeName_tbx.Text = make.Name;

            EditName_btn .Visible = true;
            DeleteMake_btn .Visible = true;

            ConfirmEdit_btn .Visible = false;
            Reset_btn .Visible = false;
        }

        private void DeleteMake_btn_Click(object sender, EventArgs e)
        {
            ViewMakes.Instance.ResetMakeCards();

            if (MessageBox.Show($"Are you sure you want to delete the '{make.Name}' make?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)  == DialogResult.Yes)
            {
                ProjectDal.DeleteMake(make.MakeID);
                MainMenu.MenuInstance.ChangeMainDisplay(new ViewMakes());
            }
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
