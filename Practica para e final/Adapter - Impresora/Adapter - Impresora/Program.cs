using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter___Impresora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImpresoraAntigua impresora = new ImpresoraAntigua();
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Ingrese el mensaje a imprimir, ingresa 0 para salir");
                string mensaje = Console.ReadLine();
                if(mensaje == "0")
                {
                   salir = true;
                }
                else
                {
                    AdapterImpresora adapter = new AdapterImpresora(impresora, mensaje);
                    adapter.imprimir();
                }
            }
            
        }
    }
}
