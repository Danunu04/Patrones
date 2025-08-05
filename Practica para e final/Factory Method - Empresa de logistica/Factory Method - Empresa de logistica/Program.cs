using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method___Empresa_de_logistica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                try
                {
                    Console.WriteLine("Ingrese el medio de trasporte para generar el documento");
                    Console.WriteLine("Ingrese 0 para salir");
                    string medio = Console.ReadLine();
                    if (medio == "0")
                    {
                        salir = true;
                        break;
                    }

                    double peso;
                    Console.WriteLine("Ingrese el peso del producto a enviar");
                    if (!double.TryParse(Console.ReadLine(), out peso) || peso < 0)
                    {
                        Console.WriteLine("Peso inválido. Intente nuevamente.");
                        continue;
                    }

                    double distancia;
                    Console.WriteLine("Ingrese la distancia");
                    if (!double.TryParse(Console.ReadLine(), out distancia) || distancia < 0)
                    {
                        Console.WriteLine("Distancia inválida. Intente nuevamente.");
                        continue;
                    }

                    Cliente client = new Cliente();
                    client.GenerarEnvio(medio, peso, distancia);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
