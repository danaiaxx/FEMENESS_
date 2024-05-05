using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEMENESS_.UI.Authentication
{
    public partial class AuthPanel : UserControl
    {
        public AuthPanel()
        {
            InitializeComponent();
            // Add event handlers for mouse enter and leave events for the buttons
            LoginButton.MouseEnter += Button_MouseEnter;
            LoginButton.MouseLeave += Button_MouseLeave;
            RegisterButton.MouseEnter += Button_MouseEnter;
            RegisterButton.MouseLeave += Button_MouseLeave;

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            // Change button appearance when mouse enters
            Button button = (Button)sender;

            // Set different hover colors based on the button
            if (button == LoginButton)
            {
                button.BackColor = Color.FromArgb(196, 153, 131);
                button.ForeColor = Color.FromArgb(245, 245, 245);
            }
            else if (button == RegisterButton)
            {
                button.BackColor = Color.FromArgb(245, 245, 245);
                button.ForeColor = Color.FromArgb(196, 153, 131);
            }
            // Add more conditions for other buttons if needed
        }


        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // Restore button appearance when mouse leaves
            Button button = (Button)sender;

            // Restore different button appearance based on the button
            if (button == LoginButton)
            {
                button.BackColor = Color.FromArgb(245, 245, 245);
                button.ForeColor = Color.FromArgb(196, 153, 131);
            }
            else if (button == RegisterButton)
            {
                button.BackColor = Color.FromArgb(196, 153, 131);
                button.ForeColor = Color.FromArgb(245, 245, 245);
            }
            // Add more conditions for other buttons if needed
        }


        // Your existing event handlers for button clicks
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Hide the current panel (AuthPanel)
            this.Visible = false;

            // Show the login panel
            LoginPanel loginPanel = new UI.Authentication.LoginPanel();
            loginPanel.Dock = DockStyle.Fill; // Fill the container with the login panel
            Parent.Controls.Add(loginPanel); // Add the login panel to the same container

            Parent.Controls.Remove(this);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Your register button click logic
            this.Visible = false;

        }
    }
}
