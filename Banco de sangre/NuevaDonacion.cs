using System;
using System.Windows.Forms;

namespace Banco_de_sangre
{
    public partial class NuevaDonacion : Form
    {
        internal delegate void DelegateDonacion(Donacion donacion);
        internal event DelegateDonacion EnviarDonacion;
        public NuevaDonacion()
        {
            InitializeComponent();
        }

        private void btnaAgregar_Click(object sender, EventArgs e)
        {
            double mililitros;
            int edad;
            bool esNumero = double.TryParse(txtbMililitros.Text, out mililitros);
            bool esEdad = int.TryParse(txtbEdad.Text,out edad);
            if (edad < 18)
            {
                MessageBox.Show("Para realizar una donación debes de ser mayor de 18 años.");
                return;
            }
            if (!esNumero || !esEdad)
            {
                MessageBox.Show("Por favor, ingresa valores válidos para edad y mililitros.");
                return;
            }

            string tipoSangre = txtbTipodeSangre.Text.ToUpper(); // Convertir a mayúsculas para evitar problemas de formato

            // Lista de tipos de sangre válidos
            string[] tiposValidos = { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };

            // Validar si el tipo de sangre ingresado es válido
            if (!Array.Exists(tiposValidos, tipo => tipo == tipoSangre))
            {
                MessageBox.Show("Por favor, ingresa un tipo de sangre válido (A+, A-, B+, B-, AB+, AB-, O+, O-).");
                return;
            }


            Donacion nuevaDonacion = new Donacion(txtbNombre.Text, edad, txtbTipodeSangre.Text, mililitros);

            if (EnviarDonacion != null)
            {
                EnviarDonacion(nuevaDonacion);
                MessageBox.Show("Donación agregada.");
                txtbNombre.Clear();
                txtbEdad.Clear();
                txtbTipodeSangre.Clear();
                txtbMililitros.Clear();
            }
            
            else
            {
                MessageBox.Show("No hay suscriptores para el evento EnviarDonacion.");
            }


        }

        private void btnSalirNuDonacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
