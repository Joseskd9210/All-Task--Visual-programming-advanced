using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace agenda
{
    public partial class frmlicencia : Form
    {
        public frmlicencia()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbnoacepto_CheckedChanged(object sender, EventArgs e)
        {
            btfinalizar.Enabled = false; 
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbacepto_CheckedChanged(object sender, EventArgs e)
        {
            btfinalizar.Enabled = true;
        }

        private void btfinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto Registrado");
        }
    }
}
