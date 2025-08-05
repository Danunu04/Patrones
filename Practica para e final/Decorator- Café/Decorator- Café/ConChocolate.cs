using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator__Café
{
    public class ConChocolate:Decorador
    {
        public ConChocolate(Bebida bebida): base(bebida) { }
        public override string descripcion() => _bebida.descripcion() + "Con chocolate ";
        public override double costo() => _bebida.costo() + 50.0;
    }
}
