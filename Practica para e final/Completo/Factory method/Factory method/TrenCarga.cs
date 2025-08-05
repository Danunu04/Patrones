using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    public class TrenCarga:Tren
    {
        public override void RegistrarCliente(string cliente)
        {
            Console.WriteLine($"Se creo el cliente {cliente} para un tren de carga");
        }
    }
}
