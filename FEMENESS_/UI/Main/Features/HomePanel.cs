using FEMENESS_.Backend;
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
    public partial class HomePanel : UserControl
    {
        private BackendService backendService;
        public HomePanel(BackendService backendService)
        {
            this.backendService = backendService;
            InitializeComponent();

            iconButton1.MouseEnter += Button_MouseEnter;
            iconButton2.MouseEnter += Button_MouseEnter;
            iconButton3.MouseEnter += Button_MouseEnter;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            InsightPanel insightPanel = new UI.Main.Features.InsightPanel();
            insightPanel.Dock = DockStyle.Bottom; 
            Parent.Controls.Add(insightPanel); 

            Parent.Controls.Remove(this);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ShopPanel shop = new UI.Main.Features.ShopPanel(backendService);
            shop.Dock = DockStyle.Bottom; 
            Parent.Controls.Add(shop);

            Parent.Controls.Remove(this);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            {
                Faq faq = new UI.Main.Features.Faq();
                faq.Dock = DockStyle.Fill;
                Parent.Controls.Add(faq);

                Parent.Controls.Remove(this);
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Transparent;
        }

    }
}
