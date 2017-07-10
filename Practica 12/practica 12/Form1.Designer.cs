namespace practica_12
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.txbmostrar = new System.Windows.Forms.TextBox();
            this.lbalumnos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lbalumnos2 = new System.Windows.Forms.ListBox();
            this.ofdabrir = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(31, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(327, 356);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbalumnos);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnmostrar);
            this.tabPage1.Controls.Add(this.txbmostrar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(319, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "sin xml";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnbuscar);
            this.tabPage2.Controls.Add(this.lbalumnos2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(319, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "con xml";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(107, 219);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(91, 52);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // txbmostrar
            // 
            this.txbmostrar.Location = new System.Drawing.Point(21, 274);
            this.txbmostrar.Name = "txbmostrar";
            this.txbmostrar.Size = new System.Drawing.Size(73, 20);
            this.txbmostrar.TabIndex = 2;
            // 
            // lbalumnos
            // 
            this.lbalumnos.FormattingEnabled = true;
            this.lbalumnos.Location = new System.Drawing.Point(21, 36);
            this.lbalumnos.Name = "lbalumnos";
            this.lbalumnos.Size = new System.Drawing.Size(269, 160);
            this.lbalumnos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introduzca la letra del inicio del nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(95, 256);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(114, 47);
            this.btnbuscar.TabIndex = 4;
            this.btnbuscar.Text = "buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lbalumnos2
            // 
            this.lbalumnos2.FormattingEnabled = true;
            this.lbalumnos2.Location = new System.Drawing.Point(40, 27);
            this.lbalumnos2.Name = "lbalumnos2";
            this.lbalumnos2.Size = new System.Drawing.Size(225, 186);
            this.lbalumnos2.TabIndex = 0;
            // 
            // ofdabrir
            // 
            this.ofdabrir.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 392);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.TextBox txbmostrar;
        private System.Windows.Forms.ListBox lbalumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.ListBox lbalumnos2;
        private System.Windows.Forms.OpenFileDialog ofdabrir;
    }
}

