using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_CalcDescuentos
{
    public class SinDescuento:IDescuentoStrategy
    {
        public double AplicarDescuento(double precio)
        {
            Console.WriteLine("No se aplica ningún descuento.");
            return precio; // Sin descuento
        }
    }
}
