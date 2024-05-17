using FEMENESS_.Backend;
using FEMENESS_.UI.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEMENESS_.UI.Main.Features
{
    public partial class About : UserControl
    {
        private BackendService backendService;
        public About(BackendService backendService)
        {
            this.backendService = backendService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            HomePanel homePanel = new UI.Main.Features.HomePanel(backendService);
            homePanel.Dock = DockStyle.Bottom; 
            Parent.Controls.Add(homePanel); 

            Parent.Controls.Remove(this);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string toEmail = "support@femeness.ico";
            string subject = Uri.EscapeDataString("Test Email Subject");
            string body = Uri.EscapeDataString("This is the body of the test email.");

            string mailtoUrl = $"https://mail.google.com/mail/?view=cm&fs=1&to={toEmail}&su={subject}&body={body}";

            Process.Start(new ProcessStartInfo(mailtoUrl) { UseShellExecute = true });

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com";
            gotoLink(url);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com";
            gotoLink(url);
        }

        private void gotoLink(string link) { 
            
            Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });

        }
    }
}
