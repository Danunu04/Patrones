using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Registro de Clientes en Trenes ===");
                Console.WriteLine("1. Tren Corto");
                Console.WriteLine("2. Tren Largo");
                Console.WriteLine("3. Tren de Carga");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione tipo de tren: ");
                string opcion = Console.ReadLine();

                Creador creador = null;

                switch (opcion)
                {
                    case "1":
                        creador = new CreadorTrenCorto();
                        break;
                    case "2":
                        creador = new CreadorTrenLargo();
                        break;
                    case "3":
                        creador = new CreadorTrenCarga();
                        break;
                    case "4":
                        salir = true;
                        continue;
                    default:
                        Console.WriteLine("Opción inválida.");
                        Console.ReadKey();
                        continue;
                }

                Console.Write("Ingrese nombre del cliente: ");
                string cliente = Console.ReadLine();

                Tren tren = creador.crearTren();
                tren.RegistrarCliente(cliente);

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
