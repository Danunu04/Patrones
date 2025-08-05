using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator___Hamburguesa_espacial
{
    public abstract class Suplementros:ComidaBase
    {
        protected ComidaBase comida;
        public Suplementros(ComidaBase comida)
        {
            this.comida = comida;
        }
    }
}
