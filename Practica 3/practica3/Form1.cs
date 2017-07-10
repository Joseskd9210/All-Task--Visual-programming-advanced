using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (rbrama.Checked)//Comprobamos radio button
            {
                tvwarbol.Nodes.Add(tbinsertar.Text);
            }
            else
            {
                TreeNode objNode; //creamos el arbol
                objNode = tvwarbol.SelectedNode;
                if (tvwarbol.SelectedNode != null)
                {
                    objNode.Nodes.Add(tbinsertar.Text);
                }
                else
                {
                    MessageBox.Show("Debe de elegir un nodo padre");
                }
        

            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            tvwarbol.Nodes.Remove(tvwarbol.SelectedNode); 

        }

        private void btnborrartodo_Click(object sender, EventArgs e)
        {
            tvwarbol.Nodes.Clear(); 

        }

        private void tvwarbol_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta seguro que desea salir");
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btninsertarlista_Click(object sender, EventArgs e)
        {
            ListViewItem milista;
            int iconover;
            if (rbimagen0.Checked == true)
            {
                iconover = 0;
            }
            else
            {
                iconover = 1;
            }

            if(tbdni.Text!="" && tbnombre.Text!= "" && tbtelefono.Text!="")
            {
            milista = lvwlista.Items.Add(tbdni.Text,iconover); 
            milista.SubItems.Add(tbnombre.Text); 
            milista.SubItems.Add(tbtelefono.Text);
            }
            else
            {
                MessageBox.Show("Rellena todos los datos");
            }

        }

        private void btnborrartodalista_Click(object sender, EventArgs e)
        {
            lvwlista.Items.Clear(); 

        }

        private void lvwlista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnborrarlista_Click(object sender, EventArgs e)
        {
            int valor = lvwlista.SelectedItems.Count;
            int i;
           
            for (i = 0; i < valor; i++)
            {
                lvwlista.Items.Remove(lvwlista.SelectedItems[0]);
            }
        }

        
    }
}
