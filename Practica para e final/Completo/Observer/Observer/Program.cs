using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estacion estacion = new Estacion();
            List<Trenes> todosLosTrenes = new List<Trenes>();

            while (true)
            {
                Console.WriteLine("\n=== Menú ===");
                Console.WriteLine("1. Crear tren y suscribirlo");
                Console.WriteLine("2. Detectar incidente en estación");
                Console.WriteLine("3. Desuscribir tren");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Nombre del tren: ");
                        string nombre = Console.ReadLine();
                        Trenes nuevoTren = new Trenes(nombre);
                        todosLosTrenes.Add(nuevoTren);
                        estacion.subscribir(nuevoTren);
                        Console.WriteLine($"Tren {nombre} suscripto.");
                        break;

                    case "2":
                        Console.Write("Descripción del incidente: ");
                        string descripcion = Console.ReadLine();
                        estacion.notificar(descripcion);
                        break;

                    case "3":
                        Console.Write("Nombre del tren a quitar: ");
                        string trenAQuitar = Console.ReadLine();
                        var trenEncontrado = todosLosTrenes.FirstOrDefault(t => t.Nombre == trenAQuitar);
                        if (trenEncontrado != null)
                        {
                            estacion.desubscribir(trenEncontrado);
                            Console.WriteLine($"Tren {trenAQuitar} desuscripto.");
                        }
                        else
                        {
                            Console.WriteLine("Tren no encontrado.");
                        }
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}
