using FEMENESS_.Backend;
using FEMENESS_.Backend.Auth;
using FEMENESS_.UI.Customization;
using System;
using System.Windows.Forms;

namespace FEMENESS_.UI.Authentication
{
    public partial class RegistrationPanel : UserControl
    {   
        BackendService backendService;
        CustomStyles customStyles = new CustomStyles();
        public RegistrationPanel(BackendService backendService)
        {
            this.backendService = backendService;
            InitializeComponent();

            // Call this method for each textbox
            SubscribeToFocusEvents(name_textbox);
            SubscribeToFocusEvents(email_textbox);
            SubscribeToFocusEvents(password_textbox);
            SubscribeToFocusEvents(confirmPassword_textbox);
        }

        private void SubscribeToFocusEvents(Control control)
        {
            if (control != null)
            {
                control.GotFocus += TextBox_GotFocus;
            }
        }


        private void login_button_MouseEnter(object sender, EventArgs e)
        {
            // Change button appearance when mouse enters
            registerButton.BackColor = Color.LightBlue; // For example, change background color
        }

        private void login_button_MouseLeave(object sender, EventArgs e)
        {
            // Reset button appearance when mouse leaves
            registerButton.BackColor = Color.Transparent; // Reset to default background color
        }

        private void redirectToLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginPanel loginPanel = new UI.Authentication.LoginPanel(backendService);
            loginPanel.Dock = DockStyle.Fill; 
            Parent.Controls.Add(loginPanel); 

            Parent.Controls.Remove(this);
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = name_textbox.Text.Trim();
            string email = email_textbox.Text.Trim();
            string password = password_textbox.Text.Trim();
            string confirmPassword = confirmPassword_textbox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                errorLabel.Text = "Please fill in all fields.";
                return;
            }

            if (!IsValidEmail(email))
            {
                errorLabel.Text = "Please enter a valid email address.";
                return;
            }

            errorLabel.Text = "";

            if (password != confirmPassword)
            {
                errorLabel.Text = "Passwords do not match.";
                return;
            }

            User newUser = backendService.Register(username, email, password);

            if (newUser != null)
            {
                MessageBox.Show("User created successfully!", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                errorLabel.Text = "Registration failed. Please try again.";
            }
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }


        public void TextBox_GotFocus(object? sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.ForeColor == SystemColors.GrayText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.WindowText;
                }
            }
        }


 
    }
}
