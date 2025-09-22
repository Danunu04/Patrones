using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_CalcDescuentos
{
    public class Carrito_Context
    {
        private IDescuentoStrategy _descuentoStrategy;
        public Carrito_Context(int mes, int dia)
        {
            _descuentoStrategy = SetDescuentoStrategy(mes, dia);
        }
        public IDescuentoStrategy SetDescuentoStrategy(int mes, int dia)
        {
            if (mes == 12 && dia >= 20 && dia <= 25)
                return new DescuentoNavidad();
            else if (mes == 11 && dia >= 25 && dia <= 30)
                return new DescuentoBlackFriday();
            else
                return new SinDescuento();
        }
        public double CalcularPrecioFinal(double precio)
        {
            return _descuentoStrategy.AplicarDescuento(precio);
        }
    }
}
