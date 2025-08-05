using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory
{
    public class ConstructorMarte:IrobotConstructor
    {
        public override void ConstruirEstructura()
        {
            Console.WriteLine("construyendo en marte :) ...");
        }
    }
}
