using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace boton_v2.cs
{
    public partial class boton_v2 : Button
    {
        private Color _ColorDentro = Color.Blue;
        private Color _ColorFuera = Color.White;
        private bool _AplicarColor = true;
        public Color ColorDentro
        {
            get { return _ColorDentro; }
            set { _ColorDentro = value; }
        }
        public Color ColorFuera
        {
            get { return _ColorFuera; }
            set { _ColorFuera = value; }
        }
        public bool AplicarColor
        {
            get { return _AplicarColor; }
            set { _AplicarColor = value; }
        }
    }
}
