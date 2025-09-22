using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state_maquinaExpendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new SinMoneda());

            while (true)
            {
                Console.WriteLine("\n=== Máquina Expendedora ===");
                Console.WriteLine("1. Insertar Moneda");
                Console.WriteLine("2. Seleccionar Producto");
                Console.WriteLine("3. Devolver Moneda");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        context.Request("insertar");
                        break;
                    case "2":
                        context.Request("producto");
                        break;
                    case "3":
                        context.Request("devolver");
                        break;
                    case "4":
                        Console.WriteLine("Saliendo...");
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}
