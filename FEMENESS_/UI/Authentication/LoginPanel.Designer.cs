namespace FEMENESS_.UI.Authentication
{
    partial class LoginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            login_panel = new Panel();
            Form = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            loginButton = new Button();
            button1 = new Button();
            passwordTextPanel = new Panel();
            emailTextPanel = new Panel();
            label1 = new Label();
            logo_image = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            login_panel.SuspendLayout();
            Form.SuspendLayout();
            panel1.SuspendLayout();
            passwordTextPanel.SuspendLayout();
            emailTextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_image).BeginInit();
            SuspendLayout();
            // 
            // login_panel
            // 
            login_panel.BackColor = Color.FromArgb(250, 243, 233);
            login_panel.BackgroundImage = (Image)resources.GetObject("login_panel.BackgroundImage");
            login_panel.BackgroundImageLayout = ImageLayout.Stretch;
            login_panel.Controls.Add(Form);
            login_panel.Dock = DockStyle.Bottom;
            login_panel.Location = new Point(0, 147);
            login_panel.Name = "login_panel";
            login_panel.Padding = new Padding(0, 50, 0, 50);
            login_panel.Size = new Size(1000, 403);
            login_panel.TabIndex = 0;
            // 
            // Form
            // 
            Form.BackColor = Color.FromArgb(241, 223, 211);
            Form.Controls.Add(panel1);
            Form.Controls.Add(label1);
            Form.Location = new Point(299, 53);
            Form.Name = "Form";
            Form.Size = new Size(420, 297);
            Form.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(passwordTextPanel);
            panel1.Controls.Add(emailTextPanel);
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 217);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(6, 190);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 24);
            panel2.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(245, 245, 245);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(3, 143);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(411, 44);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(305, 103);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 2;
            button1.Text = "Forgot password?";
            button1.UseVisualStyleBackColor = true;
            // 
            // passwordTextPanel
            // 
            passwordTextPanel.BackColor = Color.FromArgb(245, 245, 245);
            passwordTextPanel.Controls.Add(textBox2);
            passwordTextPanel.Location = new Point(4, 53);
            passwordTextPanel.Name = "passwordTextPanel";
            passwordTextPanel.Padding = new Padding(10);
            passwordTextPanel.Size = new Size(410, 44);
            passwordTextPanel.TabIndex = 1;
            // 
            // emailTextPanel
            // 
            emailTextPanel.BackColor = Color.FromArgb(245, 245, 245);
            emailTextPanel.Controls.Add(textBox1);
            emailTextPanel.Location = new Point(5, 3);
            emailTextPanel.Name = "emailTextPanel";
            emailTextPanel.Padding = new Padding(5, 10, 5, 10);
            emailTextPanel.Size = new Size(409, 44);
            emailTextPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 10);
            label1.Name = "label1";
            label1.Size = new Size(195, 31);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // logo_image
            // 
            logo_image.BackgroundImage = (Image)resources.GetObject("logo_image.BackgroundImage");
            logo_image.BackgroundImageLayout = ImageLayout.Zoom;
            logo_image.Location = new Point(275, 50);
            logo_image.Name = "logo_image";
            logo_image.Size = new Size(454, 46);
            logo_image.TabIndex = 1;
            logo_image.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(11, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(389, 16);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(11, 14);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(389, 16);
            textBox2.TabIndex = 1;
            // 
            // LoginPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 233);
            Controls.Add(logo_image);
            Controls.Add(login_panel);
            Name = "LoginPanel";
            Size = new Size(1000, 550);
            login_panel.ResumeLayout(false);
            Form.ResumeLayout(false);
            Form.PerformLayout();
            panel1.ResumeLayout(false);
            passwordTextPanel.ResumeLayout(false);
            passwordTextPanel.PerformLayout();
            emailTextPanel.ResumeLayout(false);
            emailTextPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel login_panel;
        private PictureBox logo_image;
        private Panel Form;
        private Label label1;
        private Panel panel1;
        private Panel passwordTextPanel;
        private Panel emailTextPanel;
        private Panel panel2;
        private Button loginButton;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
