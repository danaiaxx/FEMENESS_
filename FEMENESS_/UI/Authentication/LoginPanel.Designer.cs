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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            forgot_button = new Button();
            login_button = new Button();
            panel4 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            login_panel.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // login_panel
            // 
            login_panel.BackColor = Color.FromArgb(250, 243, 233);
            login_panel.BackgroundImage = (Image)resources.GetObject("login_panel.BackgroundImage");
            login_panel.BackgroundImageLayout = ImageLayout.Stretch;
            login_panel.Controls.Add(panel1);
            login_panel.Dock = DockStyle.Bottom;
            login_panel.Location = new Point(0, 150);
            login_panel.Name = "login_panel";
            login_panel.Size = new Size(1000, 400);
            login_panel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(280, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 286);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(forgot_button);
            flowLayoutPanel1.Controls.Add(login_button);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Location = new Point(0, 57);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(451, 226);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 56);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(448, 56);
            panel3.TabIndex = 1;
            // 
            // forgot_button
            // 
            forgot_button.FlatStyle = FlatStyle.Flat;
            forgot_button.Location = new Point(3, 127);
            forgot_button.Name = "forgot_button";
            forgot_button.Size = new Size(112, 34);
            forgot_button.TabIndex = 2;
            forgot_button.Text = "Forgot Password?";
            forgot_button.UseVisualStyleBackColor = true;
            // 
            // login_button
            // 
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Location = new Point(3, 167);
            login_button.Name = "login_button";
            login_button.Size = new Size(449, 23);
            login_button.TabIndex = 3;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 196);
            panel4.Name = "panel4";
            panel4.Size = new Size(448, 41);
            panel4.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(253, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "signup";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 10);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 0;
            label2.Text = "Don't have an account?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 19);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(275, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 46);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LoginPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 233);
            Controls.Add(pictureBox1);
            Controls.Add(login_panel);
            Name = "LoginPanel";
            Size = new Size(1000, 550);
            login_panel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel login_panel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Button forgot_button;
        private Button login_button;
        private Panel panel4;
        private Button button1;
        private Label label2;
    }
}
