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
            inititalPlaceholders();

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
                control.LostFocus += TextBox_LostFocus;
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
            loginPanel.Dock = DockStyle.Fill; // Fill the container with the login panel
            Parent.Controls.Add(loginPanel); // Add the login panel to the same container

            Parent.Controls.Remove(this);
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = name_textbox.Text;
            string email = email_textbox.Text;
            string password = password_textbox.Text;
            string confirmPassword = confirmPassword_textbox.Text;

            // Client-side validation
            if (IsPlaceholderText(username) || IsPlaceholderText(email) ||
                IsPlaceholderText(password) || IsPlaceholderText(confirmPassword))
            {
                errorLabel.Text = "Please fill in all fields.";
                return;
            }

            // Clear previous error messages
            errorLabel.Text = "";

            if (password != confirmPassword)
            {
                errorLabel.Text = "Passwords do not match.";
                return;
            }

            User newUser = backendService.Register(username, email, password);

            if (newUser != null)
            {
                errorLabel.Text = "Registration success.";
            }
            else
            {
                // Registration failed, handle the error
                // For example:
                errorLabel.Text = "Registration failed. Please try again.";
            }
        }

        private bool IsPlaceholderText(string text)
        {
            return text.Trim() == "Username" || text.Trim() == "Email" ||
                   text.Trim() == "Password" || text.Trim() == "Confirm Password";
        }

        private void inititalPlaceholders()
        {
    
                customStyles.SetPlaceholderText(name_textbox, "Username");
                customStyles.SetPlaceholderText(email_textbox, "Email");
                customStyles.SetPlaceholderText(password_textbox, "Password");
                customStyles.SetPlaceholderText(confirmPassword_textbox, "Confirm Password");
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


        public void TextBox_LostFocus(object? sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    inititalPlaceholders();
                }
            }
        }


    }
}
