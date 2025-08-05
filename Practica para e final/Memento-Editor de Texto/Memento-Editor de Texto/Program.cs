using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Editor_de_Texto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EditorDeTexto editor = new EditorDeTexto();
            Caretaker historial = new Caretaker();
            bool salir = false;
            while (!salir) 
            {
                Console.WriteLine("Seleccione la operacion a realizar");
                Console.WriteLine("1. Escribir");
                Console.WriteLine("2. Restaurar");
                Console.WriteLine("3. Salir");
                string opcion = Console.ReadLine();
                switch(opcion)
                {
                    case "1":
                        {
                            Console.WriteLine("Ingrese el texto...");
                            string contenido = Console.ReadLine();
                            historial.add(editor.GuardarEstado());
                            editor.escribir(contenido);
                            Console.WriteLine("texto agregado");
                            editor.Mostrarcontenido();
                            break;
                        }
                    case "2":
                        {
                            if (historial.TieneEstados())
                            {
                                editor.restaurar(historial.undo());
                                editor.Mostrarcontenido();
                            }
                            else
                            {
                                Console.WriteLine("No hay estados para restaurar.");
                            }
                            break;
                        }
                    case "3":
                        {
                            salir = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("seleccion erronea");
                            break;
                        }
                }
            }
            Console.ReadKey();
            
        }
    }
}
