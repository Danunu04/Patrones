using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora CALCULADORA = new Calculadora();
            Caretaker caretaker = new Caretaker();
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Elija la operacion");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Restaurar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Selecciona la opcion");
                string opcion = Console.ReadLine();
                switch(opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el valor");
                        string entrada = Console.ReadLine();
                        if (int.TryParse(entrada, out int val))
                        {
                            CALCULADORA.sumar(val);
                            CALCULADORA.mostrar();
                        }
                        else
                        {
                            Console.WriteLine("Solo se permiten números");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el valor");
                        string entrada2 = Console.ReadLine(); 
                        if (int.TryParse(entrada2, out int valor))
                        {
                            CALCULADORA.restar(valor);
                            CALCULADORA.mostrar();
                        }
                        else
                        {
                            Console.WriteLine("Solo se permiten numeros");
                        }
                        break;
                    case "3":
                        caretaker.undo();
                        CALCULADORA.mostrar();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Error de seleccion");
                        break;
                }
            }
            
            
        }
    }
}
