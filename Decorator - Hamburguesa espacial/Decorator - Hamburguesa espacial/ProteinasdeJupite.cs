using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator___Hamburguesa_espacial
{
    public class ProteinasdeJupite:Suplementros
    {
        public ProteinasdeJupite(ComidaBase comida) : base(comida) { }

        public override double calorias()=> comida.calorias()+ 0.45;

        public override string Descripcion()=>comida.Descripcion() + "Proteinas de jupiter ";
    }
}
