using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Banco_de_sangre
{
    public partial class FormBanco : Form
    {
        private ArrayList donaciones;
        public FormBanco()
        {
            InitializeComponent();
            donaciones = new ArrayList();
        }

        #region Metodos
        private void DonacionesDefault()
        {
            donaciones.Add(new Donacion("Gabriel", "18", "O+",1));
            donaciones.Add(new Donacion("Francisco", "22", "A-",1.2));



        }

        internal void AgregarDonacion(Donacion donacion)
        {
            donaciones.Add(donacion);

        }

        /*
        public int ContarDonacionesPorTipoSangre(string tipoSangre)
        {
            int contador = 0;
            foreach (Donacion donacion in donaciones)
            {
                if (donacion.TipoDeSangre == tipoSangre)
                {
                    contador++;
                }
            }
            return contador;
        }
        */



        #endregion

        private void nuevaDonacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaDonacion nuevaDonacion = new NuevaDonacion();
            nuevaDonacion.ShowDialog();
        }
    }
}
