using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_de_sangre
{
    public partial class NuevaDonacion : Form
    {
        internal delegate void DelegateDonacion( Donacion donacion);
        internal event DelegateDonacion EnviarDonacion;
        public NuevaDonacion()
        {
            InitializeComponent();
        }

        private void btnaAgregar_Click(object sender, EventArgs e)
        {
            double miliL;
            bool esNumero = double.TryParse(txtbMililitros.Text, out miliL);
            EnviarDonacion(new Donacion(txtbNombre.Text,txtbEdad.Text, txtbTipodeSangre.Text, miliL));
            txtbNombre.Clear();
            txtbEdad.Clear();
            txtbTipodeSangre.Clear();
            txtbMililitros.Clear();
        }
    }
}
