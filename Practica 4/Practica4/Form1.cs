using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fHijo objetohijo = new fHijo();
            objetohijo.MdiParent = this;
            objetohijo.Text = "Documento " + Convert.ToString(this.MdiChildren.Length);
            objetohijo.Show();
            string stringFecha = DateTime.Now.ToString(); // consigo la fecha actual del sistema
            StreamWriter fichero = new StreamWriter(@"C:\Users\Charlie\Desktop\Practica4\carpin.txt", true);
            fichero.WriteLine(stringFecha + " Se ha creado un nuevo hijo \n");

            fichero.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHijo objetohijo = (fHijo)this.ActiveMdiChild;
            if (objetohijo != null)
            {
                objetohijo.Close();
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            nuevoToolStripMenuItem_Click(null, null);
            string stringFecha = DateTime.Now.ToString(); // consigo la fecha actual del sistema
            StreamWriter fichero = new StreamWriter(@"C:\Users\Charlie\Desktop\Practica4\carpin.txt", true);
            fichero.WriteLine(stringFecha + " Se ha abierto un hijo \n");
            fichero.Close();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            cerrarToolStripMenuItem_Click(null, null);
            string stringFecha = DateTime.Now.ToString(); // consigo la fecha actual del sistema
            StreamWriter fichero = new StreamWriter(@"C:\Users\Charlie\Desktop\Practica4\carpin.txt", true);
            fichero.WriteLine(stringFecha + " Se ha cerrado un hijo \n");
            fichero.Close();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            string stringFecha = DateTime.Now.ToString(); // consigo la fecha actual del sistema
            StreamWriter fichero = new StreamWriter(@"C:\Users\Charlie\Desktop\Practica4\carpin.txt", true);
            fichero.WriteLine(stringFecha + " Se ha puesto el estilo horizontal para la representacion de hijos \n");
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            string stringFecha = DateTime.Now.ToString(); // consigo la fecha actual del sistema
            StreamWriter fichero = new StreamWriter(@"C:\Users\Charlie\Desktop\Practica4\carpin.txt", true);
            fichero.WriteLine(stringFecha + " Se ha puesto el estilo cascada para la representacion de hijos \n");

            fichero.Close();
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
            string stringFecha = DateTime.Now.ToString(); // consigo la fecha actual del sistema
            StreamWriter fichero = new StreamWriter(@"C:\Users\Charlie\Desktop\Practica4\carpin.txt", true);
            fichero.WriteLine(stringFecha + " Se ha puesto el estilo vertical para la representacion de hijos \n");
        }

        private void minimizarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].WindowState = FormWindowState.Minimized;
            }
            string stringFecha = DateTime.Now.ToString(); // consigo la fecha actual del sistema
            StreamWriter fichero = new StreamWriter(@"C:\Users\Charlie\Desktop\Practica4\carpin.txt", true);
            fichero.WriteLine(stringFecha + " Se han minimizado todas los hijos para la representacion de hijos \n");
        }

        private void tsbCascada_Click(object sender, EventArgs e)
        {
            cascadaToolStripMenuItem_Click(null, null);
            string stringFecha = DateTime.Now.ToString(); // consigo la fecha actual del sistema
            StreamWriter fichero = new StreamWriter(@"C:\Users\Charlie\Desktop\Practica4\carpin.txt", true);
            fichero.WriteLine(stringFecha + " Se ha puesto el estilo cascada para la representacion de hijos \n");
            fichero.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
          
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fHijo objetohijo = new fHijo();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader textoarchivo = File.OpenText(openFileDialog1.FileName);
                objetohijo.MdiParent = this;
                objetohijo.Show();

                objetohijo.tbHijo.Text = textoarchivo.ReadToEnd();
                textoarchivo.Close();
                string stringFecha = DateTime.Now.ToString(); // consigo la fecha actual del sistema
                StreamWriter fichero = new StreamWriter(@"C:\Users\Charlie\Desktop\Practica4\carpin.txt", true);
                fichero.WriteLine(stringFecha + " Se ha abierto un fichero \n");
                fichero.Close();
            }
        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
                
               this.ActiveMdiChild.ActiveControl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ActiveMdiChild.ActiveControl.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
            
        }
        
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fHijo objetohijo = (fHijo)this.ActiveMdiChild;

                StreamWriter documento = File.CreateText(saveFileDialog1.FileName);
                documento.Write(objetohijo.tbHijo.Text);
                documento.Close();
                string stringFecha = DateTime.Now.ToString(); // consigo la fecha actual del sistema
                StreamWriter fichero = new StreamWriter(@"C:\Users\Charlie\Desktop\Practica4\carpin.txt", true);
                fichero.WriteLine(stringFecha + " Se ha guardado un fichero \n");
               
                fichero.Close();
               

            }
        }

        private void nuevoWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrimos un documento usando OpenFileDialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //1. Creamos un objeto hijo
                frmHijo objetohijo = new frmHijo();

                objetohijo.MdiParent = this;
                //Cargamos el hijo
                objetohijo.txbDocumento.LoadFile(openFileDialog1.FileName);
                objetohijo.Show();
            }
        }
        
       
    }
}
