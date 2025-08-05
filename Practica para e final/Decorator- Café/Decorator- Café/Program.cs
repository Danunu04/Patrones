using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator__Café
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new CafeSimple();
            Console.WriteLine("Hola buen dia, esta comprando " + Convert.ToString(bebida.descripcion()) + " Aprete 0 para salir");
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Ingrese el agregado deseado");
                Console.WriteLine("1. Leche");
                Console.WriteLine("2. Chocolate");
                Console.WriteLine("0. Salir");
                string opcion = Console.ReadLine();
                if( opcion == "0")
                {
                    Console.WriteLine("el producto elegido es " + bebida.descripcion().ToString() + "Valor: "+bebida.costo().ToString());
                    salir = true;
                }
                else if (opcion == "1")
                {
                    bebida = new ConLche(bebida);
                    Console.WriteLine("el producto elegido es " + bebida.descripcion().ToString() + "Valor: " + bebida.costo().ToString());
                }
                else if( opcion == "2") 
                {
                    bebida = new ConChocolate(bebida);
                    Console.WriteLine("el producto elegido es " + bebida.descripcion().ToString() + "Valor: " + bebida.costo().ToString());
                }
                else
                {
                    Console.WriteLine("Seleccione una opcion valida");
                }
            }
            Console.ReadKey();
        }
    }
}
