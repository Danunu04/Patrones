using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n--- MENÚ TOKEN MANAGER ---");
                Console.WriteLine("1. Obtener instancia");
                Console.WriteLine("2. Generar token");
                Console.WriteLine("3. Ver cantidad de accesos");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();
                TokenManager tm = null;

                switch (opcion)
                {
                    case "1":
                        tm = TokenManager.GenInstance();
                        Console.WriteLine("✔ Instancia obtenida.");
                        break;

                    case "2":
                        tm = TokenManager.GenInstance();
                        Console.WriteLine("🔐 Token generado: " + tm.GenerarToken());
                        break;

                    case "3":
                        Console.WriteLine("🔁 Accesos acumulados: " + TokenManager.ObtenerCantidadAccesos());
                        break;

                    case "4":
                        salir = true;
                        Console.WriteLine("👋 Cerrando aplicación.");
                        break;

                    default:
                        Console.WriteLine("❌ Opción inválida.");
                        break;
                }
            }
            Console.ReadKey();
        }
        
    }
}
