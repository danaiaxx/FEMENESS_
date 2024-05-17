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
    public partial class ConfimationDialog : UserControl
    {
        public event EventHandler<EventArgs> YesClicked;
        public event EventHandler<EventArgs> NoClicked;

        public ConfimationDialog()
        {
            InitializeComponent();
        }

        public void SetMessage(string message)
        {
            lblMessage.Text = message;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            YesClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            NoClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
