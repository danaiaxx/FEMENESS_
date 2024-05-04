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

        // Event handler for mouse enter event
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            // Change button background color or any other style when mouse enters
            ((Button)sender).BackColor = Color.Gray; // For example, change to gray
        }

        // Event handler for mouse leave event
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // Restore button background color or any other style when mouse leaves
            ((Button)sender).BackColor = SystemColors.Control; // Restore default color
        }

        // Your existing event handlers for button clicks
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Your login button click logic
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Your register button click logic
        }
    }
}
