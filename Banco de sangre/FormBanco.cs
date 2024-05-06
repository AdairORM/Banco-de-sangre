using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Collections;

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
            donaciones.Add(new Donacion("Gabriel", "17", "O+"));

        }
        #endregion
    }
}
