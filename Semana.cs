using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion_Clases
{
    internal class Semana
    {
        public List<Temperatura> temperaturas;

        public Semana()
        {
            temperaturas = new List<Temperatura>();
        }

        string[] dia = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

        public void Menu()
        {
            bool salida = false;
            do
            {
                Console.Clear();
                Console.WriteLine(new string('=', 41));
                Console.WriteLine("|  Bienvenido al servicio meteorologo   |");
                Console.WriteLine(new string('-', 41));
                Console.WriteLine("|  A continuacion seleccione una opcion |");
                Console.WriteLine(new string('=', 41));
                Console.WriteLine("1. Agregar temperatura");
                Console.WriteLine("2. Mostrar temperaturas");
                Console.WriteLine("3. Salir.");
                char opc = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (opc)
                {
                    case '1':
                        AgregarTemperatura();
                        break;
                    case '2':
                        MostrarTemperatura();
                        break;
                    case '3':
                        salida = true;
                        break;
                    default:
                        break;
                }
            } while (!salida);
        }
        public void AgregarTemperatura()
        {
            for (int i = 0; i < dia.Length; i++)
            {
                Console.WriteLine($"Ingrese la temperatura del {dia[i]}:");
                double valor;
                bool esValido = false;

                while (!esValido)
                {
                    string entrada = Console.ReadLine();
                    esValido = double.TryParse(entrada, out valor);
                    if (!esValido)
                    {
                        Console.WriteLine("Por favor, ingrese un valor válido para la temperatura:");
                    }
                    temperaturas.Add(new Temperatura(dia[i], valor));
                }
                
            }
        }
        public void MostrarTemperatura()
        {
            if (temperaturas.Count == 0)
            {
                Console.WriteLine("No hay temperaturas registradas.");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < temperaturas.Count - 1; i++)
            {
                for (int j = 0; j < temperaturas.Count - i - 1; j++)
                {
                    if (temperaturas[j].Valor < temperaturas[j + 1].Valor)
                    {
                        var temp = temperaturas[j];
                        temperaturas[j] = temperaturas[j + 1];
                        temperaturas[j + 1] = temp;
                    }
                }
            }
            
            foreach (var temperatura in temperaturas)
            {
                Console.WriteLine($"Dia:{temperatura.dia,10} | Temperatura:{temperatura.valor}");
            }
            double maxtemp = temperaturas.Max(t => t.valor);
            double mintemp = temperaturas.Min(t => t.valor);
            double promedio = temperaturas.Average(t => t.valor);

            Console.WriteLine($"Temperatura maxima:{maxtemp}");
            Console.WriteLine($"Temperatura minima:{mintemp}");
            Console.WriteLine($"Temperatura promedio:{promedio}");

            Console.ReadKey();
        }
    }
}
