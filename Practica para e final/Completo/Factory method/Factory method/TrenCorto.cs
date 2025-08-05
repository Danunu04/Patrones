using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    public class TrenCorto:Tren
    {
        public override void RegistrarCliente(string cliente)
        {
            Console.WriteLine($"Cliente: {cliente} creado para un tren corto");
        }
    }
}
