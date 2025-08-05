using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator__Café
{
    public class ConLche: Decorador
    {
        public ConLche(Bebida bebida) : base(bebida) { }

        public override string descripcion() => _bebida.descripcion() + "Con leche ";
        public override double costo() => _bebida.costo() + 50.0;
    }
}
