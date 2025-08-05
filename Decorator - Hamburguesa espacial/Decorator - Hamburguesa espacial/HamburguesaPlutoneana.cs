using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator___Hamburguesa_espacial
{
    public class HamburguesaPlutoneana:ComidaBase
    {
        public override string Descripcion() => "Hambueguesa Plutoneana ";
        public override double calorias() => 100.50;
    }
}
