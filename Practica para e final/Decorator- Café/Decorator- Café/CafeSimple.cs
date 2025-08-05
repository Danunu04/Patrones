using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator__Café
{
    public class CafeSimple:Bebida
    {
        public override string descripcion() => "Cafe simple ";

        public override double costo() => 100.0;
    }
}
