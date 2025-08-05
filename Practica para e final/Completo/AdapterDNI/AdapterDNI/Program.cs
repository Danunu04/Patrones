using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDocumentoValidador> validadores = new List<IDocumentoValidador>
            {
                
                new RegistroInternacionalAdapter(),new RegistroNacionalAdapter()
            };

            while (true)
            {
                Console.WriteLine("\n--- VERIFICADOR DE DOCUMENTOS ---");
                Console.WriteLine("1. Validar documento");
                Console.WriteLine("2. Salir");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.Write("Ingrese el documento (DNI o Pasaporte-Código): ");
                    string doc = Console.ReadLine();

                    bool valido = false;
                    foreach (var validador in validadores)
                    {
                        try
                        {
                            if (validador.EsValido(doc))
                            {
                                valido = true;
                                break;
                            }
                        }
                        catch
                        {
                            // Ignorar excepciones, seguir con el siguiente validador
                        }
                    }

                    Console.WriteLine(valido
                        ? "Documento válido."
                        : "Documento inválido.");
                }
                else if (opcion == "2")
                    break;
                else
                    Console.WriteLine("Opción no válida.");
            }
        }
    }
}
