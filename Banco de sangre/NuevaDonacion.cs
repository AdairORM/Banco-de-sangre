using System;
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
            double mililitros;
            bool esNumero = double.TryParse(txtbMililitros.Text, out mililitros);
            //EnviarDonacion(new Donacion(txtbNombre.Text,txtbEdad.Text, txtbTipodeSangre.Text, mililitros));
            txtbNombre.Clear();
            txtbEdad.Clear();
            txtbTipodeSangre.Clear();

           
        }
    }
}
