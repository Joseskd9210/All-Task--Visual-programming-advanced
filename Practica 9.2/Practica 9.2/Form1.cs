using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_9_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void traduccionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.traduccionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pVA1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  Carga datos y elimina los datos o los añade.

            this.traduccionTableAdapter.Fill(this.pVA1DataSet.traduccion);
            this.traduccionTableAdapter.Fill(this.pVA1DataSet.traduccion);

        }

        private void traduccionBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.traduccionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pVA1DataSet);

        }
    }
}
