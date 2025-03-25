using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion_Clases
{
    internal class Temperatura
    {
        public string dia;
        public double valor;
        public string Dia { get => dia; set => dia = value; }
        public double Valor { get => valor; set => valor = value; }

        public Temperatura(string dia, double valor)
        {
            Dia = dia;
            Valor = valor;
        }
    }
}
