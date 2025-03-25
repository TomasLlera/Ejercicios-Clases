using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion_Clases
{
    internal class Autos
    {
        public string patente;
        public string marca;

        public string Patente { get => patente; set => patente = value; }
        public string Marca { get => marca; set => marca = value; }

        public Autos(string patente, string marca)
        {
            Patente = patente;
            Marca = marca;
        }
    }
}
