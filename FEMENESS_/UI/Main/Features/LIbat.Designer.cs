﻿namespace FEMENESS_.UI.Main.Features
{
    partial class LIbat
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
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(46, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(587, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "ok raka?";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LIbat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Name = "LIbat";
            Size = new Size(671, 316);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
    }
}
