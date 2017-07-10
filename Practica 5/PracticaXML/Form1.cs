using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace PracticaXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            
            openFileDialog1.Filter = "XML files (*.xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {


                XmlDocument midocxml = new XmlDocument();           
                midocxml.Load(openFileDialog1.FileName);                 XmlNodeList notas = midocxml.GetElementsByTagName("notas"); 
                XmlNodeList lista = ((XmlElement)notas[0]).GetElementsByTagName("porcentaje");
                int nota1 = 0, nota2 = 0, nota3 = 0 ;
                int total = 0;
               
                foreach (XmlElement nodo in lista)
                {
                    XmlNodeList parcial = nodo.GetElementsByTagName("parcial");
                    XmlNodeList final = nodo.GetElementsByTagName("final");
                    XmlNodeList practicas = nodo.GetElementsByTagName("practicas");

                    nota1 = Convert.ToInt32(parcial[0].InnerText);
                    nota2 = Convert.ToInt32(final[0].InnerText);
                    nota3 = Convert.ToInt32(practicas[0].InnerText);
                   
                }
                XmlNodeList alum = midocxml.GetElementsByTagName("alumnos"); 
                XmlNodeList alumno = ((XmlElement)alum[0]).GetElementsByTagName("alumno");

                foreach (XmlElement nodo in alumno)
                {
                    XmlNodeList pAlu = nodo.GetElementsByTagName("parcial");
                    XmlNodeList fAlu = nodo.GetElementsByTagName("final");
                    XmlNodeList pracAlu = nodo.GetElementsByTagName("practicas");
                    for (int i = 0; i < pAlu.Count; i++)
                    {
                        int comprobar=0;
                        int valor = 0;
                        if (pAlu[i].InnerText != "")
                        {

                           // MessageBox.Show(pAlu[i].InnerText);
                           //valor = valor + Convert.ToInt32(Convert.ToDecimal(pAlu[i].InnerText));
                           // valor = valor * 100;
                            //valor = valor / nota1;
                            total = total + Convert.ToInt32(Convert.ToDecimal(pAlu[i].InnerText));

                            
                            
                        }
                        else {
                            comprobar++;
                            total = total + 0;
                        }
                        if (fAlu[i].InnerText != "")
                        {
                            
                           /* valor = valor +  Convert.ToInt32(Convert.ToDecimal(fAlu[i].InnerText));
                            valor = valor * 100;
                            valor = valor / nota2;*/
                            total = total + Convert.ToInt32(Convert.ToDecimal(fAlu[i].InnerText));
                        }
                        else
                        {
                            comprobar++;
                            total = total + 0;
                        }
                        if (pracAlu[i].InnerText != "")
                        {

                            /*valor = valor + Convert.ToInt32(Convert.ToDecimal(pracAlu[i].InnerText));
                            valor = valor * 100;
                            valor = valor / nota3;*/
                            total = total + Convert.ToInt32(Convert.ToDecimal(pracAlu[i].InnerText));
                        }
                        else
                        {
                            comprobar++;
                            total = total + 0;
                        }

                       
                        total = total / 3;
                        if (total < 40 && comprobar == 0) {

                            lbXml.Items.Add("\t Suspenso");
                        }
                        else if (total < 40 && comprobar > 0)
                        {
                            lbXml.Items.Add("\t No Presentado");
                        }
                        else if (total >= 40 && total < 70)
                        {
                            lbXml.Items.Add("\t Aprobado");
                        }
                        else if (total >= 70 && total < 90)
                        {
                            lbXml.Items.Add("\t Notable");
                        }
                        else if (total >= 90 && total < 100)
                        {
                            lbXml.Items.Add("\t Sobresaliente");
                        }
                       
                        total = 0;
                    }

                } 
                
                
                lbXml.Show();
            }
        }
    }
}
