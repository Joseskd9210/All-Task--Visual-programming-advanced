namespace agenda
{
    partial class frmlicencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlicencia));
            this.lblicencia = new System.Windows.Forms.Label();
            this.tblicencia = new System.Windows.Forms.TextBox();
            this.rbacepto = new System.Windows.Forms.RadioButton();
            this.rbnoacepto = new System.Windows.Forms.RadioButton();
            this.btfinalizar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblicencia
            // 
            this.lblicencia.AutoSize = true;
            this.lblicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblicencia.Location = new System.Drawing.Point(12, 9);
            this.lblicencia.Name = "lblicencia";
            this.lblicencia.Size = new System.Drawing.Size(158, 16);
            this.lblicencia.TabIndex = 0;
            this.lblicencia.Text = "Licencia del Producto";
            // 
            // tblicencia
            // 
            this.tblicencia.Location = new System.Drawing.Point(12, 38);
            this.tblicencia.Multiline = true;
            this.tblicencia.Name = "tblicencia";
            this.tblicencia.ReadOnly = true;
            this.tblicencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblicencia.Size = new System.Drawing.Size(249, 102);
            this.tblicencia.TabIndex = 1;
            this.tblicencia.Text = resources.GetString("tblicencia.Text");
            this.tblicencia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbacepto
            // 
            this.rbacepto.AutoSize = true;
            this.rbacepto.Location = new System.Drawing.Point(12, 146);
            this.rbacepto.Name = "rbacepto";
            this.rbacepto.Size = new System.Drawing.Size(194, 17);
            this.rbacepto.TabIndex = 2;
            this.rbacepto.TabStop = true;
            this.rbacepto.Text = "Acepto las condiciones del contrato";
            this.rbacepto.UseVisualStyleBackColor = true;
            this.rbacepto.CheckedChanged += new System.EventHandler(this.rbacepto_CheckedChanged);
            // 
            // rbnoacepto
            // 
            this.rbnoacepto.AutoSize = true;
            this.rbnoacepto.Location = new System.Drawing.Point(12, 169);
            this.rbnoacepto.Name = "rbnoacepto";
            this.rbnoacepto.Size = new System.Drawing.Size(210, 17);
            this.rbnoacepto.TabIndex = 3;
            this.rbnoacepto.TabStop = true;
            this.rbnoacepto.Text = "No acepto las condiciones del contrato";
            this.rbnoacepto.UseVisualStyleBackColor = true;
            this.rbnoacepto.CheckedChanged += new System.EventHandler(this.rbnoacepto_CheckedChanged);
            // 
            // btfinalizar
            // 
            this.btfinalizar.Enabled = false;
            this.btfinalizar.Location = new System.Drawing.Point(36, 212);
            this.btfinalizar.Name = "btfinalizar";
            this.btfinalizar.Size = new System.Drawing.Size(93, 29);
            this.btfinalizar.TabIndex = 4;
            this.btfinalizar.Text = "Finalizar";
            this.btfinalizar.UseVisualStyleBackColor = true;
            this.btfinalizar.Click += new System.EventHandler(this.btfinalizar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(160, 210);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(85, 30);
            this.btcancelar.TabIndex = 5;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // frmlicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btfinalizar);
            this.Controls.Add(this.rbnoacepto);
            this.Controls.Add(this.rbacepto);
            this.Controls.Add(this.tblicencia);
            this.Controls.Add(this.lblicencia);
            this.Name = "frmlicencia";
            this.Text = "Licencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblicencia;
        private System.Windows.Forms.TextBox tblicencia;
        private System.Windows.Forms.RadioButton rbacepto;
        private System.Windows.Forms.RadioButton rbnoacepto;
        private System.Windows.Forms.Button btfinalizar;
        private System.Windows.Forms.Button btcancelar;
    }
}