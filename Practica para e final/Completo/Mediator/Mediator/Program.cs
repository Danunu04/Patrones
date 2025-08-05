using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediador = new ConcreteMediator();

            var control = new ModuloCDT(mediador);
            var vias = new ModuloADV(mediador);
            var reportes = new ModuloReportes(mediador);

            mediador.ControlDeTrafico = control;
            mediador.AsignacionDeVias = vias;
            mediador.Reportes = reportes;

            while (true)
            {
                Console.WriteLine("\n=== Menú ===");
                Console.WriteLine("1. Detectar tren");
                Console.WriteLine("2. Asignar vía");
                Console.WriteLine("3. Generar reporte");
                Console.WriteLine("0. Salir");

                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        control.Accion();
                        break;
                    case "2":
                        vias.Accion();
                        break;
                    case "3":
                        reportes.Accion();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
