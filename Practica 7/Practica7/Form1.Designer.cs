namespace Practica7
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
            this.btncolor = new boton_v2.cs.boton_v2();
            this.SuspendLayout();
            // 
            // btncolor
            // 
            this.btncolor.AplicarColor = true;
            this.btncolor.ColorDentro = System.Drawing.Color.Yellow;
            this.btncolor.ColorFuera = System.Drawing.Color.Red;
            this.btncolor.Location = new System.Drawing.Point(42, 85);
            this.btncolor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(191, 51);
            this.btncolor.TabIndex = 0;
            this.btncolor.Text = "Boton Cambiante";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.MouseEnter += new System.EventHandler(this.btncolor_MouseEnter);
            this.btncolor.MouseLeave += new System.EventHandler(this.btncolor_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 246);
            this.Controls.Add(this.btncolor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private boton_v2.cs.boton_v2 btncolor;
    }
}

