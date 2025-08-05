using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class ModuloBase
    {
        protected Mediator mediator;
        protected ModuloBase(Mediator m)
        {
            mediator = m;
        }

        public abstract void Accion();
    }
}
