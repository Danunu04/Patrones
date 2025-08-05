using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter___Impresora
{
    public class ImpresoraAntigua
    {
        internal void imprimirTexto(string mensaje)
        {
            Console.WriteLine("El texto a imprimir es " + mensaje);
        }
    }
}
