using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_sangre
{
    internal class Donacion
    {
        #region Atributos
        private string nombre;
        private string edad;
        private string tipoDeSangre;
        private double mililitros;
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Edad { get => edad; set => edad = value; }
        public string TipoDeSangre { get => tipoDeSangre; set => tipoDeSangre = value; }
        public double Mililitros { get => mililitros; set => mililitros = value; }
        #endregion

        #region Constructor
        public Donacion(string nombre, string edad, string típoDeSangre, double litros)
        {
            Nombre = nombre;
            Edad = edad;
            TipoDeSangre = tipoDeSangre;
            Mililitros = litros;
        }
        #endregion



    }
}
