using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Banco_de_sangre
{
    public partial class FormBanco : Form
    {

        public FormBanco()
        {
            InitializeComponent();

        }

        #region Metodos




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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void donantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donaciones donaciones = new Donaciones();
            donaciones.ShowDialog();

        }
    }
}