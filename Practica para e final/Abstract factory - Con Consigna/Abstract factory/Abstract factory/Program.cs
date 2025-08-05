using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            bool salir = false;
            while(!salir)
            {
                Console.WriteLine("=======================================================================");
                Console.WriteLine("Elija el planeta en el que generar la simulacion");
                Console.WriteLine("1. Marte");
                Console.WriteLine("2. Luna");
                Console.WriteLine("3. Venus");
                Console.WriteLine("0. Salir");
                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Las opciones a ingresar deben ser numéricas");
                    return;
                }
                switch( opcion )
                {
                    case 0:
                        salir = true;
                        break;
                    case 1:
                        cliente.CrearFabrica(new FactoryMarte());
                        cliente.ejecutarSimulacion();
                        Console.WriteLine("");
                        break;
                    case 2:
                        cliente.CrearFabrica(new FactoryLuna());
                        cliente.ejecutarSimulacion();
                        Console.WriteLine("");
                        break;
                    case 3:
                        cliente.CrearFabrica(new FactoryVenus());
                        cliente.ejecutarSimulacion();
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Opcion seleccionada erronea, las opciones van entre el 0 y 3 :)");
                        break;
                }
                
            }
            Console.WriteLine("Nos vemos :b");
            Console.ReadKey();
        }
    }
}
