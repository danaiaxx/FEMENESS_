
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
            label2 = new Label();
            redirectToRegister = new Button();
            loginButton = new Button();
            button1 = new Button();
            passwordTextPanel = new Panel();
            password_textbox = new TextBox();
            emailTextPanel = new Panel();
            name_textbox = new TextBox();
            label1 = new Label();
            logo_image = new PictureBox();
            login_panel.SuspendLayout();
            Form.SuspendLayout();
            panel1.SuspendLayout();
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
            login_panel.Padding = new Padding(0, 67, 0, 67);
            login_panel.Size = new Size(1143, 537);
            login_panel.TabIndex = 1;
            // 
            // Form
            // 
            Form.BackColor = Color.FromArgb(241, 223, 211);
            Form.Controls.Add(panel1);
            Form.Controls.Add(label1);
            Form.Location = new Point(342, 71);
            Form.Margin = new Padding(3, 4, 3, 4);
            Form.Name = "Form";
            Form.Size = new Size(480, 396);
            Form.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(passwordTextPanel);
            panel1.Controls.Add(emailTextPanel);
            panel1.Location = new Point(0, 107);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 295);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(redirectToRegister);
            panel2.Location = new Point(5, 253);
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
            label2.Location = new Point(82, 4);
            label2.Name = "label2";
            label2.Size = new Size(203, 24);
            label2.TabIndex = 0;
            label2.Text = "Dont have an account?";
            // 
            // redirectToRegister
            // 
            redirectToRegister.FlatAppearance.BorderSize = 0;
            redirectToRegister.FlatStyle = FlatStyle.Flat;
            redirectToRegister.Font = new Font("Microsoft PhagsPa", 11.25F);
            redirectToRegister.Location = new Point(290, -3);
            redirectToRegister.Margin = new Padding(3, 4, 3, 4);
            redirectToRegister.Name = "redirectToRegister";
            redirectToRegister.Size = new Size(98, 35);
            redirectToRegister.TabIndex = 1;
            redirectToRegister.Text = "Sign up";
            redirectToRegister.UseVisualStyleBackColor = true;
            redirectToRegister.Click += redirectToRegister_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(196, 153, 131);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.WhiteSmoke;
            loginButton.Location = new Point(3, 191);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(470, 59);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft PhagsPa", 11.25F);
            button1.ForeColor = Color.FromArgb(81, 80, 80);
            button1.Location = new Point(295, 131);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(177, 33);
            button1.TabIndex = 2;
            button1.Text = "Forgot password?";
            button1.UseVisualStyleBackColor = true;
            // 
            // passwordTextPanel
            // 
            passwordTextPanel.BackColor = Color.FromArgb(245, 245, 245);
            passwordTextPanel.Controls.Add(password_textbox);
            passwordTextPanel.Location = new Point(5, 71);
            passwordTextPanel.Margin = new Padding(3, 4, 3, 4);
            passwordTextPanel.Name = "passwordTextPanel";
            passwordTextPanel.Padding = new Padding(11, 13, 11, 13);
            passwordTextPanel.Size = new Size(469, 59);
            passwordTextPanel.TabIndex = 1;
            // 
            // password_textbox
            // 
            password_textbox.BackColor = Color.WhiteSmoke;
            password_textbox.BorderStyle = BorderStyle.None;
            password_textbox.Font = new Font("Microsoft PhagsPa", 11.25F);
            password_textbox.Location = new Point(13, 17);
            password_textbox.Margin = new Padding(3, 4, 3, 4);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(445, 24);
            password_textbox.TabIndex = 1;
            // 
            // emailTextPanel
            // 
            emailTextPanel.BackColor = Color.FromArgb(245, 245, 245);
            emailTextPanel.Controls.Add(name_textbox);
            emailTextPanel.Location = new Point(6, 4);
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
            name_textbox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(81, 80, 80);
            label1.Location = new Point(131, 13);
            label1.Name = "label1";
            label1.Size = new Size(231, 39);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back!";
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
            logo_image.TabIndex = 2;
            logo_image.TabStop = false;
            // 
            // LoginPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 233);
            Controls.Add(logo_image);
            Controls.Add(login_panel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginPanel";
            Size = new Size(1143, 733);
            login_panel.ResumeLayout(false);
            Form.ResumeLayout(false);
            Form.PerformLayout();
            panel1.ResumeLayout(false);
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
        private Panel Form;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Button redirectToRegister;
        private Button loginButton;
        private Button button1;
        private Panel passwordTextPanel;
        private TextBox password_textbox;
        private Panel emailTextPanel;
        private Label label1;
        private PictureBox logo_image;
        private TextBox name_textbox;
    }
}
