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
            iconButton5 = new FontAwesome.Sharp.IconButton();
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
            navigation.Margin = new Padding(3, 4, 3, 4);
            navigation.Name = "navigation";
            navigation.Padding = new Padding(34, 20, 34, 20);
            navigation.Size = new Size(1143, 91);
            navigation.TabIndex = 0;
            // 
            // menu
            // 
            menu.Controls.Add(iconButton6);
            menu.Controls.Add(iconButton5);
            menu.Controls.Add(iconButton3);
            menu.Controls.Add(iconButton2);
            menu.Controls.Add(iconButton1);
            menu.Controls.Add(home_button);
            menu.Dock = DockStyle.Fill;
            menu.Location = new Point(210, 20);
            menu.Margin = new Padding(3, 4, 3, 4);
            menu.Name = "menu";
            menu.Size = new Size(899, 51);
            menu.TabIndex = 3;
            // 
            // iconButton6
            // 
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            iconButton6.IconColor = Color.FromArgb(135, 125, 113);
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 30;
            iconButton6.Location = new Point(833, -19);
            iconButton6.Margin = new Padding(0);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(65, 77);
            iconButton6.TabIndex = 5;
            iconButton6.Text = "Cart";
            iconButton6.TextAlign = ContentAlignment.BottomCenter;
            iconButton6.UseVisualStyleBackColor = true;
            iconButton6.Click += iconButton6_Click;
            // 
            // iconButton5
            // 
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton5.IconColor = Color.FromArgb(135, 125, 113);
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 30;
            iconButton5.Location = new Point(750, -20);
            iconButton5.Margin = new Padding(3, 4, 3, 4);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(65, 77);
            iconButton5.TabIndex = 4;
            iconButton5.Text = "Profile";
            iconButton5.TextAlign = ContentAlignment.BottomCenter;
            iconButton5.UseVisualStyleBackColor = true;
            iconButton5.Click += iconButton5_Click;
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
            iconButton3.Location = new Point(666, -20);
            iconButton3.Margin = new Padding(3, 4, 3, 4);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(65, 77);
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
            iconButton2.Location = new Point(569, -21);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(80, 77);
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
            iconButton1.Location = new Point(495, -19);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(65, 77);
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
            home_button.Location = new Point(417, -23);
            home_button.Margin = new Padding(3, 4, 3, 4);
            home_button.Name = "home_button";
            home_button.Size = new Size(59, 80);
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
            logo_image.Location = new Point(34, 20);
            logo_image.Margin = new Padding(3, 4, 3, 4);
            logo_image.Name = "logo_image";
            logo_image.Padding = new Padding(11, 13, 11, 13);
            logo_image.Size = new Size(176, 51);
            logo_image.TabIndex = 2;
            logo_image.TabStop = false;
            // 
            // center_panel
            // 
            center_panel.BackColor = Color.FromArgb(250, 243, 233);
            center_panel.BackgroundImageLayout = ImageLayout.Stretch;
            center_panel.Dock = DockStyle.Fill;
            center_panel.Location = new Point(0, 91);
            center_panel.Margin = new Padding(3, 4, 3, 4);
            center_panel.Name = "center_panel";
            center_panel.Size = new Size(1143, 642);
            center_panel.TabIndex = 0;
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 233);
            Controls.Add(center_panel);
            Controls.Add(navigation);
            ForeColor = Color.FromArgb(135, 125, 113);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainPanel";
            Size = new Size(1143, 733);
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
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel center_panel;
    }
}
