using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion_Clases
{
    internal class Agenda
    {
        public List<Contacto> contactos;

        public Agenda()
        {
            contactos = new List<Contacto>();
        }
        public void Menu()
        {
            bool salida = false;
            do
            {
                Console.Clear();
                Console.WriteLine(new string('=', 41));
                Console.WriteLine("|  Bienvenido a la agenda de contactos  |");
                Console.WriteLine(new string('-', 41));
                Console.WriteLine("|  A continuacion seleccione una opcion |");
                Console.WriteLine(new string('=', 41));
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Salir.");
                char opc = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (opc)
                {
                    case '1':
                        AgregarContacto();
                        break;
                    case '2':
                        MostrarContactos();
                        break;
                    case '3':
                        salida = true;
                        break;
                    default:
                        break;
                }
            } while (!salida);
        }
        public void AgregarContacto()
        {
            Console.WriteLine("Ingrese el nombre del contacto:");
            string nombre = Console.ReadLine();
            while (string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("Por favor ingrese un nombre valido:");
                nombre = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el numero de telefono:");
            string numero = Console.ReadLine();
            long telefono;
            bool esValido = long.TryParse(numero, out telefono);
            while (!esValido)
            {
                numero = Console.ReadLine();
                esValido = long.TryParse(numero, out telefono);
                if (!esValido)
                {
                    Console.WriteLine("Por favor ingrese un telefono valido:");
                }
            }

            Console.WriteLine("Ingrese la direccion del contacto:");
            string direccion = Console.ReadLine();

            contactos.Add(new Contacto(nombre, telefono, direccion));
            Console.WriteLine("Contacto agregado exitosamente");
        }
        public void MostrarContactos()
        {
            if (contactos.Count == 0)
            {
                Console.WriteLine("No hay contactos en la lista");
                Console.ReadKey();
                return;
            }
            Console.WriteLine(new string('=', 80));
            Console.WriteLine("| {0,-20} | {1,-15} | {2,-30} |", "Nombre", "Teléfono", "Dirección");
            Console.WriteLine(new string('=', 80));

            foreach (var contacto in contactos)
            {
                Console.WriteLine("| {0,-20} | {1,-15} | {2,-30} |", contacto.Nombre, contacto.Telefono, contacto.Direccion);
            }

            Console.WriteLine(new string('=', 80));
            Console.ReadKey();
        }
    }
}
