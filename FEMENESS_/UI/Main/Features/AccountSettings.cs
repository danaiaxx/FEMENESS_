using FEMENESS_.Backend;
using FEMENESS_.UI.Authentication;
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
    public partial class AccountSettings : UserControl
    {

        User loggedUser;
        LoginPanel loginPanel;
        BackendService backendService;

        public AccountSettings(User loggedUser, LoginPanel loginPanel, BackendService backendService)
        {

            InitializeComponent();
            this.backendService = backendService;

            textBox1.Text = loggedUser.Username;
            textBox2.Text = loggedUser.Email;
            textBox3.Text = loggedUser.PhoneNumber;
            textBox4.Text = loggedUser.Address;
            this.backendService = backendService;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button1.Visible = false;
            button2.Visible = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

            backendService.UpdateUserDetails(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }
    }
}
