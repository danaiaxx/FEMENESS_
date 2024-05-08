using FEMENESS_.Backend.Auth;
using FEMENESS_.UI.Customization;
using System;
using System.Windows.Forms;

namespace FEMENESS_.UI.Authentication
{
    public partial class RegistrationPanel : UserControl
    {   
        CustomStyles customStyles = new CustomStyles();
        public RegistrationPanel()
        {
            InitializeComponent();
            inititalPlaceholders();

            // Attach event handlers for text boxes
            name_textbox.GotFocus += TextBox_GotFocus;
            name_textbox.LostFocus += TextBox_LostFocus;
            email_textbox.GotFocus += TextBox_GotFocus;
            email_textbox.LostFocus += TextBox_LostFocus;
            password_textbox.GotFocus += TextBox_GotFocus;
            password_textbox.LostFocus += TextBox_LostFocus;
            confirmPassword_textbox.GotFocus += TextBox_GotFocus;
            confirmPassword_textbox.LostFocus += TextBox_LostFocus;
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
            LoginPanel loginPanel = new UI.Authentication.LoginPanel();
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
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                errorLabel.Text = "Please fill in all fields";
                return;
            }

            if (password != confirmPassword)
            {
                errorLabel.Text = "Passwords do not match.";
                return;
            }

            errorLabel.Text = "";

            // Create the Customer object
            Customer customer = new Customer(username, email, password);

            // Display the properties of the Customer object in a MessageBox
            string message = $"Username: {customer.Username}\nEmail: {customer.Email}\nPassword: {customer.Password}";
            MessageBox.Show(message, "Customer Information");
        }

        private void inititalPlaceholders()
        {
            customStyles.SetPlaceholderText(name_textbox, "Username");
            customStyles.SetPlaceholderText(email_textbox, "Email");
            customStyles.SetPlaceholderText(password_textbox, "Password");
            customStyles.SetPlaceholderText(confirmPassword_textbox, "Confirm Password");
        }

        public void TextBox_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.ForeColor == SystemColors.GrayText)
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText;
            }
        }


        public void TextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                inititalPlaceholders();
            }
        }

    }
}
