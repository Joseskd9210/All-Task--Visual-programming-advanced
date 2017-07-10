using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btncolor_MouseEnter(object sender, EventArgs e)
        {
            btncolor.BackColor = btncolor.ColorDentro;
        }

        private void btncolor_MouseLeave(object sender, EventArgs e)
        {
            btncolor.BackColor = btncolor.ColorFuera;
        }
    }
}
