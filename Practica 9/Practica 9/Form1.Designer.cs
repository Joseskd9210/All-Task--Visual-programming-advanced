namespace Practica_9
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
            this.lbpalabras = new System.Windows.Forms.ListBox();
            this.btncrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbespañol = new System.Windows.Forms.Label();
            this.tbingles = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lvdiccionario = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btntraducir = new System.Windows.Forms.Button();
            this.lbfiltro = new System.Windows.Forms.Label();
            this.txbfiltro = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbpalabras
            // 
            this.lbpalabras.FormattingEnabled = true;
            this.lbpalabras.ItemHeight = 16;
            this.lbpalabras.Location = new System.Drawing.Point(43, 21);
            this.lbpalabras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbpalabras.Name = "lbpalabras";
            this.lbpalabras.Size = new System.Drawing.Size(468, 228);
            this.lbpalabras.TabIndex = 0;
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(43, 277);
            this.btncrear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(469, 44);
            this.btncrear.TabIndex = 1;
            this.btncrear.Text = "Leer Base de Datos";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diccionario de Palabras";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(17, 46);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 482);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbpalabras);
            this.tabPage1.Controls.Add(this.btncrear);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(555, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Con Listbox";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btneliminar);
            this.tabPage2.Controls.Add(this.btnmodificar);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lbespañol);
            this.tabPage2.Controls.Add(this.tbingles);
            this.tabPage2.Controls.Add(this.tbnombre);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.lvdiccionario);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(555, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Con ListView";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(24, 412);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(499, 31);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(24, 372);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(499, 33);
            this.btnmodificar.TabIndex = 7;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 325);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(499, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Añadir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingles";
            // 
            // lbespañol
            // 
            this.lbespañol.AutoSize = true;
            this.lbespañol.Location = new System.Drawing.Point(24, 273);
            this.lbespañol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbespañol.Name = "lbespañol";
            this.lbespañol.Size = new System.Drawing.Size(59, 17);
            this.lbespañol.TabIndex = 4;
            this.lbespañol.Text = "Español";
            // 
            // tbingles
            // 
            this.tbingles.Location = new System.Drawing.Point(276, 293);
            this.tbingles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbingles.Name = "tbingles";
            this.tbingles.Size = new System.Drawing.Size(211, 22);
            this.tbingles.TabIndex = 3;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(28, 293);
            this.tbnombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(200, 22);
            this.tbnombre.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 218);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(499, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Leer Datos de Base de Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvdiccionario
            // 
            this.lvdiccionario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvdiccionario.FullRowSelect = true;
            this.lvdiccionario.Location = new System.Drawing.Point(24, 26);
            this.lvdiccionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvdiccionario.Name = "lvdiccionario";
            this.lvdiccionario.Size = new System.Drawing.Size(497, 184);
            this.lvdiccionario.TabIndex = 0;
            this.lvdiccionario.UseCompatibleStateImageBehavior = false;
            this.lvdiccionario.View = System.Windows.Forms.View.Details;
            this.lvdiccionario.Click += new System.EventHandler(this.lvdiccionario_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Español";
            this.columnHeader1.Width = 168;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ingles";
            this.columnHeader2.Width = 167;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btntraducir);
            this.tabPage3.Controls.Add(this.lbfiltro);
            this.tabPage3.Controls.Add(this.txbfiltro);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(555, 453);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Filtro";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btntraducir
            // 
            this.btntraducir.Location = new System.Drawing.Point(168, 206);
            this.btntraducir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntraducir.Name = "btntraducir";
            this.btntraducir.Size = new System.Drawing.Size(185, 68);
            this.btntraducir.TabIndex = 2;
            this.btntraducir.Text = "Traducir";
            this.btntraducir.UseVisualStyleBackColor = true;
            this.btntraducir.Click += new System.EventHandler(this.btntraducir_Click);
            // 
            // lbfiltro
            // 
            this.lbfiltro.AutoSize = true;
            this.lbfiltro.Location = new System.Drawing.Point(371, 55);
            this.lbfiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbfiltro.Name = "lbfiltro";
            this.lbfiltro.Size = new System.Drawing.Size(0, 17);
            this.lbfiltro.TabIndex = 1;
            // 
            // txbfiltro
            // 
            this.txbfiltro.Location = new System.Drawing.Point(64, 55);
            this.txbfiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbfiltro.Name = "txbfiltro";
            this.txbfiltro.Size = new System.Drawing.Size(235, 22);
            this.txbfiltro.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 543);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Practica 9";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbpalabras;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvdiccionario;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbespañol;
        private System.Windows.Forms.TextBox tbingles;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btntraducir;
        private System.Windows.Forms.Label lbfiltro;
        private System.Windows.Forms.TextBox txbfiltro;
    }
}

