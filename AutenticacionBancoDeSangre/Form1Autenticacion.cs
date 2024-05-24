using LibreriaUsuario;
using System;
using System.Collections;
using System.Windows.Forms;
using Banco_de_sangre;
using System.Drawing.Text;


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
            int intentosFallidos = 0;
            
            string usuario = txtbUsuario.Text;
            string password = txtbContraseña.Text;
            bool loginExitoso = false;

            foreach (var item in usuarios)
            {
                var usuarioPass = (Usuario)item;
               

                if (usuario == usuarioPass.Nombre && password == usuarioPass.Password)
                {
                    loginExitoso = true;
                    FormBanco formBanco = new FormBanco();
                    formBanco.Show();
                    this.Hide(); // Para ocultar el formulario de login actual
                    break;

                }
                if (!loginExitoso)
                {
                   
                    if (intentosFallidos == 2)
                    {
                        MessageBox.Show("Demasiados intentos. El acceso ha sido bloqueado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Puedes agregar lógica adicional aquí, como deshabilitar el botón o cerrar la aplicación.
                        btnEntrar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña o usuario erróneo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    intentosFallidos++;
                    break;
                }


            }
            //
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido \n\n  Para poder acceder por favor ingresa el usuario y la contraseña \n Sugerencia, entrar con: \n \n Fernanda \n  \n 318");

        }
    }
}
