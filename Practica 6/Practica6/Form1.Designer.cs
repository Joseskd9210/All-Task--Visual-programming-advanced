namespace Practica6
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbdni = new System.Windows.Forms.TextBox();
            this.tbedad = new System.Windows.Forms.TextBox();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbdni = new System.Windows.Forms.Label();
            this.lbedad = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btrecuperar = new System.Windows.Forms.Button();
            this.lbrecuperarnombre = new System.Windows.Forms.Label();
            this.lbrecuperardni = new System.Windows.Forms.Label();
            this.lbrecuperaredad = new System.Windows.Forms.Label();
            this.tbsuma1 = new System.Windows.Forms.TextBox();
            this.tbsuma2 = new System.Windows.Forms.TextBox();
            this.btsumaedades = new System.Windows.Forms.Button();
            this.lbsuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(115, 83);
            this.tbnombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(149, 22);
            this.tbnombre.TabIndex = 0;
            // 
            // tbdni
            // 
            this.tbdni.Location = new System.Drawing.Point(115, 123);
            this.tbdni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbdni.Name = "tbdni";
            this.tbdni.Size = new System.Drawing.Size(149, 22);
            this.tbdni.TabIndex = 1;
            // 
            // tbedad
            // 
            this.tbedad.Location = new System.Drawing.Point(115, 165);
            this.tbedad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbedad.Name = "tbedad";
            this.tbedad.Size = new System.Drawing.Size(149, 22);
            this.tbedad.TabIndex = 2;
            this.tbedad.TextChanged += new System.EventHandler(this.tbedad_TextChanged);
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(53, 87);
            this.lbnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(58, 17);
            this.lbnombre.TabIndex = 3;
            this.lbnombre.Text = "Nombre";
            // 
            // lbdni
            // 
            this.lbdni.AutoSize = true;
            this.lbdni.Location = new System.Drawing.Point(53, 127);
            this.lbdni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdni.Name = "lbdni";
            this.lbdni.Size = new System.Drawing.Size(29, 17);
            this.lbdni.TabIndex = 4;
            this.lbdni.Text = "Dni";
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Location = new System.Drawing.Point(53, 169);
            this.lbedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(41, 17);
            this.lbedad.TabIndex = 5;
            this.lbedad.Text = "Edad";
            this.lbedad.Click += new System.EventHandler(this.label3_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(56, 233);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(93, 26);
            this.btAceptar.TabIndex = 6;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btrecuperar
            // 
            this.btrecuperar.Location = new System.Drawing.Point(171, 233);
            this.btrecuperar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btrecuperar.Name = "btrecuperar";
            this.btrecuperar.Size = new System.Drawing.Size(93, 26);
            this.btrecuperar.TabIndex = 7;
            this.btrecuperar.Text = "Recuperar";
            this.btrecuperar.UseVisualStyleBackColor = true;
            this.btrecuperar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbrecuperarnombre
            // 
            this.lbrecuperarnombre.AutoSize = true;
            this.lbrecuperarnombre.Location = new System.Drawing.Point(335, 94);
            this.lbrecuperarnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbrecuperarnombre.Name = "lbrecuperarnombre";
            this.lbrecuperarnombre.Size = new System.Drawing.Size(0, 17);
            this.lbrecuperarnombre.TabIndex = 8;
            // 
            // lbrecuperardni
            // 
            this.lbrecuperardni.AutoSize = true;
            this.lbrecuperardni.Location = new System.Drawing.Point(335, 144);
            this.lbrecuperardni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbrecuperardni.Name = "lbrecuperardni";
            this.lbrecuperardni.Size = new System.Drawing.Size(0, 17);
            this.lbrecuperardni.TabIndex = 9;
            // 
            // lbrecuperaredad
            // 
            this.lbrecuperaredad.AutoSize = true;
            this.lbrecuperaredad.Location = new System.Drawing.Point(335, 184);
            this.lbrecuperaredad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbrecuperaredad.Name = "lbrecuperaredad";
            this.lbrecuperaredad.Size = new System.Drawing.Size(0, 17);
            this.lbrecuperaredad.TabIndex = 10;
            // 
            // tbsuma1
            // 
            this.tbsuma1.Location = new System.Drawing.Point(81, 294);
            this.tbsuma1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbsuma1.Name = "tbsuma1";
            this.tbsuma1.Size = new System.Drawing.Size(68, 22);
            this.tbsuma1.TabIndex = 11;
            // 
            // tbsuma2
            // 
            this.tbsuma2.Location = new System.Drawing.Point(171, 294);
            this.tbsuma2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbsuma2.Name = "tbsuma2";
            this.tbsuma2.Size = new System.Drawing.Size(68, 22);
            this.tbsuma2.TabIndex = 12;
            // 
            // btsumaedades
            // 
            this.btsumaedades.Location = new System.Drawing.Point(259, 294);
            this.btsumaedades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btsumaedades.Name = "btsumaedades";
            this.btsumaedades.Size = new System.Drawing.Size(90, 28);
            this.btsumaedades.TabIndex = 13;
            this.btsumaedades.Text = "Sumar";
            this.btsumaedades.UseVisualStyleBackColor = true;
            this.btsumaedades.Click += new System.EventHandler(this.btsumaedades_Click);
            // 
            // lbsuma
            // 
            this.lbsuma.AutoSize = true;
            this.lbsuma.Location = new System.Drawing.Point(421, 294);
            this.lbsuma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbsuma.Name = "lbsuma";
            this.lbsuma.Size = new System.Drawing.Size(0, 17);
            this.lbsuma.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 344);
            this.Controls.Add(this.lbsuma);
            this.Controls.Add(this.btsumaedades);
            this.Controls.Add(this.tbsuma2);
            this.Controls.Add(this.tbsuma1);
            this.Controls.Add(this.lbrecuperaredad);
            this.Controls.Add(this.lbrecuperardni);
            this.Controls.Add(this.lbrecuperarnombre);
            this.Controls.Add(this.btrecuperar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbedad);
            this.Controls.Add(this.lbdni);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.tbedad);
            this.Controls.Add(this.tbdni);
            this.Controls.Add(this.tbnombre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbdni;
        private System.Windows.Forms.TextBox tbedad;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbdni;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btrecuperar;
        private System.Windows.Forms.Label lbrecuperarnombre;
        private System.Windows.Forms.Label lbrecuperardni;
        private System.Windows.Forms.Label lbrecuperaredad;
        private System.Windows.Forms.TextBox tbsuma1;
        private System.Windows.Forms.TextBox tbsuma2;
        private System.Windows.Forms.Button btsumaedades;
        private System.Windows.Forms.Label lbsuma;
    }
}

