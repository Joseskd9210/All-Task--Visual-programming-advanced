namespace practica10
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.espDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traduccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pVA1DataSet = new practica10.PVA1DataSet();
            this.traduccionTableAdapter = new practica10.PVA1DataSetTableAdapters.traduccionTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lbling = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.consulta1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.consulta1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traduccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pVA1DataSet)).BeginInit();
            this.consulta1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.espDataGridViewTextBoxColumn,
            this.ingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.traduccionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(111, 164);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(320, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // espDataGridViewTextBoxColumn
            // 
            this.espDataGridViewTextBoxColumn.DataPropertyName = "esp";
            this.espDataGridViewTextBoxColumn.HeaderText = "esp";
            this.espDataGridViewTextBoxColumn.Name = "espDataGridViewTextBoxColumn";
            this.espDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingDataGridViewTextBoxColumn
            // 
            this.ingDataGridViewTextBoxColumn.DataPropertyName = "ing";
            this.ingDataGridViewTextBoxColumn.HeaderText = "ing";
            this.ingDataGridViewTextBoxColumn.Name = "ingDataGridViewTextBoxColumn";
            this.ingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // traduccionBindingSource
            // 
            this.traduccionBindingSource.DataMember = "traduccion";
            this.traduccionBindingSource.DataSource = this.pVA1DataSet;
            // 
            // pVA1DataSet
            // 
            this.pVA1DataSet.DataSetName = "PVA1DataSet";
            this.pVA1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // traduccionTableAdapter
            // 
            this.traduccionTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbling
            // 
            this.lbling.AutoSize = true;
            this.lbling.Location = new System.Drawing.Point(69, 122);
            this.lbling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbling.Name = "lbling";
            this.lbling.Size = new System.Drawing.Size(71, 17);
            this.lbling.TabIndex = 2;
            this.lbling.Text = "(Traducir)";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(73, 48);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(132, 22);
            this.txtbuscar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Busqueda Español";
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(351, 389);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(100, 28);
            this.btncerrar.TabIndex = 5;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // consulta1ToolStrip
            // 
            this.consulta1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulta1ToolStripButton});
            this.consulta1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.consulta1ToolStrip.Name = "consulta1ToolStrip";
            this.consulta1ToolStrip.Size = new System.Drawing.Size(495, 27);
            this.consulta1ToolStrip.TabIndex = 6;
            this.consulta1ToolStrip.Text = "consulta1ToolStrip";
            // 
            // consulta1ToolStripButton
            // 
            this.consulta1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.consulta1ToolStripButton.Name = "consulta1ToolStripButton";
            this.consulta1ToolStripButton.Size = new System.Drawing.Size(78, 24);
            this.consulta1ToolStripButton.Text = "Consulta1";
            this.consulta1ToolStripButton.Click += new System.EventHandler(this.consulta1ToolStripButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 442);
            this.Controls.Add(this.consulta1ToolStrip);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lbling);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traduccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pVA1DataSet)).EndInit();
            this.consulta1ToolStrip.ResumeLayout(false);
            this.consulta1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PVA1DataSet pVA1DataSet;
        private System.Windows.Forms.BindingSource traduccionBindingSource;
        private PVA1DataSetTableAdapters.traduccionTableAdapter traduccionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn espDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbling;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.ToolStrip consulta1ToolStrip;
        private System.Windows.Forms.ToolStripButton consulta1ToolStripButton;
    }
}