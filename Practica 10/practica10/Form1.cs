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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void traduccionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.traduccionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pVA1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carga datos del data set para quitarlos o añadirlos.
            this.traduccionTableAdapter.Fill(this.pVA1DataSet.traduccion);

        }

        private void espTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (espTextBox.Text.Length == 0)
            {
                e.Cancel = true;
                MessageBox.Show("No dejes el campo vacio.");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void ingTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (espTextBox.Text.Length == 0)
            {
                e.Cancel = true;
                MessageBox.Show("No ha de dejar vacío el campo");
            }
            else
            {
                e.Cancel = false;
            }

        }

        private void btnformulario2_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2();
            formulario2.ShowDialog();
        }
    }
}
