﻿namespace Practica4
{
    partial class frmHijo
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
            this.txbDocumento = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txbDocumento
            // 
            this.txbDocumento.Location = new System.Drawing.Point(0, 0);
            this.txbDocumento.Name = "txbDocumento";
            this.txbDocumento.Size = new System.Drawing.Size(286, 262);
            this.txbDocumento.TabIndex = 0;
            this.txbDocumento.Text = "";
            // 
            // frmHijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txbDocumento);
            this.Name = "frmHijo";
            this.Text = "frmHijo";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox txbDocumento;

    }
}