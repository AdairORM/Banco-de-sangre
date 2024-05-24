using System;
using System.Text;

namespace LibreriaUsuario
{
    //Librería de registro de usuario
    public class Usuario
    {
        #region Atributos
        private string nombre;
        private string password;



        #endregion

        #region Propiedades
        public string Nombre
        {
            get => nombre;
            set
            {
                if (value == "")
                {
                    nombre = "";
                }
                else
                {
                    nombre = value;
                }

            }

        }
        public string Password
        {
            get => password;
            set
            {
                if (value == "")
                {
                    password ="";
                }
                else
                {
                    password = value;

                }
            }
        }

        #endregion


        #region Constructores
        public Usuario(string nombre, string password)
        {
            Nombre = nombre;
            Password = password;
        }

        #endregion


    }
}

