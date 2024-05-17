using FEMENESS_.Backend;
using FEMENESS_.UI.Customization;
using FEMENESS_.UI.Main;
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
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = name_textbox.Text.Trim();
            string password = password_textbox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                errorLabel.Text = "Please fill in all fields.";
                return;
            }

            User loggedUser = backendService.Login(username, password);

            if (loggedUser != null)
            {
                MessageBox.Show("Successfully logged in!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                errorLabel.Text = "Invalid username or password.";
            }
        }



        private void redirectToRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            RegistrationPanel registrationPanel = new UI.Authentication.RegistrationPanel(backendService);
            registrationPanel.Dock = DockStyle.Bottom;
            Parent?.Controls.Add(registrationPanel);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form.Visible = false;
            ForgetPanel forgetPanel = new UI.Main.Features.ForgetPanel(backendService, Form);
            forgetPanel.Location = new Point(299, 53);
            login_panel.Controls.Add(forgetPanel);
        }
    }

}

