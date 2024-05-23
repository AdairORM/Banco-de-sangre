using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Banco_de_sangre
{
    public partial class Donaciones : Form

    {
        private static ArrayList donaciones = new ArrayList();
        public Donaciones()
        {
            InitializeComponent();
            CargarDonaciones();
        }

       
        private void CargarDonaciones()
        {
            // Limpiar la lista de donaciones antes de cargarlas
            lstbListaDonantes.Items.Clear();
            // Iterar sobre cada donación y agregarla a la lista
            foreach (Donacion donacion in donaciones)
            {
                lstbListaDonantes.Items.Add(donacion.Nombre);
            }
        }

        internal void AgregarDonación(Donacion donacion)
        {
            // Agregar la nueva donación a la lista de donaciones
            donaciones.Add(donacion);
            // Actualizar la lista de donaciones en el formulario FormBanco
            lstbListaDonantes.Items.Add(donacion.Nombre);
        }

        private void cargToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonacionesDefault();
            
        }

        private void DonacionesDefault()
        {
            if (donaciones.Count == 0) // Solo agregar donaciones por defecto si la lista está vacía
            {
                donaciones.Add(new Donacion("Gabriel", 18, "O", 0.5));
                donaciones.Add(new Donacion("Francisco", 22, "A-", 0.2));
                CargarDonaciones();
            }
        }

        private void lstbListaDonantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbListaDonantes.SelectedIndex != -1)
            {
                Donacion miDonacion = (Donacion)donaciones[lstbListaDonantes.SelectedIndex];
                lbNombre.Text = miDonacion.Nombre;
                lbEdad.Text = miDonacion.Edad.ToString();
                lbTipoDeSangre.Text = miDonacion.TipoDeSangre;
                lbMililitros.Text = miDonacion.Mililitros.ToString();
            }
        }

        private void nuevaDonaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaDonacion nuevaDonacion = new NuevaDonacion();
            nuevaDonacion.EnviarDonacion += AgregarDonación;
            nuevaDonacion.ShowDialog();
        }

        private void btnSalirDonaciones_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
