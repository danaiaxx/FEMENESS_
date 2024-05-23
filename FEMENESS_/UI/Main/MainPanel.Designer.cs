namespace FEMENESS_.UI.Main
{
    partial class MainPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            navigation = new Panel();
            menu = new Panel();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            home_button = new FontAwesome.Sharp.IconButton();
            logo_image = new PictureBox();
            center_panel = new Panel();
            navigation.SuspendLayout();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_image).BeginInit();
            SuspendLayout();
            // 
            // navigation
            // 
            navigation.Controls.Add(menu);
            navigation.Controls.Add(logo_image);
            navigation.Dock = DockStyle.Top;
            navigation.ForeColor = Color.FromArgb(135, 125, 113);
            navigation.Location = new Point(0, 0);
            navigation.Name = "navigation";
            navigation.Padding = new Padding(30, 15, 30, 15);
            navigation.Size = new Size(1000, 68);
            navigation.TabIndex = 0;
            // 
            // menu
            // 
            menu.Controls.Add(iconButton6);
            menu.Controls.Add(iconButton3);
            menu.Controls.Add(iconButton2);
            menu.Controls.Add(iconButton1);
            menu.Controls.Add(home_button);
            menu.Dock = DockStyle.Fill;
            menu.Location = new Point(184, 15);
            menu.Name = "menu";
            menu.Size = new Size(786, 38);
            menu.TabIndex = 3;
            // 
            // iconButton6
            // 
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            iconButton6.IconColor = Color.FromArgb(135, 125, 113);
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 30;
            iconButton6.Location = new Point(729, -14);
            iconButton6.Margin = new Padding(0);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(57, 58);
            iconButton6.TabIndex = 5;
            iconButton6.Text = "Logout";
            iconButton6.TextAlign = ContentAlignment.BottomCenter;
            iconButton6.UseVisualStyleBackColor = true;
            iconButton6.Click += iconButton6_Click;
            // 
            // iconButton3
            // 
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            iconButton3.IconColor = Color.FromArgb(135, 125, 113);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.Location = new Point(669, -14);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(57, 58);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "About";
            iconButton3.TextAlign = ContentAlignment.BottomCenter;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Folder;
            iconButton2.IconColor = Color.FromArgb(135, 125, 113);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(586, -13);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(70, 58);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "Insights";
            iconButton2.TextAlign = ContentAlignment.BottomCenter;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            iconButton1.IconColor = Color.FromArgb(135, 125, 113);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(519, -14);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(57, 58);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Shop";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // home_button
            // 
            home_button.FlatAppearance.BorderSize = 0;
            home_button.FlatStyle = FlatStyle.Flat;
            home_button.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home_button.ForeColor = Color.FromArgb(135, 125, 113);
            home_button.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            home_button.IconColor = Color.FromArgb(135, 125, 113);
            home_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            home_button.IconSize = 30;
            home_button.Location = new Point(457, -15);
            home_button.Name = "home_button";
            home_button.Size = new Size(52, 60);
            home_button.TabIndex = 0;
            home_button.Text = "Home";
            home_button.TextAlign = ContentAlignment.BottomCenter;
            home_button.UseVisualStyleBackColor = true;
            home_button.Click += home_button_Click;
            // 
            // logo_image
            // 
            logo_image.BackgroundImage = (Image)resources.GetObject("logo_image.BackgroundImage");
            logo_image.BackgroundImageLayout = ImageLayout.Zoom;
            logo_image.Dock = DockStyle.Left;
            logo_image.Location = new Point(30, 15);
            logo_image.Name = "logo_image";
            logo_image.Padding = new Padding(10);
            logo_image.Size = new Size(154, 38);
            logo_image.TabIndex = 2;
            logo_image.TabStop = false;
            // 
            // center_panel
            // 
            center_panel.BackColor = Color.FromArgb(250, 243, 233);
            center_panel.BackgroundImageLayout = ImageLayout.Stretch;
            center_panel.Dock = DockStyle.Fill;
            center_panel.Location = new Point(0, 68);
            center_panel.Name = "center_panel";
            center_panel.Size = new Size(1000, 482);
            center_panel.TabIndex = 0;
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 233);
            Controls.Add(center_panel);
            Controls.Add(navigation);
            ForeColor = Color.FromArgb(135, 125, 113);
            Name = "MainPanel";
            Size = new Size(1000, 550);
            navigation.ResumeLayout(false);
            menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo_image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navigation;
        private Panel menu;
        private PictureBox logo_image;
        private FontAwesome.Sharp.IconButton home_button;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel center_panel;
        private Features.HomePanel homePanel1;
    }
}
