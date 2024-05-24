using System;
using System.Linq;
using System.Windows.Forms;

namespace Banco_de_sangre
{
    public partial class Transfusiones : Form
    {
        public Transfusiones()
        {
            InitializeComponent();
            // Agregar tipos de sangre al ComboBox
            cbTipoSangre.Items.AddRange(new string[] { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" });
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            string tipoSangre = cbTipoSangre.SelectedItem?.ToString();
            double mililitros;
            bool esNumero = double.TryParse(txtbMililitros.Text, out mililitros);

            if (string.IsNullOrEmpty(tipoSangre))
            {
                MessageBox.Show("Por favor, selecciona un tipo de sangre.");
                return;
            }
            if (!esNumero || mililitros <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida de mililitros.");
                return;
            }

            FormBanco formBanco = Application.OpenForms.OfType<FormBanco>().FirstOrDefault();
            if (formBanco != null)
            {
                bool exito = formBanco.ExtraerSangre(tipoSangre, mililitros);
                if (exito)
                {
                    MessageBox.Show("Extracción realizada con éxito.");
                }
                else
                {
                    MessageBox.Show("No hay suficiente sangre disponible para la extracción.");
                }
            }
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
