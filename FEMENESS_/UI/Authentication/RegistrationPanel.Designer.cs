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
            login_panel.Location = new Point(0, 196);
            login_panel.Margin = new Padding(3, 4, 3, 4);
            login_panel.Name = "login_panel";
            login_panel.Padding = new Padding(0, 33, 0, 33);
            login_panel.Size = new Size(1143, 537);
            login_panel.TabIndex = 0;
            // 
            // Form
            // 
            Form.BackColor = Color.FromArgb(241, 223, 211);
            Form.Controls.Add(errorLabel);
            Form.Controls.Add(panel1);
            Form.Controls.Add(label1);
            Form.Location = new Point(342, 37);
            Form.Margin = new Padding(3, 4, 3, 4);
            Form.Name = "Form";
            Form.Size = new Size(480, 463);
            Form.TabIndex = 0;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.IndianRed;
            errorLabel.Location = new Point(10, 55);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 22);
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
            panel1.Location = new Point(0, 80);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 379);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(245, 245, 245);
            panel4.Controls.Add(confirmPassword_textbox);
            panel4.Location = new Point(5, 201);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(11, 13, 11, 13);
            panel4.Size = new Size(469, 59);
            panel4.TabIndex = 2;
            // 
            // confirmPassword_textbox
            // 
            confirmPassword_textbox.BackColor = Color.WhiteSmoke;
            confirmPassword_textbox.BorderStyle = BorderStyle.None;
            confirmPassword_textbox.Font = new Font("Microsoft PhagsPa", 11.25F);
            confirmPassword_textbox.Location = new Point(11, 17);
            confirmPassword_textbox.Margin = new Padding(3, 4, 3, 4);
            confirmPassword_textbox.Name = "confirmPassword_textbox";
            confirmPassword_textbox.Size = new Size(445, 24);
            confirmPassword_textbox.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(245, 245, 245);
            panel3.Controls.Add(password_textbox);
            panel3.Location = new Point(5, 135);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(11, 13, 11, 13);
            panel3.Size = new Size(469, 59);
            panel3.TabIndex = 5;
            // 
            // password_textbox
            // 
            password_textbox.BackColor = Color.WhiteSmoke;
            password_textbox.BorderStyle = BorderStyle.None;
            password_textbox.Font = new Font("Microsoft PhagsPa", 11.25F);
            password_textbox.Location = new Point(11, 19);
            password_textbox.Margin = new Padding(3, 4, 3, 4);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(445, 24);
            password_textbox.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(redirectToLogin);
            panel2.Location = new Point(7, 344);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(466, 32);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 11.25F);
            label2.ForeColor = Color.FromArgb(81, 80, 80);
            label2.Location = new Point(61, 5);
            label2.Name = "label2";
            label2.Size = new Size(226, 24);
            label2.TabIndex = 0;
            label2.Text = "Already have an account?";
            // 
            // redirectToLogin
            // 
            redirectToLogin.FlatAppearance.BorderSize = 0;
            redirectToLogin.FlatStyle = FlatStyle.Flat;
            redirectToLogin.Font = new Font("Microsoft PhagsPa", 11.25F);
            redirectToLogin.Location = new Point(298, -1);
            redirectToLogin.Margin = new Padding(3, 4, 3, 4);
            redirectToLogin.Name = "redirectToLogin";
            redirectToLogin.Size = new Size(66, 39);
            redirectToLogin.TabIndex = 1;
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
            registerButton.Location = new Point(3, 277);
            registerButton.Margin = new Padding(3, 4, 3, 4);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(470, 59);
            registerButton.TabIndex = 3;
            registerButton.Text = "Sign up";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // passwordTextPanel
            // 
            passwordTextPanel.BackColor = Color.FromArgb(245, 245, 245);
            passwordTextPanel.Controls.Add(email_textbox);
            passwordTextPanel.Location = new Point(5, 68);
            passwordTextPanel.Margin = new Padding(3, 4, 3, 4);
            passwordTextPanel.Name = "passwordTextPanel";
            passwordTextPanel.Padding = new Padding(11, 13, 11, 13);
            passwordTextPanel.Size = new Size(469, 59);
            passwordTextPanel.TabIndex = 1;
            // 
            // email_textbox
            // 
            email_textbox.BackColor = Color.WhiteSmoke;
            email_textbox.BorderStyle = BorderStyle.None;
            email_textbox.Font = new Font("Microsoft PhagsPa", 11.25F);
            email_textbox.Location = new Point(11, 17);
            email_textbox.Margin = new Padding(3, 4, 3, 4);
            email_textbox.Name = "email_textbox";
            email_textbox.Size = new Size(445, 24);
            email_textbox.TabIndex = 1;
            // 
            // emailTextPanel
            // 
            emailTextPanel.BackColor = Color.FromArgb(245, 245, 245);
            emailTextPanel.Controls.Add(name_textbox);
            emailTextPanel.Location = new Point(6, 3);
            emailTextPanel.Margin = new Padding(3, 4, 3, 4);
            emailTextPanel.Name = "emailTextPanel";
            emailTextPanel.Padding = new Padding(11, 13, 11, 13);
            emailTextPanel.Size = new Size(467, 59);
            emailTextPanel.TabIndex = 0;
            // 
            // name_textbox
            // 
            name_textbox.BackColor = Color.WhiteSmoke;
            name_textbox.BorderStyle = BorderStyle.None;
            name_textbox.Font = new Font("Microsoft PhagsPa", 11.25F);
            name_textbox.Location = new Point(11, 17);
            name_textbox.Margin = new Padding(3, 4, 3, 4);
            name_textbox.Name = "name_textbox";
            name_textbox.Size = new Size(445, 24);
            name_textbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(81, 80, 80);
            label1.Location = new Point(131, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 39);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // logo_image
            // 
            logo_image.BackgroundImage = (Image)resources.GetObject("logo_image.BackgroundImage");
            logo_image.BackgroundImageLayout = ImageLayout.Zoom;
            logo_image.Location = new Point(320, 60);
            logo_image.Margin = new Padding(3, 4, 3, 4);
            logo_image.Name = "logo_image";
            logo_image.Size = new Size(519, 61);
            logo_image.TabIndex = 1;
            logo_image.TabStop = false;
            // 
            // RegistrationPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 233);
            Controls.Add(logo_image);
            Controls.Add(login_panel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrationPanel";
            Size = new Size(1143, 733);
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
