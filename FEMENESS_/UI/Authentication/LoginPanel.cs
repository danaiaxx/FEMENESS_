using FEMENESS_.UI.Customization;
using FEMENESS_.UI.Main;
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
    public partial class LoginPanel : UserControl
    {
        CustomStyles customStyles = new CustomStyles();


        public LoginPanel()
        {
            InitializeComponent();

            // Add event handlers for text boxes
            name_textbox.GotFocus += TextBox_GotFocus;
            name_textbox.LostFocus += TextBox_LostFocus;
            password_textbox.GotFocus += TextBox_GotFocus;
            password_textbox.LostFocus += TextBox_LostFocus;

            // Set placeholder text for text boxes
            customStyles.SetPlaceholderText(name_textbox, "Username");
            customStyles.SetPlaceholderText(password_textbox, "Password");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = name_textbox.Text;
            string password = password_textbox.Text;

            if (customStyles.IsValidUsername(username) && customStyles.IsValidPassword(password))
            {
                MainPanel mainPanel = new UI.Main.MainPanel();
                mainPanel.Dock = DockStyle.Fill;
                Parent.Controls.Add(mainPanel);

                Parent.Controls.Remove(this);
            }
            else
            {
           
            }
        }



        private void redirectToRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            RegistrationPanel registrationPanel = new UI.Authentication.RegistrationPanel();
            registrationPanel.Dock = DockStyle.Bottom;
            Parent.Controls.Add(registrationPanel); 

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
                customStyles.SetPlaceholderText(name_textbox, "Username");
                customStyles.SetPlaceholderText(password_textbox, "Password");
            }
        }


    }

}

