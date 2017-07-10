namespace agenda
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lblciudad = new System.Windows.Forms.Label();
            this.cbciudad = new System.Windows.Forms.ComboBox();
            this.btnvalidar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblfichapersonal = new System.Windows.Forms.Label();
            this.picfoto = new System.Windows.Forms.PictureBox();
            this.btnabrir = new System.Windows.Forms.Button();
            this.ofdfoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(32, 131);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(81, 25);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.ForeColor = System.Drawing.Color.White;
            this.lbldireccion.Location = new System.Drawing.Point(32, 188);
            this.lbldireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(93, 25);
            this.lbldireccion.TabIndex = 1;
            this.lbldireccion.Text = "Dirección";
            this.lbldireccion.Click += new System.EventHandler(this.lbldireccion_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(37, 162);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(224, 22);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(37, 219);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(224, 22);
            this.txtdireccion.TabIndex = 3;
           
            // 
            // lblciudad
            // 
            this.lblciudad.AutoSize = true;
            this.lblciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblciudad.ForeColor = System.Drawing.Color.White;
            this.lblciudad.Location = new System.Drawing.Point(32, 245);
            this.lblciudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblciudad.Name = "lblciudad";
            this.lblciudad.Size = new System.Drawing.Size(75, 25);
            this.lblciudad.TabIndex = 4;
            this.lblciudad.Text = "Ciudad";
            // 
            // cbciudad
            // 
            this.cbciudad.FormattingEnabled = true;
            this.cbciudad.Items.AddRange(new object[] {
            "Murcia",
            "Alicante",
            "Madrid",
            "Barcelona"});
            this.cbciudad.Location = new System.Drawing.Point(37, 274);
            this.cbciudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbciudad.Name = "cbciudad";
            this.cbciudad.Size = new System.Drawing.Size(224, 24);
            this.cbciudad.TabIndex = 5;
            // 
            // btnvalidar
            // 
            this.btnvalidar.BackColor = System.Drawing.Color.White;
            this.btnvalidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvalidar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvalidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalidar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnvalidar.Location = new System.Drawing.Point(540, 299);
            this.btnvalidar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(167, 37);
            this.btnvalidar.TabIndex = 6;
            this.btnvalidar.Text = "Validar";
            this.btnvalidar.UseVisualStyleBackColor = false;
            this.btnvalidar.Click += new System.EventHandler(this.btnvalidar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.White;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.No;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnlimpiar.Location = new System.Drawing.Point(540, 356);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(167, 37);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.White;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnsalir.Location = new System.Drawing.Point(540, 413);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(167, 37);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lblfichapersonal
            // 
            this.lblfichapersonal.AutoSize = true;
            this.lblfichapersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfichapersonal.ForeColor = System.Drawing.Color.White;
            this.lblfichapersonal.Location = new System.Drawing.Point(20, 27);
            this.lblfichapersonal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfichapersonal.Name = "lblfichapersonal";
            this.lblfichapersonal.Size = new System.Drawing.Size(385, 48);
            this.lblfichapersonal.TabIndex = 9;
            this.lblfichapersonal.Text = "FICHA PERSONAL";
            this.lblfichapersonal.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // picfoto
            // 
            this.picfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picfoto.Location = new System.Drawing.Point(507, 74);
            this.picfoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picfoto.Name = "picfoto";
            this.picfoto.Size = new System.Drawing.Size(200, 154);
            this.picfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfoto.TabIndex = 10;
            this.picfoto.TabStop = false;
            // 
            // btnabrir
            // 
            this.btnabrir.Location = new System.Drawing.Point(507, 236);
            this.btnabrir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(201, 37);
            this.btnabrir.TabIndex = 11;
            this.btnabrir.Text = "Abrir";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // ofdfoto
            // 
            this.ofdfoto.FileName = "openFileDialog1";
            this.ofdfoto.Filter = "imagen jpg|*.jpg|mapa de bits|*.bmp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(775, 526);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.picfoto);
            this.Controls.Add(this.lblfichapersonal);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnvalidar);
            this.Controls.Add(this.cbciudad);
            this.Controls.Add(this.lblciudad);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblnombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Práctica 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lblciudad;
        private System.Windows.Forms.ComboBox cbciudad;
        private System.Windows.Forms.Button btnvalidar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblfichapersonal;
        private System.Windows.Forms.PictureBox picfoto;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.OpenFileDialog ofdfoto;
    }
}

