using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObjetoBase pasaje = new Pasaje();
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Personalización de Pasaje ===");
                Console.WriteLine("1. Agregar WiFi");
                Console.WriteLine("2. Agregar Comida");
                Console.WriteLine("3. Ver descripción actual");
                Console.WriteLine("4. Finalizar");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        pasaje = new Wifi(pasaje);
                        Console.WriteLine("WiFi agregado.");
                        break;
                    case "2":
                        pasaje = new Comida(pasaje);
                        Console.WriteLine("Comida agregada.");
                        break;
                    case "3":
                        Console.WriteLine("Tu pasaje incluye: " + pasaje.Descripcion() + pasaje.precio().ToString());
                        break;
                    case "4":
                        salir = true;
                        Console.WriteLine("Pasaje final: " + pasaje.Descripcion() + pasaje.precio().ToString());
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
