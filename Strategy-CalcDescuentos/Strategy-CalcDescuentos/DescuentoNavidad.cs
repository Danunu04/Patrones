using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_CalcDescuentos
{
    public class DescuentoNavidad:IDescuentoStrategy
    {
        public double AplicarDescuento(double precio)
        {
            Console.WriteLine("Aplicando descuento de Navidad del 25%...");
            return precio * 0.75; // 25% de descuento
        }
    }
}
