using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aprobador cajero = new Cajero();
            Aprobador gerenteSucursal = new GerenteSucursal();
            Aprobador gerenteRegional = new GerenteRegional();

            cajero.SetNextHandler(gerenteSucursal);
            gerenteSucursal.SetNextHandler(gerenteRegional);
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Ingrese el monto del prestamo a solicitar:");
                if(!double.TryParse(Console.ReadLine(), out double monto))
                {
                    Console.WriteLine("Monto invalido, intente de nuevo.");
                    continue;
                }
                Prestamo p = new Prestamo(monto);
                cajero.ProcesarSolicitud(p);
            }
        }
    }
}
