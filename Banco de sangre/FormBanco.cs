using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Banco_de_sangre
{
    public partial class FormBanco : Form
    {

        private static ArrayList donaciones = new ArrayList();
        public static ArrayList Donaciones
        {
            get { return donaciones; }
        }
        public FormBanco()
        {
            InitializeComponent();
            // Cargar y mostrar los mililitros de sangre al iniciar el formulario
            ActualizarLabels();
        }

        #region Metodos



        // Método para contar los mililitros de sangre por tipo de sangre
        private Dictionary<string, double> ContarMililitrosPorTipoSangre()
        {
            Dictionary<string, double> mililitrosPorTipoSangre = new Dictionary<string, double>
            {
                { "O+", 0 },
                { "O-", 0 },
                { "A+", 0 },
                { "A-", 0 },
                { "B+", 0 },
                { "B-", 0 },
                { "AB+", 0 },
                { "AB-", 0 }
            };

            foreach (Donacion donacion in donaciones)
            {
                if (mililitrosPorTipoSangre.ContainsKey(donacion.TipoDeSangre))
                {
                    mililitrosPorTipoSangre[donacion.TipoDeSangre] += donacion.Mililitros;
                }
            }

            return mililitrosPorTipoSangre;
        }

        // Método para actualizar los labels en el formulario
        public void ActualizarLabels()
        {
            var mililitrosPorTipoSangre = ContarMililitrosPorTipoSangre();
            lbOPositivo.Text = $"O+: {mililitrosPorTipoSangre["O+"]} ";
            lbONegativo.Text = $"O-: {mililitrosPorTipoSangre["O-"]} ";
            lbAPositivo.Text = $"A+: {mililitrosPorTipoSangre["A+"]} ";
            lbANegativo.Text = $"A-: {mililitrosPorTipoSangre["A-"]} ";
            lbBPositivo.Text = $"B+: {mililitrosPorTipoSangre["B+"]} ";
            lbBNegativo.Text = $"B-: {mililitrosPorTipoSangre["B-"]} ";
            lbABPositivo.Text = $"AB+: {mililitrosPorTipoSangre["AB+"]} ";
            lbABNegativo.Text = $"AB-: {mililitrosPorTipoSangre["AB-"]} ";
        }

        // Método para agregar una donación y actualizar los labels
        private void AgregarDonacion(Donacion donacion)
        {
            donaciones.Add(donacion);
            ActualizarLabels();
        }

        #endregion

        private void nuevaDonacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NuevaDonacion nuevaDonacion = new NuevaDonacion();
            nuevaDonacion.EnviarDonacion += AgregarDonacion;
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