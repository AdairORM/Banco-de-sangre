using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            lbOPositivo.Text = $" {mililitrosPorTipoSangre["O+"]} ";
            lbONegativo.Text = $" {mililitrosPorTipoSangre["O-"]} ";
            lbAPositivo.Text = $" {mililitrosPorTipoSangre["A+"]} ";
            lbANegativo.Text = $" {mililitrosPorTipoSangre["A-"]} ";
            lbBPositivo.Text = $" {mililitrosPorTipoSangre["B+"]} ";
            lbBNegativo.Text = $" {mililitrosPorTipoSangre["B-"]} ";
            lbABPositivo.Text = $" {mililitrosPorTipoSangre["AB+"]} ";
            lbABNegativo.Text = $" {mililitrosPorTipoSangre["AB-"]} ";
        }

        // Método para agregar una donación y actualizar los labels
        private void AgregarDonacion(Donacion donacion)
        {
            donaciones.Add(donacion);
            ActualizarLabels();
        }

        public bool ExtraerSangre(string tipoSangre, double mililitros)
        {
            double cantidadDisponible = ContarMililitrosPorTipoSangre()[tipoSangre];
            if (mililitros > cantidadDisponible)
            {
                return false;
            }

            foreach (Donacion donacion in donaciones)
            {
                if (donacion.TipoDeSangre == tipoSangre)
                {
                    if (donacion.Mililitros >= mililitros)
                    {
                        donacion.Mililitros -= mililitros;
                        mililitros = 0;
                    }
                    else
                    {
                        mililitros -= donacion.Mililitros;
                        donacion.Mililitros = 0;
                    }

                    if (mililitros == 0)
                    {
                        break;
                    }
                }
            }

            donaciones = new ArrayList(donaciones.Cast<Donacion>().Where(d => d.Mililitros > 0).ToArray());
            ActualizarLabels();
            return true;
        }


        #endregion

        private void nuevaDonacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NuevaDonacion nuevaDonacion = new NuevaDonacion();
            nuevaDonacion.EnviarDonacion += AgregarDonacion;
            nuevaDonacion.ShowDialog();

        }

        
        private void donantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donaciones donaciones = new Donaciones();
            donaciones.ShowDialog();

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void transfusionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfusiones transfusionesForm = new Transfusiones();
            transfusionesForm.ShowDialog();
        }
    }
}