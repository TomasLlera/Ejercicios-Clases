using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion_Clases
{
    internal class Contacto
    {
        public string nombre;
        public long telefono;
        public string direccion;
        public string Nombre { get => nombre; set => nombre = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public Contacto(string nombre, long telefono, string direccion)
        {
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}
