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

namespace FEMENESS_.UI.Main.Features
{
    public partial class Profile : UserControl
    {
        private LoginPanel loginPanel;
        private User loggedUser;
        private BackendService backendService;


        public Profile(LoginPanel loginPanel, User loggedUser, BackendService backendService)
        {
            this.loggedUser = loggedUser;
            this.loginPanel = loginPanel;
            this.backendService = backendService;
            InitializeComponent();


            logout_button.MouseEnter += Button_MouseEnter;
            logout_button.MouseLeave += Button_MouseLeave;

        }

        private void logout_button_Click(object sender, EventArgs e)
        {   

            Control mainPanel = Parent?.Parent?.Parent.Controls["MainPanel"];
            loginPanel.Visible = true;
            Parent?.Parent?.Parent?.Controls.Remove(mainPanel);
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.ForeColor = Color.FromArgb(81, 80, 80);
            button.BackColor = Color.FromArgb(241, 223, 211); 

        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Transparent;
            button.ForeColor = Color.FromArgb(245, 245, 245);


        }
    }
}
