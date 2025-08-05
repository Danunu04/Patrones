using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Pasaje:ObjetoBase
    { 
        public override string Descripcion() => "Pasaje base ";
        public override double precio() => 5000.80;
    }
}
