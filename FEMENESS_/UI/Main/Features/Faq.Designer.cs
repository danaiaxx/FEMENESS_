namespace FEMENESS_.UI.Main.Features
{
    partial class Faq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faq));
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            button2 = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Microsoft PhagsPa", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(135, 125, 113);
            label1.Location = new Point(82, 50);
            label1.Name = "label1";
            label1.Size = new Size(454, 36);
            label1.TabIndex = 3;
            label1.Text = "How does a woman get pregnant?";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Microsoft PhagsPa", 11F);
            textBox1.Location = new Point(3, 48);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1069, 93);
            textBox1.TabIndex = 4;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // button1
            // 
            button1.Location = new Point(0, 3);
            button1.Name = "button1";
            button1.Size = new Size(1072, 38);
            button1.TabIndex = 5;
            button1.Text = "How does a woman get pregnant?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Location = new Point(26, 124);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1078, 456);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1075, 45);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(1075, 52);
            panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Microsoft PhagsPa", 11F);
            textBox2.Location = new Point(3, 58);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(1069, 93);
            textBox2.TabIndex = 4;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // button2
            // 
            button2.Location = new Point(0, 3);
            button2.Name = "button2";
            button2.Size = new Size(1072, 48);
            button2.TabIndex = 5;
            button2.Text = "How does a woman get pregnant?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Faq
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 223, 211);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "Faq";
            Size = new Size(1143, 733);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox2;
        private Button button2;
    }
}
