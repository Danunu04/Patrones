using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder PC");
            Director miDirector = new Director();
            Console.WriteLine("que desea hacer?");

            Console.WriteLine("1- Armar PC basico");
            Console.WriteLine("2- Armar PC premiun");
            string opcion = Console.ReadLine();

            switch(opcion)
            {
                case "1":
                    PCBasico pcBasico = new PCBasico();
                    miDirector.ArmarPC(pcBasico);
                    PC pc = pcBasico.ObtenerProducto();
                    pc.MostrarPC();
                    break;
                case "2":
                    PCPremiun pcPremiun = new PCPremiun();
                    miDirector.ArmarPC(pcPremiun);
                    PC Pcp = pcPremiun.ObtenerProducto();
                    Pcp.MostrarPC();
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
        }
    }
}
