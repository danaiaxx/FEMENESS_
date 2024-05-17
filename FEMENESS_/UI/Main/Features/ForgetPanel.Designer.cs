namespace FEMENESS_.UI.Main.Features
{
    partial class ForgetPanel
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
            textBox1 = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            textBox2 = new TextBox();
            panel3 = new Panel();
            textBox3 = new TextBox();
            label1 = new Label();
            errorLabel = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(1, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 46);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft PhagsPa", 11.25F);
            textBox1.Location = new Point(15, 15);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter email address";
            textBox1.Size = new Size(386, 20);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft PhagsPa", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(5, 249);
            button1.Name = "button1";
            button1.Size = new Size(415, 48);
            button1.TabIndex = 1;
            button1.Text = "Forgot Password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(2, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 46);
            panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft PhagsPa", 11.25F);
            textBox2.Location = new Point(15, 14);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = " New Password";
            textBox2.Size = new Size(386, 20);
            textBox2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(textBox3);
            panel3.Location = new Point(3, 182);
            panel3.Name = "panel3";
            panel3.Size = new Size(414, 46);
            panel3.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft PhagsPa", 11.25F);
            textBox3.Location = new Point(15, 14);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Confirm new password";
            textBox3.Size = new Size(386, 20);
            textBox3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 18F, FontStyle.Bold);
            label1.Location = new Point(106, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 3;
            label1.Text = "Forgot Password";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.DarkCyan;
            errorLabel.Location = new Point(4, 51);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(38, 16);
            errorLabel.TabIndex = 4;
            errorLabel.Text = "label2";
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.LeftLong;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(42, 38);
            iconButton1.TabIndex = 5;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // ForgetPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(iconButton1);
            Controls.Add(errorLabel);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "ForgetPanel";
            Size = new Size(420, 297);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button button1;
        private Panel panel2;
        private TextBox textBox2;
        private Panel panel3;
        private TextBox textBox3;
        private Label label1;
        private Label errorLabel;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
