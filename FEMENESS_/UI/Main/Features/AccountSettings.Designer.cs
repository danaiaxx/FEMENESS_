namespace FEMENESS_.UI.Main.Features
{
    partial class AccountSettings
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
            panel1 = new Panel();
            panel6 = new Panel();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            textBox3 = new TextBox();
            panel4 = new Panel();
            textBox2 = new TextBox();
            panel3 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(80, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 340);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(button3);
            panel6.Controls.Add(button1);
            panel6.Controls.Add(button2);
            panel6.Location = new Point(-1, 292);
            panel6.Name = "panel6";
            panel6.Size = new Size(517, 48);
            panel6.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(81, 80, 80);
            button3.Location = new Point(267, 0);
            button3.Name = "button3";
            button3.Size = new Size(250, 48);
            button3.TabIndex = 2;
            button3.Text = "Edit Account";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(81, 80, 80);
            button1.Location = new Point(1, 0);
            button1.Name = "button1";
            button1.Size = new Size(250, 48);
            button1.TabIndex = 0;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(81, 80, 80);
            button2.Location = new Point(267, 0);
            button2.Name = "button2";
            button2.Size = new Size(250, 48);
            button2.TabIndex = 1;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft PhagsPa", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(81, 80, 80);
            label5.Location = new Point(125, 19);
            label5.Name = "label5";
            label5.Size = new Size(254, 32);
            label5.TabIndex = 9;
            label5.Text = "Account Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(241, 223, 211);
            label4.Font = new Font("Microsoft PhagsPa", 11.25F);
            label4.ForeColor = Color.FromArgb(81, 80, 80);
            label4.Location = new Point(1, 198);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 8;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(241, 223, 211);
            label3.Font = new Font("Microsoft PhagsPa", 11.25F);
            label3.ForeColor = Color.FromArgb(81, 80, 80);
            label3.Location = new Point(268, 128);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 7;
            label3.Text = "Phone No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(241, 223, 211);
            label2.Font = new Font("Microsoft PhagsPa", 11.25F);
            label2.ForeColor = Color.FromArgb(81, 80, 80);
            label2.Location = new Point(1, 127);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(241, 223, 211);
            label1.Font = new Font("Microsoft PhagsPa", 11.25F);
            label1.ForeColor = Color.FromArgb(81, 80, 80);
            label1.Location = new Point(1, 55);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Controls.Add(textBox3);
            panel5.Location = new Point(267, 148);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10);
            panel5.Size = new Size(250, 44);
            panel5.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Enabled = false;
            textBox3.Location = new Point(10, 8);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 16);
            textBox3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(textBox2);
            panel4.Location = new Point(0, 148);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(250, 44);
            panel4.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Location = new Point(10, 8);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 16);
            textBox2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(0, 77);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(517, 44);
            panel3.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Location = new Point(10, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(497, 16);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(textBox4);
            panel2.Location = new Point(0, 218);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(517, 44);
            panel2.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.WhiteSmoke;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Enabled = false;
            textBox4.Location = new Point(10, 8);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(497, 16);
            textBox4.TabIndex = 1;
            // 
            // AccountSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 223, 211);
            Controls.Add(panel1);
            Name = "AccountSettings";
            Size = new Size(687, 513);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private Panel panel6;
        private Button button3;
    }
}
