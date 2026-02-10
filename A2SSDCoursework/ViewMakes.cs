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
    public partial class ViewMakes : UserControl
    {
        public static ViewMakes Instance = new ViewMakes();
        public Make CurrentMake = new Make();

        public ViewMakes()
        {
            InitializeComponent();

            Instance = this;

            PopulateMakes();
        }

        private void PopulateMakes()
        {
            Dictionary<int, string> makes = new Dictionary<int, string>();
            foreach (Make make in Make.makes)
            {
                makes.Add(make.MakeID, make.Name);
            }

            Makes_lb.DataSource = makes.ToArray();

            Makes_lb.DisplayMember = "Value";
            Makes_lb.ValueMember = "Key";

            if (Makes_lb.Items.Count > 0)
            {
                Makes_lb.SelectedIndex = 0;
                UpdateInfo();
            }
            else
            {
                Info_pnl.Visible = false;
            }
        }

        private void UpdateInfo()
        {
            int ID = 0;
            if (int.TryParse(Makes_lb.SelectedValue.ToString(), out ID))
            {
                List<int> employeeIDs = new List<int>();
                CurrentMake = Make.MakeFromID(ID);
                EditName_tbx.Text = "";
                decimal Profit = 0;
                int InStock = 0;
                int Sold = 0;
                int Services = 0;

                foreach (Vehicle vehicle in Vehicle.vehicles)
                {
                    if (vehicle.make.MakeID == ID)
                    {
                        if (vehicle.Sold)
                        {
                            Sold++;
                            Profit += vehicle.SoldPrice;
                        }
                        else
                        {
                            InStock++;
                        }
                        foreach(Service service in vehicle.ServiceHistory)
                        {
                            Services++;
                            Profit += service.Cost;
                        }
                    }
                }

                SelectedMake_lbl.Text = CurrentMake.Name;
                InStock_lbl.Text = InStock.ToString();
                Sold_lbl.Text = Sold.ToString();
                Services_lbl.Text = Services.ToString();
                Profit_lbl.Text = $"£{Profit}";

                if (InStock > 0 || Sold > 0)
                {
                    DeleteMake_btn.Visible = false;
                    DeleteUnderline_pnl.Visible = false;
                    DeleteRole_lbl.Visible = false;
                }
                else
                {
                    DeleteMake_btn.Visible = true;
                    DeleteUnderline_pnl.Visible = true;
                    DeleteRole_lbl.Visible = true;
                }
            }
        }

        private void Makes_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void EditName_tbx_TextChanged(object sender, EventArgs e)
        {
            if (EditName_tbx.Text.Trim() != CurrentMake.Name && EditName_tbx.Text.Trim() != "")
            {
                if (Make.CheckNameAvailability(EditName_tbx.Text.Trim()))
                {
                    EditMake_btn.BackColor = Color.SteelBlue;
                }
                else
                {
                    EditMake_btn.BackColor = Color.Firebrick;
                }
            }
            else
            {
                EditMake_btn.BackColor = Color.Firebrick;
            }
        }

        private void AddMake_btn_Click(object sender, EventArgs e)
        {
            if (Make.CheckNameAvailability(NewName_tbx.Text.Trim()) && NewName_tbx.Text.Trim() != "")
            {
               
                Make make = new Make(Make.NewID(), NewName_tbx.Text.Trim());
                ProjectDal.AddMake(make);
                Make.makes.Add(make);
                MessageBox.Show("Make added", "Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.MenuInstance.ReloadDisplay(new ViewMakes());
            }
        }

        private void NewName_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Make.CheckNameAvailability(NewName_tbx.Text.Trim()) && NewName_tbx.Text.Trim() != "")
            {
                AddMake_btn.BackColor = Color.SteelBlue;
            }
            else
            {
                AddMake_btn.BackColor = Color.Firebrick;
            }
        }

        private void EditMake_btn_Click(object sender, EventArgs e)
        {
            if (EditMake_btn.BackColor == Color.SteelBlue)
            {
                Make make = new Make(CurrentMake.MakeID, EditName_tbx.Text.Trim());
                Make.UpdateName(make);
                ProjectDal.UpdateMakeName(make);
                MessageBox.Show("Make edited", "Edit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.MenuInstance.ReloadDisplay(new ViewMakes());
            }
        }

        private void DeleteMake_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Confirm Deletion of '{CurrentMake.Name}' make.", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Make.RemoveMake(CurrentMake.MakeID);
                ProjectDal.DeleteMake(CurrentMake.MakeID);
                MessageBox.Show("Make deleted", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.MenuInstance.ReloadDisplay(new ViewMakes());
            }
        }
    }
}
