using LibreriaUsuario;
using System;
using System.Collections;
using System.Windows.Forms;
using Banco_de_sangre;


namespace AutenticacionBancoDeSangre
{
    public partial class Inicio : Form
    {
        ArrayList usuarios;

        public Inicio()

        {
            InitializeComponent();
            usuarios = new ArrayList();
            AgregarUsuarios();
        }


        private void AgregarUsuarios()
        {
            usuarios.Add(new Usuario("Fernanda", "318"));
            usuarios.Add(new Usuario("Omar", "319"));
        }


        private void btnEntrar_Click_1(object sender, EventArgs e)
        {

            //
            string usuario = txtbUsuario.Text;
            string password = txtbContraseña.Text;

            for (int i = 0; i < usuarios.Count; i++)
            {
                var usuarioPass = (Usuario)usuarios[i];
                int a = 0;

                if (i <= 3)
                {
                    if (usuario == usuarioPass.Nombre && password == usuarioPass.Password)
                    {
                        FormBanco formBanco = new FormBanco();
                        formBanco.Show();

                    }

                }
                else
                {

                    MessageBox.Show("Usuario o contraseña incorrecto >:/");
                    a += a;
                    if (a == 4)
                    {
                        MessageBox.Show("Demasiados intentos");
                    }

                }


            }
            //
        }
    }
}
