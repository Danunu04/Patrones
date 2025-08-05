using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static Estacion_compuesta raiz = new Estacion_compuesta("Central");
        static Dictionary<string, Iestacion> estaciones = new Dictionary<string, Iestacion>();

        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ DE ESTACIONES ===");
                Console.WriteLine("1. Agregar Estación Simple");
                Console.WriteLine("2. Agregar Estación Compuesta");
                Console.WriteLine("3. Ver Estructura");
                Console.WriteLine("4. Buscar Estación");
                Console.WriteLine("5. Activar Emergencia");
                Console.WriteLine("6. Salir");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarEstacionSimple();
                        break;
                    case "2":
                        AgregarEstacionCompuesta();
                        break;
                    case "3":
                        MostrarEstructura();
                        break;
                    case "4":
                        Buscar();
                        break;
                    case "5":
                        Activar();
                        break;
                    case "6":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        static void AgregarEstacionSimple()
        {
            Console.Write("Nombre de la estación simple: ");
            string nombre = Console.ReadLine();

            if (estaciones.ContainsKey(nombre))
            {
                Console.WriteLine("Ya existe una estación con ese nombre.");
                return;
            }

            var estacion = new EstacionSimple(nombre);
            estaciones[nombre] = estacion;
            raiz.Agregar(estacion);

            Console.WriteLine("Estación simple agregada.");
        }

        static void AgregarEstacionCompuesta()
        {
            Console.Write("Nombre de la estación compuesta: ");
            string nombre = Console.ReadLine();

            if (estaciones.ContainsKey(nombre))
            {
                Console.WriteLine("Ya existe una estación con ese nombre.");
                return;
            }

            var compuesta = new Estacion_compuesta(nombre);
            estaciones[nombre] = compuesta;

            Console.WriteLine("¿Desea agregarle componentes ahora? (s/n)");
            if (Console.ReadLine().ToLower() == "s")
            {
                while (true)
                {
                    Console.Write("Ingrese nombre de estación hija (vacío para salir): ");
                    string hija = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(hija)) break;

                    if (estaciones.TryGetValue(hija, out var e))
                        compuesta.Agregar(e);
                    else
                        Console.WriteLine("No se encontró esa estación.");
                }
            }

            raiz.Agregar(compuesta);
            Console.WriteLine("Estación compuesta agregada.");
        }

        static void Buscar()
        {
            Console.Write("Nombre de la estación a buscar: ");
            string nombre = Console.ReadLine();
            if (estaciones.TryGetValue(nombre, out var e))
                raiz.Buscar(e);
            else
                Console.WriteLine("No se encontró esa estación.");
        }

        static void Activar()
        {
            Console.Write("Nombre de la estación a activar emergencia: ");
            string nombre = Console.ReadLine();
            if (estaciones.TryGetValue(nombre, out var e))
                raiz.ActivarEmergencia(e);
            else
                Console.WriteLine("No se encontró esa estación.");
        }

        static void MostrarEstructura()
        {
            Console.WriteLine("=== ESTACIONES CARGADAS ===");
            foreach (var kvp in estaciones)
            {
                Console.WriteLine($"- {kvp.Key} ({kvp.Value.GetType().Name})");
            }
        }
    }
}
