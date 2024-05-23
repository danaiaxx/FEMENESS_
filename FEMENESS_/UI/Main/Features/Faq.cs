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

        public Faq()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panelReduced)
            {
                panel1.Size = originalPanelSize;
                panelReduced = false;
            }
            else
            {
                originalPanelSize = panel1.Size;
                panel1.Size = new Size(1075, 144);
                panelReduced = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panelReduced1)
            {
                panel2.Size = originalPanelSize1;
                panelReduced1 = false;

            }
            else
            {
                originalPanelSize1 = panel2.Size;
                panel2.Size = new Size(1075, 139);
                panelReduced1 = true;
            }
        }
    }
}
