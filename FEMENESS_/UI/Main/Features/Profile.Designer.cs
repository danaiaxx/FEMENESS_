namespace FEMENESS_.UI.Main.Features
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            panel1 = new Panel();
            button1 = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            logout_button = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 223, 211);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(logout_button);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6, 7, 6, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 550);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft PhagsPa", 16.2F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(250, 243, 233);
            button1.Location = new Point(0, 209);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(346, 47);
            button1.TabIndex = 1;
            button1.Text = "Account Settings";
            button1.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(196, 153, 131);
            iconPictureBox1.ForeColor = Color.FromArgb(250, 243, 233);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.FromArgb(250, 243, 233);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 93;
            iconPictureBox1.Location = new Point(131, 70);
            iconPictureBox1.Margin = new Padding(6, 7, 6, 7);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(94, 93);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // logout_button
            // 
            logout_button.BackColor = Color.Transparent;
            logout_button.FlatAppearance.BorderSize = 0;
            logout_button.FlatStyle = FlatStyle.Flat;
            logout_button.Font = new Font("Microsoft PhagsPa", 16.2F, FontStyle.Bold);
            logout_button.ForeColor = Color.FromArgb(250, 243, 233);
            logout_button.Location = new Point(0, 266);
            logout_button.Margin = new Padding(6, 5, 6, 5);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(346, 47);
            logout_button.TabIndex = 2;
            logout_button.Text = "Log out";
            logout_button.UseVisualStyleBackColor = false;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 233);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Microsoft PhagsPa", 16.2F, FontStyle.Bold);
            ForeColor = Color.FromArgb(250, 243, 233);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Profile";
            Size = new Size(1000, 550);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Button button1;
        private Button logout_button;
    }
}
