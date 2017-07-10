namespace practica3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnborrartodo = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.gbtipo = new System.Windows.Forms.GroupBox();
            this.rbhijo = new System.Windows.Forms.RadioButton();
            this.rbrama = new System.Windows.Forms.RadioButton();
            this.tbinsertar = new System.Windows.Forms.TextBox();
            this.tvwarbol = new System.Windows.Forms.TreeView();
            this.btninsertar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnborrartodalista = new System.Windows.Forms.Button();
            this.btnborrarlista = new System.Windows.Forms.Button();
            this.btninsertarlista = new System.Windows.Forms.Button();
            this.gbicono = new System.Windows.Forms.GroupBox();
            this.rbimagen1 = new System.Windows.Forms.RadioButton();
            this.illista = new System.Windows.Forms.ImageList(this.components);
            this.rbimagen0 = new System.Windows.Forms.RadioButton();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbdni = new System.Windows.Forms.TextBox();
            this.lbtelefono = new System.Windows.Forms.Label();
            this.lbdni = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lvwlista = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnsalir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbtipo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbicono.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(47, 36);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(381, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnborrartodo);
            this.tabPage1.Controls.Add(this.btnborrar);
            this.tabPage1.Controls.Add(this.gbtipo);
            this.tabPage1.Controls.Add(this.tbinsertar);
            this.tabPage1.Controls.Add(this.tvwarbol);
            this.tabPage1.Controls.Add(this.btninsertar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(373, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arbol";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnborrartodo
            // 
            this.btnborrartodo.Location = new System.Drawing.Point(176, 316);
            this.btnborrartodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnborrartodo.Name = "btnborrartodo";
            this.btnborrartodo.Size = new System.Drawing.Size(157, 28);
            this.btnborrartodo.TabIndex = 5;
            this.btnborrartodo.Text = "Borrar todo el arbol";
            this.btnborrartodo.UseVisualStyleBackColor = true;
            this.btnborrartodo.Click += new System.EventHandler(this.btnborrartodo_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(24, 316);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(108, 26);
            this.btnborrar.TabIndex = 4;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // gbtipo
            // 
            this.gbtipo.Controls.Add(this.rbhijo);
            this.gbtipo.Controls.Add(this.rbrama);
            this.gbtipo.Location = new System.Drawing.Point(67, 215);
            this.gbtipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbtipo.Name = "gbtipo";
            this.gbtipo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbtipo.Size = new System.Drawing.Size(224, 66);
            this.gbtipo.TabIndex = 3;
            this.gbtipo.TabStop = false;
            this.gbtipo.Text = "Tipo";
            // 
            // rbhijo
            // 
            this.rbhijo.AutoSize = true;
            this.rbhijo.Location = new System.Drawing.Point(111, 33);
            this.rbhijo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbhijo.Name = "rbhijo";
            this.rbhijo.Size = new System.Drawing.Size(53, 21);
            this.rbhijo.TabIndex = 1;
            this.rbhijo.Text = "Hijo";
            this.rbhijo.UseVisualStyleBackColor = true;
            // 
            // rbrama
            // 
            this.rbrama.AutoSize = true;
            this.rbrama.Checked = true;
            this.rbrama.Location = new System.Drawing.Point(17, 33);
            this.rbrama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbrama.Name = "rbrama";
            this.rbrama.Size = new System.Drawing.Size(66, 21);
            this.rbrama.TabIndex = 0;
            this.rbrama.TabStop = true;
            this.rbrama.Text = "Rama";
            this.rbrama.UseVisualStyleBackColor = true;
            // 
            // tbinsertar
            // 
            this.tbinsertar.Location = new System.Drawing.Point(23, 165);
            this.tbinsertar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbinsertar.Name = "tbinsertar";
            this.tbinsertar.Size = new System.Drawing.Size(140, 22);
            this.tbinsertar.TabIndex = 2;
            // 
            // tvwarbol
            // 
            this.tvwarbol.Location = new System.Drawing.Point(20, 15);
            this.tvwarbol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvwarbol.Name = "tvwarbol";
            this.tvwarbol.Size = new System.Drawing.Size(327, 131);
            this.tvwarbol.TabIndex = 1;
            this.tvwarbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwarbol_AfterSelect);
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(233, 162);
            this.btninsertar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(100, 28);
            this.btninsertar.TabIndex = 0;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnborrartodalista);
            this.tabPage2.Controls.Add(this.btnborrarlista);
            this.tabPage2.Controls.Add(this.btninsertarlista);
            this.tabPage2.Controls.Add(this.gbicono);
            this.tabPage2.Controls.Add(this.tbtelefono);
            this.tabPage2.Controls.Add(this.tbnombre);
            this.tabPage2.Controls.Add(this.tbdni);
            this.tabPage2.Controls.Add(this.lbtelefono);
            this.tabPage2.Controls.Add(this.lbdni);
            this.tabPage2.Controls.Add(this.lbnombre);
            this.tabPage2.Controls.Add(this.lvwlista);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(373, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnborrartodalista
            // 
            this.btnborrartodalista.Location = new System.Drawing.Point(207, 391);
            this.btnborrartodalista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnborrartodalista.Name = "btnborrartodalista";
            this.btnborrartodalista.Size = new System.Drawing.Size(149, 27);
            this.btnborrartodalista.TabIndex = 10;
            this.btnborrartodalista.Text = "Borrar toda la lista";
            this.btnborrartodalista.UseVisualStyleBackColor = true;
            this.btnborrartodalista.Click += new System.EventHandler(this.btnborrartodalista_Click);
            // 
            // btnborrarlista
            // 
            this.btnborrarlista.Location = new System.Drawing.Point(33, 391);
            this.btnborrarlista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnborrarlista.Name = "btnborrarlista";
            this.btnborrarlista.Size = new System.Drawing.Size(100, 28);
            this.btnborrarlista.TabIndex = 9;
            this.btnborrarlista.Text = "Borrar";
            this.btnborrarlista.UseVisualStyleBackColor = true;
            this.btnborrarlista.Click += new System.EventHandler(this.btnborrarlista_Click);
            // 
            // btninsertarlista
            // 
            this.btninsertarlista.Location = new System.Drawing.Point(259, 354);
            this.btninsertarlista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btninsertarlista.Name = "btninsertarlista";
            this.btninsertarlista.Size = new System.Drawing.Size(100, 28);
            this.btninsertarlista.TabIndex = 8;
            this.btninsertarlista.Text = "Insertar";
            this.btninsertarlista.UseVisualStyleBackColor = true;
            this.btninsertarlista.Click += new System.EventHandler(this.btninsertarlista_Click);
            // 
            // gbicono
            // 
            this.gbicono.Controls.Add(this.rbimagen1);
            this.gbicono.Controls.Add(this.rbimagen0);
            this.gbicono.Location = new System.Drawing.Point(272, 218);
            this.gbicono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbicono.Name = "gbicono";
            this.gbicono.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbicono.Size = new System.Drawing.Size(80, 123);
            this.gbicono.TabIndex = 7;
            this.gbicono.TabStop = false;
            this.gbicono.Text = "Icono";
            // 
            // rbimagen1
            // 
            this.rbimagen1.AutoSize = true;
            this.rbimagen1.ImageIndex = 1;
            this.rbimagen1.ImageList = this.illista;
            this.rbimagen1.Location = new System.Drawing.Point(7, 82);
            this.rbimagen1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbimagen1.Name = "rbimagen1";
            this.rbimagen1.Size = new System.Drawing.Size(49, 32);
            this.rbimagen1.TabIndex = 1;
            this.rbimagen1.UseVisualStyleBackColor = true;
            // 
            // illista
            // 
            this.illista.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("illista.ImageStream")));
            this.illista.TransparentColor = System.Drawing.Color.Transparent;
            this.illista.Images.SetKeyName(0, "Desert.jpg");
            this.illista.Images.SetKeyName(1, "Penguins.jpg");
            // 
            // rbimagen0
            // 
            this.rbimagen0.AutoSize = true;
            this.rbimagen0.Checked = true;
            this.rbimagen0.ImageIndex = 0;
            this.rbimagen0.ImageList = this.illista;
            this.rbimagen0.Location = new System.Drawing.Point(7, 32);
            this.rbimagen0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbimagen0.Name = "rbimagen0";
            this.rbimagen0.Size = new System.Drawing.Size(49, 32);
            this.rbimagen0.TabIndex = 0;
            this.rbimagen0.TabStop = true;
            this.rbimagen0.UseVisualStyleBackColor = true;
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(115, 303);
            this.tbtelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(132, 22);
            this.tbtelefono.TabIndex = 6;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(115, 256);
            this.tbnombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(132, 22);
            this.tbnombre.TabIndex = 5;
            // 
            // tbdni
            // 
            this.tbdni.Location = new System.Drawing.Point(115, 214);
            this.tbdni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbdni.Name = "tbdni";
            this.tbdni.Size = new System.Drawing.Size(91, 22);
            this.tbdni.TabIndex = 4;
            this.tbdni.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbtelefono
            // 
            this.lbtelefono.AutoSize = true;
            this.lbtelefono.Location = new System.Drawing.Point(32, 303);
            this.lbtelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtelefono.Name = "lbtelefono";
            this.lbtelefono.Size = new System.Drawing.Size(64, 17);
            this.lbtelefono.TabIndex = 3;
            this.lbtelefono.Text = "Telefono";
            this.lbtelefono.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbdni
            // 
            this.lbdni.AutoSize = true;
            this.lbdni.Location = new System.Drawing.Point(32, 218);
            this.lbdni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdni.Name = "lbdni";
            this.lbdni.Size = new System.Drawing.Size(31, 17);
            this.lbdni.TabIndex = 2;
            this.lbdni.Text = "DNI";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(32, 255);
            this.lbnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(58, 17);
            this.lbnombre.TabIndex = 1;
            this.lbnombre.Text = "Nombre";
            // 
            // lvwlista
            // 
            this.lvwlista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwlista.FullRowSelect = true;
            this.lvwlista.Location = new System.Drawing.Point(8, 32);
            this.lvwlista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwlista.Name = "lvwlista";
            this.lvwlista.Size = new System.Drawing.Size(340, 174);
            this.lvwlista.SmallImageList = this.illista;
            this.lvwlista.TabIndex = 0;
            this.lvwlista.UseCompatibleStateImageBehavior = false;
            this.lvwlista.View = System.Windows.Forms.View.Details;
            this.lvwlista.SelectedIndexChanged += new System.EventHandler(this.lvwlista_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DNI";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefono";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(439, 521);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(100, 28);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(555, 564);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Arbol y Lista";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbtipo.ResumeLayout(false);
            this.gbtipo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbicono.ResumeLayout(false);
            this.gbicono.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnborrartodo;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.GroupBox gbtipo;
        private System.Windows.Forms.RadioButton rbhijo;
        private System.Windows.Forms.RadioButton rbrama;
        private System.Windows.Forms.TextBox tbinsertar;
        private System.Windows.Forms.TreeView tvwarbol;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ListView lvwlista;
        private System.Windows.Forms.Label lbtelefono;
        private System.Windows.Forms.Label lbdni;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbdni;
        private System.Windows.Forms.Button btnborrarlista;
        private System.Windows.Forms.Button btninsertarlista;
        private System.Windows.Forms.GroupBox gbicono;
        private System.Windows.Forms.RadioButton rbimagen1;
        private System.Windows.Forms.RadioButton rbimagen0;
        private System.Windows.Forms.Button btnborrartodalista;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList illista;

    }
}

