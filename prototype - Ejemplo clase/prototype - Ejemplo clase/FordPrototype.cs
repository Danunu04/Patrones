using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype___Ejemplo_clase
{
    public class FordPrototype:AutoPrototype
    {
        public FordPrototype() { }

        public FordPrototype(FordPrototype source) : base(source) { }

        public override AutoPrototype Clonar()
        {
            return new FordPrototype(this);
        }
    }
}
