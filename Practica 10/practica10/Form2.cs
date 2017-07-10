using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pVA1DataSet.traduccion' Puede moverla o quitarla según sea necesario.
            this.traduccionTableAdapter.Fill(this.pVA1DataSet.traduccion);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            traduccionTableAdapter.Consulta1(pVA1DataSet.traduccion, txtbuscar.Text);
            if (pVA1DataSet.traduccion.Count > 0)
            {
                //En una etiqueta mostramos el resultado del primer registro (puede haber más)
                lbling.Text = pVA1DataSet.traduccion[0].ing;
            }
            else
            {
                MessageBox.Show("No se han encontrado coincidencias");
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //Etiqueta que muestra lo que seleccionamos en el datagrid.
            lbling.Text = pVA1DataSet.traduccion[traduccionBindingSource.Position].ing;
        }

        private void consulta1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.traduccionTableAdapter.Consulta1(this.pVA1DataSet.traduccion, txtbuscar.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
