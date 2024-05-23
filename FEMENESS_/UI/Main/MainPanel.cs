using FEMENESS_.Backend;
using FEMENESS_.UI.Authentication;
using FEMENESS_.UI.Main.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEMENESS_.UI.Main
{
    public partial class MainPanel : UserControl
    {
        private LoginPanel loginPanel;
        private User loggedUser;
        private BackendService backendService;
        public MainPanel(LoginPanel loginPanel, BackendService backendService, User loggedUser)
        {
            this.loggedUser = loggedUser;
            this.backendService = backendService;
            this.loginPanel = loginPanel;
            InitializeComponent();

            SwitchToPanel(new UI.Main.Features.HomePanel(backendService));
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            SwitchToPanel(new UI.Main.Features.HomePanel(backendService));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SwitchToPanel(new UI.Main.Features.ShopPanel(backendService));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            SwitchToPanel(new UI.Main.Features.InsightPanel());

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            SwitchToPanel(new UI.Main.Features.About(backendService));

        }


        private void iconButton6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Control mainPanel = Parent?.Parent?.Parent.Controls["MainPanel"];
                loginPanel.Visible = true;
                Parent?.Parent?.Parent?.Controls.Remove(mainPanel);
            }

        }

        private void SwitchToPanel(Control newPanel)
        {
            // Determine the dock style based on the type of panel
            if (newPanel is HomePanel || newPanel is About)
            {
                newPanel.Dock = DockStyle.Fill;
            }
            else
            {
                newPanel.Dock = DockStyle.Fill;
            }

            // Remove the current panel from the center_panel's Controls collection
            var currentPanel = this.center_panel.Controls.OfType<Control>().FirstOrDefault();
            if (currentPanel != null)
            {
                this.center_panel.Controls.Remove(currentPanel);
            }

            // Add the new panel to the center_panel
            this.center_panel.Controls.Add(newPanel);


        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
