namespace FEMENESS_.UI.Main.Features
{
    partial class InsightPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsightPanel));
            panel1 = new Panel();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 40, 0, 40);
            panel1.Size = new Size(298, 482);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(196, 153, 131);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 396);
            panel2.TabIndex = 0;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft PhagsPa", 12F);
            button5.ForeColor = Color.WhiteSmoke;
            button5.Location = new Point(0, 160);
            button5.Name = "button5";
            button5.Size = new Size(298, 40);
            button5.TabIndex = 4;
            button5.Text = "Social and Economic Concerns";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft PhagsPa", 12F);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(0, 120);
            button4.Name = "button4";
            button4.Size = new Size(298, 40);
            button4.TabIndex = 3;
            button4.Text = "Mental and Emotional Well-Being";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft PhagsPa", 12F);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(0, 80);
            button3.Name = "button3";
            button3.Size = new Size(298, 40);
            button3.TabIndex = 2;
            button3.Text = "Unintended Pregnancies";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft PhagsPa", 12F);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(0, 40);
            button2.Name = "button2";
            button2.Size = new Size(298, 40);
            button2.TabIndex = 1;
            button2.Text = "Sexually Transmitted Infections (STI)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(241, 223, 211);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft PhagsPa", 12F);
            button1.ForeColor = Color.FromArgb(81, 80, 80);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(298, 40);
            button1.TabIndex = 0;
            button1.Text = "Why Sexual Health Matters?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // InsightPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 223, 211);
            Controls.Add(panel1);
            Name = "InsightPanel";
            Size = new Size(1000, 482);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
