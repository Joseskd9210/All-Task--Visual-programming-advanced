﻿namespace Practica4
{
    partial class fHijo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbHijo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbHijo
            // 
            this.tbHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHijo.Location = new System.Drawing.Point(0, 0);
            this.tbHijo.Multiline = true;
            this.tbHijo.Name = "tbHijo";
            this.tbHijo.Size = new System.Drawing.Size(284, 262);
            this.tbHijo.TabIndex = 0;
            // 
            // fHijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tbHijo);
            this.Name = "fHijo";
            this.Text = "fHijo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbHijo;

    }
}