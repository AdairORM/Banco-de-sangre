using LibreriaUsuario;
using System;


namespace TestingLibreriaUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Usuario miUsuario = new Usuario("", "");

            Console.WriteLine("nombre {0} \n password: {1}", miUsuario.Nombre, miUsuario.Password);
            Console.ReadLine();
        }
    }
}
