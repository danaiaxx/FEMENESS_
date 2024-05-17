using FEMENESS_.Backend;
using FEMENESS_.UI.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEMENESS_.UI.Main.Features
{
    public partial class ForgetPanel : UserControl
    {
        private BackendService backendService;
        private Control siblingPanel;

        public ForgetPanel(BackendService backendService, Control siblingPanel)
        {
            this.siblingPanel = siblingPanel;
            this.backendService = backendService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            string email = textBox1.Text.Trim();
            string password = textBox3.Text.Trim();
            string confirmPassword = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                errorLabel.Text = "Please fill in all fields.";
                return;
            }
            if (!IsValidEmail(email))
            {
                errorLabel.Text = "Please enter a valid email address.";
                return;
            }

            if (password != confirmPassword)
            {
                errorLabel.Text = "Passwords do not match.";
                return;
            }

            // Check if the new password is the same as the current password
            string currentPassword = backendService.GetCurrentPassword(email);
            if (currentPassword == password)
            {
                errorLabel.Text = "The new password cannot be the same as the current password.";
                return;
            }

            backendService.ForgotPassword(email, password);

            // Provide feedback to the user

            // Provide feedback to the user
            this.Visible = false;

            // Navigate back to login screen
            siblingPanel.Visible = true;
        }


        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // Navigate back to login screen
            siblingPanel.Visible = true;
        }
    }
}
