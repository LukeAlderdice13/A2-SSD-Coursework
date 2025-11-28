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

        public List<MakeCard> MakeCards = new List<MakeCard>();

        public int finalY = 0;
        public int finalXIndex = 0;
        public int finalYIndex = 0;

        public ViewMakes()
        {
            InitializeComponent();

            Instance = this;

            PopulateMakes();
        }

        private void PopulateMakes()
        {
            int i = 0;
            int j = 0;
            int panelWidth = this.ClientSize.Width - 23;
            int panelHeight = 133;
            int panelSpacing = 5;
            int currentY = 5;

            int currentX = 0;

            Panel panel = new Panel();

            foreach (Make make in Make.makes)
            {
                if (i == 0)
                {
                    panel = new Panel();
                    Makes_pnl.Controls.Add(panel);

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

                MakeCard makeCard = new MakeCard(make, color);
                MakeCards.Add(makeCard);
                panel.Controls.Add(makeCard);
                makeCard.Location = new Point(currentX, 0);
                currentX += makeCard.Width;

                if (i == 3)
                {
                    i = 0;
                    j++;
                    currentX = 0;
                    finalXIndex = i;
                    finalYIndex = j;
                }
                else
                {
                    i++;
                    finalXIndex = i;
                }
            }

            AddMake addMake = new AddMake();
            panel.Controls.Add(addMake);
            addMake.Location = new Point(currentX, 0);

            panel = new Panel();
            Makes_pnl.Controls.Add(panel);
            panel.Size = new Size(panelWidth, 5);
            panel.Location = new Point(5, currentY);
        }

        public void ResetMakeCards()
        {
            foreach (MakeCard card in MakeCards)
            {
                card.ResetButtons();
            }
        }
    }
}
