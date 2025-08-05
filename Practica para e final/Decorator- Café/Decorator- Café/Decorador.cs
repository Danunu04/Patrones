using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator__Café
{
    public abstract class Decorador:Bebida
    {
        protected Bebida _bebida;
        protected Decorador(Bebida bebida)
        {
            _bebida = bebida;
        }
    }
}
