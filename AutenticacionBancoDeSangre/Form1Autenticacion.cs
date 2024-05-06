using LibreriaUsuario;
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

namespace AutenticacionBancoDeSangre
{
    public partial class Form1 : Form
    {
        ArrayList usuarios;

        public Form1()

        {
            InitializeComponent();
            usuarios = new ArrayList();
            AgregarUsuarios();
        }


        private void AgregarUsuarios()
        {
            usuarios.Add(new Usuario("yo", "12"));
            usuarios.Add(new Usuario("el", "34"));
            usuarios.Add(new Usuario("tu", "56"));
        }

        private void btnEntrar_Click(object sender, EventArgs e)
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
                        Form1 formReproductor = new Form1();
                        formReproductor.Show();

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
