using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Adicionales:ObjetoBase
    {
        protected ObjetoBase obj;
        protected Adicionales(ObjetoBase o)
        {
            obj = o;
        }
    }
}
