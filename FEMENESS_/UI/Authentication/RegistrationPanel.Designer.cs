namespace FEMENESS_.UI.Authentication
{
    partial class RegistrationPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationPanel));
            login_panel = new Panel();
            Form = new Panel();
            errorLabel = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            confirmPassword_textbox = new TextBox();
            panel3 = new Panel();
            password_textbox = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            redirectToLogin = new Button();
            registerButton = new Button();
            passwordTextPanel = new Panel();
            email_textbox = new TextBox();
            emailTextPanel = new Panel();
            name_textbox = new TextBox();
            label1 = new Label();
            logo_image = new PictureBox();
            login_panel.SuspendLayout();
            Form.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
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
            login_panel.Padding = new Padding(0, 25, 0, 25);
            login_panel.Size = new Size(1000, 403);
            login_panel.TabIndex = 0;
            // 
            // Form
            // 
            Form.BackColor = Color.FromArgb(241, 223, 211);
            Form.Controls.Add(errorLabel);
            Form.Controls.Add(panel1);
            Form.Controls.Add(label1);
            Form.Location = new Point(299, 28);
            Form.Name = "Form";
            Form.Size = new Size(420, 347);
            Form.TabIndex = 0;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.IndianRed;
            errorLabel.Location = new Point(9, 41);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 17);
            errorLabel.TabIndex = 2;
            errorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(registerButton);
            panel1.Controls.Add(passwordTextPanel);
            panel1.Controls.Add(emailTextPanel);
            panel1.Location = new Point(0, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 284);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(245, 245, 245);
            panel4.Controls.Add(confirmPassword_textbox);
            panel4.Location = new Point(4, 151);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(410, 44);
            panel4.TabIndex = 3;
            // 
            // confirmPassword_textbox
            // 
            confirmPassword_textbox.BackColor = Color.WhiteSmoke;
            confirmPassword_textbox.BorderStyle = BorderStyle.None;
            confirmPassword_textbox.Font = new Font("Microsoft PhagsPa", 11.25F);
            confirmPassword_textbox.Location = new Point(10, 13);
            confirmPassword_textbox.Name = "confirmPassword_textbox";
            confirmPassword_textbox.PlaceholderText = "Confirm Password";
            confirmPassword_textbox.Size = new Size(389, 20);
            confirmPassword_textbox.TabIndex = 1;
            confirmPassword_textbox.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(245, 245, 245);
            panel3.Controls.Add(password_textbox);
            panel3.Location = new Point(4, 101);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(410, 44);
            panel3.TabIndex = 2;
            // 
            // password_textbox
            // 
            password_textbox.BackColor = Color.WhiteSmoke;
            password_textbox.BorderStyle = BorderStyle.None;
            password_textbox.Font = new Font("Microsoft PhagsPa", 11.25F);
            password_textbox.Location = new Point(10, 14);
            password_textbox.Name = "password_textbox";
            password_textbox.PlaceholderText = "Password";
            password_textbox.Size = new Size(389, 20);
            password_textbox.TabIndex = 1;
            password_textbox.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(redirectToLogin);
            panel2.Location = new Point(6, 258);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 24);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 11.25F);
            label2.ForeColor = Color.FromArgb(81, 80, 80);
            label2.Location = new Point(85, 2);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 0;
            label2.Text = "Already have an account?";
            // 
            // redirectToLogin
            // 
            redirectToLogin.FlatAppearance.BorderSize = 0;
            redirectToLogin.FlatStyle = FlatStyle.Flat;
            redirectToLogin.Font = new Font("Microsoft PhagsPa", 11.25F);
            redirectToLogin.Location = new Point(265, -2);
            redirectToLogin.Name = "redirectToLogin";
            redirectToLogin.Size = new Size(58, 29);
            redirectToLogin.TabIndex = 5;
            redirectToLogin.Text = "Login";
            redirectToLogin.UseVisualStyleBackColor = true;
            redirectToLogin.Click += redirectToLogin_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(196, 153, 131);
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerButton.ForeColor = Color.WhiteSmoke;
            registerButton.Location = new Point(3, 208);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(411, 44);
            registerButton.TabIndex = 4;
            registerButton.Text = "Sign up";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // passwordTextPanel
            // 
            passwordTextPanel.BackColor = Color.FromArgb(245, 245, 245);
            passwordTextPanel.Controls.Add(email_textbox);
            passwordTextPanel.Location = new Point(4, 51);
            passwordTextPanel.Name = "passwordTextPanel";
            passwordTextPanel.Padding = new Padding(10);
            passwordTextPanel.Size = new Size(410, 44);
            passwordTextPanel.TabIndex = 1;
            // 
            // email_textbox
            // 
            email_textbox.BackColor = Color.WhiteSmoke;
            email_textbox.BorderStyle = BorderStyle.None;
            email_textbox.Font = new Font("Microsoft PhagsPa", 11.25F);
            email_textbox.Location = new Point(10, 13);
            email_textbox.Name = "email_textbox";
            email_textbox.PlaceholderText = "Email";
            email_textbox.Size = new Size(389, 20);
            email_textbox.TabIndex = 1;
            // 
            // emailTextPanel
            // 
            emailTextPanel.BackColor = Color.FromArgb(245, 245, 245);
            emailTextPanel.Controls.Add(name_textbox);
            emailTextPanel.Location = new Point(5, 2);
            emailTextPanel.Name = "emailTextPanel";
            emailTextPanel.Padding = new Padding(10);
            emailTextPanel.Size = new Size(409, 44);
            emailTextPanel.TabIndex = 0;
            // 
            // name_textbox
            // 
            name_textbox.BackColor = Color.WhiteSmoke;
            name_textbox.BorderStyle = BorderStyle.None;
            name_textbox.Font = new Font("Microsoft PhagsPa", 11.25F);
            name_textbox.Location = new Point(10, 13);
            name_textbox.Name = "name_textbox";
            name_textbox.PlaceholderText = "Username";
            name_textbox.Size = new Size(389, 20);
            name_textbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(81, 80, 80);
            label1.Location = new Point(115, 7);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // logo_image
            // 
            logo_image.BackgroundImage = (Image)resources.GetObject("logo_image.BackgroundImage");
            logo_image.BackgroundImageLayout = ImageLayout.Zoom;
            logo_image.Location = new Point(280, 45);
            logo_image.Name = "logo_image";
            logo_image.Size = new Size(454, 46);
            logo_image.TabIndex = 1;
            logo_image.TabStop = false;
            // 
            // RegistrationPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 233);
            Controls.Add(logo_image);
            Controls.Add(login_panel);
            Name = "RegistrationPanel";
            Size = new Size(1000, 550);
            login_panel.ResumeLayout(false);
            Form.ResumeLayout(false);
            Form.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Button registerButton;
        private TextBox name_textbox;
        private TextBox email_textbox;
        private Label label2;
        private Button redirectToLogin;
        private Panel panel3;
        private Panel panel4;
        private TextBox confirmPassword_textbox;
        private TextBox password_textbox;
        private Label errorLabel;
    }
}
