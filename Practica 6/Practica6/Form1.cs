using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica6
{
    public partial class Form1 : Form
    {
        clsMiClase objetopersona = new clsMiClase("","",0);
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbrecuperardni.Text != "")
            {
                lbrecuperarnombre.Text = objetopersona.nombre;
                lbrecuperardni.Text = objetopersona.nif;
                lbrecuperaredad.Text = Convert.ToString(objetopersona.edad);
            }
            else
            {
                MessageBox.Show("Los campos no  han sido rellenados");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objetopersona.nombre = tbnombre.Text;
            objetopersona.nif = tbdni.Text;
            if (Convert.ToInt16(tbedad.Text) > 0 && Convert.ToInt16(tbedad.Text) < 121)
            {
                objetopersona.edad = Convert.ToInt16(tbedad.Text);//convierto a entero la edad
            }
            else
            {
                MessageBox.Show("Edad debe de estar entre 1 y 120.");
            }

            //objetopersona = null;
        }

        private void tbedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btsumaedades_Click(object sender, EventArgs e)
        {
            try
            {
                lbsuma.Text = Convert.ToString(objetopersona.sumadeedades(Convert.ToInt16(tbsuma1.Text), Convert.ToInt16(tbsuma2.Text)));
            }
            catch (Exception)
            {

                MessageBox.Show("No has rellenado los campos.");
            }
        }

        
    }
}
