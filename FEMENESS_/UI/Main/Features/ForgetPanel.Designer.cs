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
            button1 = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(2, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 51);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(2, 186);
            button1.Name = "button1";
            button1.Size = new Size(415, 48);
            button1.TabIndex = 1;
            button1.Text = "Search Account";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(15, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 16);
            textBox1.TabIndex = 0;
            // 
            // ForgetPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "ForgetPanel";
            Size = new Size(417, 237);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button button1;
    }
}
