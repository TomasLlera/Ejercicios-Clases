using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion_Clases
{
    internal class Cochera
    {
        public List<Autos> auto;
        public Cochera()
        {
            auto = new List<Autos>();
        }

        public void Menu()
        {
            Cochera cochera = new Cochera();
            bool salida = false;
            do
            {
                Console.Clear();
                Console.WriteLine(new string('=', 41));
                Console.WriteLine("|    Bienvenido al servicio de cochera  |");
                Console.WriteLine(new string('-', 41));
                Console.WriteLine("|  A continuacion seleccione una opcion |");
                Console.WriteLine(new string('=', 41));
                Console.WriteLine("1. Ingreso de auto");
                Console.WriteLine("2. Egreso de auto");
                Console.WriteLine("3. Salir.");
                char opc = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (opc)
                {
                    case '1':
                        IngresoDeAutos();
                        break;
                    case '2':
                        EgresoDeAutos();
                        break;
                    case '3':
                        salida = true;
                        break;
                    default:
                        break;
                }
            } while (!salida);
        }
        public void EgresoDeAutos()
        {
            if (auto.Count == 0)
            {
                Console.WriteLine("No hay autos en la cochera.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Ingrese la patente a buscar:");
            string patenteIngresada = Console.ReadLine();

            Autos autoBuscado = null;
            foreach (var autos in auto)
            {
                if (autos.Patente == patenteIngresada)
                {
                    autoBuscado = autos;
                    break; 
                }
            }

            if (autoBuscado != null)
            {
                auto.Remove(autoBuscado);
                Console.WriteLine($"Auto de marca {autoBuscado.Marca} con patente {autoBuscado.Patente} eliminada.");

                Console.WriteLine("Lista de autos actualizada:");
                foreach (var autos in auto)
                {
                    Console.WriteLine($"Marca: {autos.Marca}, Patente: {autos.Patente}");  
                }
            }
            else
            {
                Console.WriteLine("La patente no se encuentra en la lista.");
                Console.WriteLine("Estas son las patentes ingresadas:");
                foreach (var autos in auto)
                {
                    Console.WriteLine($"Marca: {autos.Marca}, Patente: {autos.Patente}");
                }
            }
            Console.ReadKey();
        }
        public void IngresoDeAutos()
        {
            Console.WriteLine("Ingrese la patente del auto:");
            string patenteIngresada = Console.ReadLine();

            foreach (var autos in auto)
            {
                if (autos.Patente == patenteIngresada)
                {
                    Console.WriteLine("¡Error! La patente ya está registrada en la cochera.");
                    return;  
                }
            }

            Console.WriteLine("Ingrese la marca del auto:");
            string marcaIngresada = Console.ReadLine();

            auto.Add(new Autos(patenteIngresada, marcaIngresada));
            Console.WriteLine("Auto ingresado exitosamente.");

            Console.WriteLine("Lista de autos actualizada:");
            foreach (var autos in auto)
            {
                Console.WriteLine($"Marca: {autos.Marca}, Patente: {autos.Patente}");
            }
        }
    }
}
