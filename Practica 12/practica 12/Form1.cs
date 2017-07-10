using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace practica_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            string[] alumnos = { "Juan", "Heriberto", "Manolo", "El parra", "Juanfran", "Toñin" };

            var alumnosseleccionados = from busca in alumnos
                                       where busca.StartsWith(txbmostrar.Text)//Comprueba  solo la primera letra
                                       orderby busca
                                       select busca.ToUpper();
            //Lo metemos en un listbox
            foreach (var un_alumno in alumnosseleccionados)
            {
                lbalumnos.Items.Add(un_alumno);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (ofdabrir.ShowDialog() == DialogResult.OK)
            {
                // Para añadir el documento xml XDocument documentoXML = XDocument.Load(@"C:\Users\ucam\Documents\Visual Studio 2013\Projects\practica 12\practica 12\datos.xml");
                XDocument documentoXML = XDocument.Load(ofdabrir.FileName);

                var alumnosSeleccionados = from datos in documentoXML.Descendants("nota")
                                           where datos.Attribute("asignatura").Value.ToString().ToUpper() == "PVA"
                                           select new
                                           {
                                               nifalumno = datos.Element("nif").Value,
                                               calificacionalumno = datos.Element("calificacion").Value
                                           };
                //Recuperamos la consulta y la mostramos en un listbox.
                foreach (var el_alumno in alumnosSeleccionados)
                {
                    lbalumnos2.Items.Add(el_alumno.nifalumno + " " + el_alumno.calificacionalumno);
                }

            }
            else
            {
                MessageBox.Show("Intentelo Mas tarde");
            }

        }

    }
}
