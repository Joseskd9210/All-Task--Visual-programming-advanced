using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica11
{
    public partial class Practica12 : Form
    {
        public Practica12()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargamos los datos del data set para luego añadirlos o quitarlos.
            this.traduccionTableAdapter.Fill(this.PVA1DataSet.traduccion);

            this.reportViewer1.RefreshReport();
        }
    }
}
