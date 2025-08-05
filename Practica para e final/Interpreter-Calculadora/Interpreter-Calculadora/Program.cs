using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (salir)
            {
                Console.WriteLine("Ingrese la operacion a realizar");
                Console.WriteLine("Aprete 0 para salir");
                string opcion = Console.ReadLine();
                if (opcion =="0")
                {
                    salir = true;
                }
                else if (opcion.Contains("+") || opcion.Contains("-"))
                {
                    char operador = opcion.Contains("+") ? '+' : '-';
                    string[] partes = opcion.Split(operador);

                    if (partes.Length == 2 && int.TryParse(partes[0].Trim(), out _) && int.TryParse(partes[1].Trim(), out _))
                    {
                        if (opcion.Contains("+"))
                        {
                            string[] par = opcion.Split('+');
                            if (par.Length == 2 &&
                                int.TryParse(par[0].Trim(), out int n1) &&
                                int.TryParse(par[1].Trim(), out int n2))
                            {
                                Console.WriteLine("Suma: " + (n1 + n2));
                            }
                            else
                            {
                                Console.WriteLine("Expresión inválida.");
                            }
                        }
                        else if (opcion.Contains("-"))
                        {
                            string[] parts = opcion.Split('-');
                            if (parts.Length == 2 &&
                                int.TryParse(parts[0].Trim(), out int n1) &&
                                int.TryParse(parts[1].Trim(), out int n2))
                            {
                                Console.WriteLine("Resta: " + (n1 - n2));
                            }
                            else
                            {
                                Console.WriteLine("Expresión inválida.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Expresión inválida.");
                    }
                }

            }

        }
    }
}
