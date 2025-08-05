using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator___Hamburguesa_espacial
{
    public class HamburguesaTerrestre:ComidaBase
    {
        public override string Descripcion() => "Hamburguesa terrestre ";
        public override double calorias() => 50.2;
    }
}
