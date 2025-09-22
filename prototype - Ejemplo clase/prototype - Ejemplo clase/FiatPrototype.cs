using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype___Ejemplo_clase
{
    public class FiatPrototype : AutoPrototype
    {
        public FiatPrototype() { }

        public FiatPrototype(FiatPrototype source) : base(source) { }

        public override AutoPrototype Clonar()
        {
            return new FiatPrototype(this);
        }
    }
}
