using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEMENESS_.UI.Main.Features
{
    public partial class Faq : UserControl
    {
        private bool panelReduced = false;
        private Size originalPanelSize;

        private bool panelReduced1 = false;
        private Size originalPanelSize1;

        private bool panelReduced2 = false;
        private Size originalPanelSize2;

        private bool panelReduced3 = false;
        private Size originalPanelSize3;

        private bool panelReduced4 = false;
        private Size originalPanelSize4;

        private bool panelReduced5 = false;
        private Size originalPanelSize5;

        private bool panelReduced6 = false;
        private Size originalPanelSize6;

        private bool panelReduced7 = false;
        private Size originalPanelSize7;

        private bool panelReduced8 = false;
        private Size originalPanelSize8;


        public Faq()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panelReduced)
            {
                flowLayoutPanel2.Size = originalPanelSize;
                panelReduced = false;
            }
            else
            {
                originalPanelSize = flowLayoutPanel2.Size;
                flowLayoutPanel2.Size = new Size(1075, 144);
                panelReduced = true;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panelReduced2)
            {
                flowLayoutPanel4.Size = originalPanelSize2;
                panelReduced2 = false;
            }
            else
            {
                originalPanelSize2 = flowLayoutPanel4.Size;
                flowLayoutPanel4.Size = new Size(1075, 144);
                panelReduced2 = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panelReduced3)
            {
                flowLayoutPanel5.Size = originalPanelSize3;
                panelReduced3 = false;
            }
            else
            {
                originalPanelSize3 = flowLayoutPanel5.Size;
                flowLayoutPanel5.Size = new Size(1075, 144);
                panelReduced3 = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panelReduced4)
            {
                flowLayoutPanel6.Size = originalPanelSize4;
                panelReduced4 = false;
            }
            else
            {
                originalPanelSize4 = flowLayoutPanel6.Size;
                flowLayoutPanel6.Size = new Size(1075, 144);
                panelReduced4 = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (panelReduced5)
            {
                flowLayoutPanel7.Size = originalPanelSize5;
                panelReduced5 = false;
            }
            else
            {
                originalPanelSize5 = flowLayoutPanel7.Size;
                flowLayoutPanel7.Size = new Size(1075, 144);
                panelReduced5 = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (panelReduced6)
            {
                flowLayoutPanel8.Size = originalPanelSize6;
                panelReduced6 = false;
            }
            else
            {
                originalPanelSize6 = flowLayoutPanel8.Size;
                flowLayoutPanel8.Size = new Size(1075, 144);
                panelReduced6 = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (panelReduced7)
            {
                flowLayoutPanel9.Size = originalPanelSize7;
                panelReduced7 = false;
            }
            else
            {
                originalPanelSize7 = flowLayoutPanel9.Size;
                flowLayoutPanel9.Size = new Size(1075, 144);
                panelReduced7 = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (panelReduced8)
            {
                flowLayoutPanel10.Size = originalPanelSize8;
                panelReduced8 = false;
            }
            else
            {
                originalPanelSize8 = flowLayoutPanel10.Size;
                flowLayoutPanel10.Size = new Size(1075, 144);
                panelReduced8 = true;
            }
        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (panelReduced1)
            {
                flowLayoutPanel3.Size = originalPanelSize1;
                panelReduced1 = false;
            }
            else
            {
                originalPanelSize1 = flowLayoutPanel3.Size;
                flowLayoutPanel3.Size = new Size(1075, 144);
                panelReduced1 = true;
            }
        }
    }
}
