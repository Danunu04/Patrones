using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tren tren = new Tren();
            Caretaker caretaker = new Caretaker();
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Simulación de Tren ===");
                Console.WriteLine("1. Registrar nuevo estado");
                Console.WriteLine("2. Guardar estado");
                Console.WriteLine("3. Restaurar último estado");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingresar descripción del estado (ej: velocidad, posición, etc): ");
                        string estado = Console.ReadLine();
                        tren.registrarEstado(estado);
                        break;
                    case "2":
                        caretaker.Agregar(tren.GuardarEstado());
                        Console.WriteLine("Estado guardado.");
                        Console.ReadKey();
                        break;
                    case "3":
                        var m = caretaker.Undo();
                        if (m != null)
                        {
                            tren.RestaurarEstado(m);
                            Console.WriteLine("Estado restaurado.");
                        }
                        else
                        {
                            Console.WriteLine("No hay estados guardados.");
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
