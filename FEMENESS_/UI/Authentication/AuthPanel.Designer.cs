using System.Drawing;
using System.Drawing.Drawing2D;

namespace FEMENESS_.UI.Authentication
{
    partial class AuthPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthPanel));
            AuthButtonPanel = new Panel();
            buttonWrapper = new Panel();
            RegisterButton = new Button();
            LoginButton = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            AuthButtonPanel.SuspendLayout();
            buttonWrapper.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AuthButtonPanel
            // 
            AuthButtonPanel.BackColor = Color.Transparent;
            AuthButtonPanel.BackgroundImage = (Image)resources.GetObject("AuthButtonPanel.BackgroundImage");
            AuthButtonPanel.BackgroundImageLayout = ImageLayout.Stretch;
            AuthButtonPanel.Controls.Add(buttonWrapper);
            AuthButtonPanel.Dock = DockStyle.Bottom;
            AuthButtonPanel.Location = new Point(0, 330);
            AuthButtonPanel.Name = "AuthButtonPanel";
            AuthButtonPanel.Size = new Size(1000, 220);
            AuthButtonPanel.TabIndex = 0;
            // 
            // buttonWrapper
            // 
            buttonWrapper.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonWrapper.Controls.Add(RegisterButton);
            buttonWrapper.Controls.Add(LoginButton);
            buttonWrapper.Location = new Point(275, 55);
            buttonWrapper.Name = "buttonWrapper";
            buttonWrapper.Size = new Size(450, 110);
            buttonWrapper.TabIndex = 0;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.FromArgb(196, 153, 131);
            RegisterButton.Dock = DockStyle.Bottom;
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold);
            RegisterButton.ForeColor = Color.FromArgb(245, 245, 245);
            RegisterButton.Location = new Point(0, 58);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(450, 52);
            RegisterButton.TabIndex = 1;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(245, 245, 245);
            LoginButton.Dock = DockStyle.Top;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold);
            LoginButton.ForeColor = Color.FromArgb(196, 153, 131);
            LoginButton.Location = new Point(0, 0);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(450, 52);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(271, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 145);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 12F);
            label2.ForeColor = Color.FromArgb(135, 125, 113);
            label2.Location = new Point(160, 111);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 2;
            label2.Text = "Our Commitment";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 12F);
            label1.ForeColor = Color.FromArgb(135, 125, 113);
            label1.Location = new Point(135, 86);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 1;
            label1.Text = "Your Sexual Well-Being,";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 46);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AuthPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 233);
            Controls.Add(panel1);
            Controls.Add(AuthButtonPanel);
            Name = "AuthPanel";
            Size = new Size(1000, 550);
            AuthButtonPanel.ResumeLayout(false);
            buttonWrapper.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel AuthButtonPanel;
        private Panel buttonWrapper;
        private Button RegisterButton;
        private Button LoginButton;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
