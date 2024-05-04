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
            AuthButtonPanel = new Panel();
            buttonWrapper = new Panel();
            RegisterButton = new Button();
            LoginButton = new Button();
            AuthButtonPanel.SuspendLayout();
            buttonWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // AuthButtonPanel
            // 
            AuthButtonPanel.BackColor = Color.FromArgb(241, 223, 211);
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
            RegisterButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            LoginButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.FromArgb(196, 153, 131);
            LoginButton.Location = new Point(0, 0);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(450, 52);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // AuthPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 233);
            Controls.Add(AuthButtonPanel);
            Name = "AuthPanel";
            Size = new Size(1000, 550);
            AuthButtonPanel.ResumeLayout(false);
            buttonWrapper.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel AuthButtonPanel;
        private Panel buttonWrapper;
        private Button RegisterButton;
        private Button LoginButton;
    }
}
