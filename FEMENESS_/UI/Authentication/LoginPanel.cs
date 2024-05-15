using FEMENESS_.Backend;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FEMENESS_.UI.Authentication
{
    public partial class LoginPanel : UserControl
    {
        CustomStyles customStyles = new CustomStyles();
        BackendService backendService;

        public LoginPanel(BackendService backendService)
        {
            this.backendService = backendService;
            InitializeComponent();

            name_textbox.GotFocus += TextBox_GotFocus;
            name_textbox.LostFocus += TextBox_LostFocus;
            password_textbox.GotFocus += TextBox_GotFocus;
            password_textbox.LostFocus += TextBox_LostFocus;

            customStyles.SetPlaceholderText(name_textbox, "Username");
            customStyles.SetPlaceholderText(password_textbox, "Password");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = name_textbox.Text;
            string password = password_textbox.Text;
            User loggedUser = backendService.Login(username, password);


            if (username == "Username" || password == "Password")
            {
                errorLabel.Text = "Please fill in the fields";
                return;

            }

            if (loggedUser != null)
            {
                errorLabel.Text = "";
                name_textbox.Text = "";
                password_textbox.Text = "";

                MainPanel mainPanel = new UI.Main.MainPanel(this, backendService, loggedUser);
                mainPanel.Dock = DockStyle.Fill;
                Parent?.Controls.Add(mainPanel);

                this.Visible = false;
            }
            else
            {
                errorLabel.Text = "Invalid username or password";
                return;
            }
        }



        private void redirectToRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            RegistrationPanel registrationPanel = new UI.Authentication.RegistrationPanel(backendService);
            registrationPanel.Dock = DockStyle.Bottom;
            Parent?.Controls.Add(registrationPanel);

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



        private void inititalPlaceholders()
        {
            if (string.IsNullOrEmpty(name_textbox.Text))
            {
                customStyles.SetPlaceholderText(name_textbox, "Username");
            }
            if (string.IsNullOrEmpty(password_textbox.Text))
            {
                customStyles.SetPlaceholderText(password_textbox, "Password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Parent.Controls.Add(new UI.Main.Features.ForgetPanel());
        }
    }

}

