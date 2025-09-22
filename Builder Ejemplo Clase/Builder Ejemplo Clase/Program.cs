using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Ejemplo_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yamaja yamaha = new Yamaja();
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("----Menu----");
                Console.WriteLine("Seleccionar La moto a crear");
                Console.WriteLine("1. Scooter");
                Console.WriteLine("2. Enduro");
                Console.WriteLine("3. Pistera");
                string opcion = Console.ReadLine();
                switch(opcion)
                {
                    case "1":
                        MotoBuilder scooter = new ScooterBuilder();
                        yamaha.BuildMoto(scooter);
                        Moto motoscooter = scooter.GetMoto();
                        motoscooter.MostrarInfo();
                        break;
                    case "2":
                        MotoBuilder enduro = new EnduroBuilder();
                        yamaha.BuildMoto(enduro);
                        Moto motoEnduro = enduro.GetMoto();
                        motoEnduro.MostrarInfo();
                        break;
                    case "3":
                        MotoBuilder pistera = new PisteroBuilder();
                        yamaha.BuildMoto(pistera);
                        Moto motoPistera = pistera.GetMoto();
                        motoPistera.MostrarInfo();
                        break;
                    default:
                        Console.WriteLine("Opcion Invalida");
                        break;
                }
            }
        }
    }
}
