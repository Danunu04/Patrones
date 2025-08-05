using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator___Hamburguesa_espacial
{
    public class SalesMarcianas:Suplementros
    {
        public SalesMarcianas(ComidaBase comida) : base(comida) { }

        public override string Descripcion()=> comida.Descripcion() + "Sales marcianas ";
        public override double calorias() => comida.calorias() + 30.3;
    }
}
