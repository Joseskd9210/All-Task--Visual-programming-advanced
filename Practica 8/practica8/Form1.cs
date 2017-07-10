using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace practica8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            //Creamos la instancia y la ponemos visible:
            Excel.Application objExcel = new Excel.Application();
            objExcel.Visible = true; //Podríamos trabajar sin que se vea…
            //Creamos el libro y accedemos a la primera hoja:
            Excel.Workbook objLibro =objExcel.Workbooks.Add(Missing.Value);
            Excel.Worksheet objHoja =(Excel.Worksheet)objLibro.Worksheets.get_Item(1); //hoja 1.
            //Insertar en una celda
            //objHoja.Cells[1, 1] = "DNI"; //Celda A1
            //objHoja.Cells[2, 1] = 33256456; //Celda B1
            objHoja.Cells[1, 1] = textBox1.Text; //Celda A1
            objHoja.Cells[2, 1] = textBox2.Text; //Celda B1
            objHoja.Cells[1, 2] = textBox3.Text; //Celda A2
            objHoja.Cells[2, 2] = textBox4.Text; //Celda B2
            //Trabajar con fórmulas, cambios de formato y comentarios:
            Excel.Range objRango;
            objRango = objHoja.get_Range("C1", Missing.Value);
            objRango.FormulaLocal = "=SUMA(B1:B2)";
            objRango.NumberFormat = "0.00 €";
            objRango.AddComment("Ejemplo de comentario");
            objRango.Font.Bold = true;
            //Recuperar un valor:
              label6.Text = Convert.ToString(objRango.Value);

        }

        
        

        
    }
}
