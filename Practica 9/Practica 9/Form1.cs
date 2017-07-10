using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practica_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new
            //SqlConnection("MSSQLALU.ucam.edu\ucamalu; database=Diccionario; Integrated Security=SSPI");
            //Seguridad Windows.
            //Si la seguridad se hace a nivel de SQLServer hay que añadir usuario y
            //contraseña.
            SqlConnection("server=MSSQLALU.ucam.edu\\ucamalu; database=PVA1; uid=useralum; pwd=useralum00");
            SqlCommand comandosql = new SqlCommand();
            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT esp,ing FROM traduccion";
            SqlDataReader midatareader = comandosql.ExecuteReader();

            string dato1;
            string dato2;
            while (midatareader.Read()){
                dato1 = midatareader.GetString(0); //palabra español
                dato2 = midatareader.GetString(1); //palabra ingles

                lbpalabras.Items.Add(dato1+"\t"+dato2);
             
            }
            midatareader.Close();
            conexion.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           lvdiccionario.Items.Clear();
            SqlConnection conexion = new
                //SqlConnection("MSSQLALU.ucam.edu\ucamalu; database=Diccionario; Integrated Security=SSPI");
                //Seguridad Windows.
                //Si la seguridad se hace a nivel de SQLServer hay que añadir usuario y
                //contraseña.
           SqlConnection("server=MSSQLALU.ucam.edu\\ucamalu; database=PVA1; uid=useralum; pwd=useralum00");
            SqlCommand comandosql = new SqlCommand();
            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT esp,ing FROM traduccion";
            SqlDataReader midatareader = comandosql.ExecuteReader();

            string dato1;
            string dato2;
                  
            ListViewItem milista;

            while (midatareader.Read())
            {
                dato1 = midatareader.GetString(0); //palabra español
                dato2 = midatareader.GetString(1); //palabra ingles

                milista = lvdiccionario.Items.Add(dato1);
                milista.SubItems.Add(dato2);

            }
            midatareader.Close();
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new
                //SqlConnection("MSSQLALU.ucam.edu\ucamalu; database=Diccionario; Integrated Security=SSPI");
                //Seguridad Windows.
                //Si la seguridad se hace a nivel de SQLServer hay que añadir usuario y
                //contraseña.
          SqlConnection("server=MSSQLALU.ucam.edu\\ucamalu; database=PVA1; uid=useralum; pwd=useralum00");
            SqlCommand comandosql = new SqlCommand();
            conexion.Open();
            comandosql.Connection = conexion;

            if (lbespañol.Text == "" && tbingles.Text == "") { MessageBox.Show("Debe rellenar los campos"); }
            else {
                comandosql.CommandText = "insert into traduccion (esp, ing) values('" + tbnombre.Text + "','" + tbingles.Text + "')";

            }

            
            SqlDataReader midatareader = comandosql.ExecuteReader();


            midatareader.Close();
            conexion.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
          
            SqlConnection conexion = new
                //SqlConnection("MSSQLALU.ucam.edu\ucamalu; database=Diccionario; Integrated Security=SSPI");
                //Seguridad Windows.
                //Si la seguridad se hace a nivel de SQLServer hay que añadir usuario y
                //contraseña.
          SqlConnection("server=MSSQLALU.ucam.edu\\ucamalu; database=PVA1; uid=useralum; pwd=useralum00");
            SqlCommand comandosql = new SqlCommand();
            conexion.Open();
            comandosql.Connection = conexion;

            if (lbespañol.Text == "" && tbingles.Text == "") { MessageBox.Show("Debe rellenar los campos"); }
            else
            {
                //MessageBox.Show("update traduccion set esp='" + tbnombre.Text + "', ing='" + tbingles.Text + "' where esp='" + lvdiccionario.SelectedItems[0].Text + "';");     
            comandosql.CommandText = "update traduccion set esp='" + tbnombre.Text + "', ing='" + tbingles.Text + "' where esp = '" + lvdiccionario.SelectedItems[0].Text + "';";   
            }
           
            SqlDataReader midatareader = comandosql.ExecuteReader();
            midatareader.Close();
            conexion.Close();
            button1_Click(null, null);
            tbnombre.Text = "";
            tbingles.Text = "";
         }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new
                //SqlConnection("MSSQLALU.ucam.edu\ucamalu; database=Diccionario; Integrated Security=SSPI");
                //Seguridad Windows.
                //Si la seguridad se hace a nivel de SQLServer hay que añadir usuario y
                //contraseña.
          SqlConnection("server=MSSQLALU.ucam.edu\\ucamalu; database=PVA1; uid=useralum; pwd=useralum00");
            SqlCommand comandosql = new SqlCommand();
            conexion.Open();
            comandosql.Connection = conexion;

            if (lbespañol.Text == "" && tbingles.Text == "") { MessageBox.Show("Debe rellenar los campos"); }
            else
            {
                comandosql.CommandText = "delete from traduccion where esp='" + lvdiccionario.SelectedItems[0].Text + "';";

                //MessageBox.Show("insert into traduccion (esp, ing) values('"+tbespañol.Text+"','"+tbingles.Text+"')");

            }


            SqlDataReader midatareader = comandosql.ExecuteReader();


            midatareader.Close();
            conexion.Close();

        }

        

        private void lvdiccionario_Click(object sender, EventArgs e)
        {
            this.tbnombre.Text = lvdiccionario.SelectedItems[0].Text;
            this.tbingles.Text = lvdiccionario.SelectedItems[0].SubItems[1].Text;

        }

        private void btntraducir_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new
                //SqlConnection("MSSQLALU.ucam.edu\ucamalu; database=Diccionario; Integrated Security=SSPI");
                //Seguridad Windows.
                //Si la seguridad se hace a nivel de SQLServer hay que añadir usuario y
                //contraseña.
            SqlConnection("server=MSSQLALU.ucam.edu\\ucamalu; database=PVA1; uid=useralum; pwd=useralum00");
            SqlCommand comandosql = new SqlCommand();
            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT esp,ing FROM traduccion where esp='"+txbfiltro.Text+"';";
            SqlDataReader midatareader = comandosql.ExecuteReader();

            string dato1;
            string dato2;
            while (midatareader.Read())
            {
                dato1 = midatareader.GetString(0); //palabra español
                dato2 = midatareader.GetString(1); //palabra ingles

                lbfiltro.Text = dato2;

            }
            midatareader.Close();
            conexion.Close();

        }
    }
}
