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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbldireccion_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtdireccion.Text = "";
            cbciudad.Text = null;
            picfoto.Image = null;
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            if ((txtdireccion.Text == "")||(txtdireccion.Text == "")||(cbciudad.Text == ""))
            {
                MessageBox.Show("!! Debe de rellenar todos los campos");
            }
            else 
            {
                MessageBox.Show("Formulario rellenado correctamente. OK");
            }
        
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtnombre.Focus();
            btnlimpiar_Click(null, null);

        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            if (ofdfoto.ShowDialog() == DialogResult.OK)
            {
                picfoto.Image = Image.FromFile(ofdfoto.FileName);
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                txtdireccion.Focus();
            }
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                cbciudad.Focus();
            }
        }

    }
}
