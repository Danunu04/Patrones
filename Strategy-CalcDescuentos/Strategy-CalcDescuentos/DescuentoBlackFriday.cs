using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_CalcDescuentos
{
    public class DescuentoBlackFriday:IDescuentoStrategy
    {
        public double AplicarDescuento(double precio)
        {
            Console.WriteLine("Aplicando descuento de Black Friday del 50%...");
            return precio * 0.5; // 50% de descuento
        }
    }
}
