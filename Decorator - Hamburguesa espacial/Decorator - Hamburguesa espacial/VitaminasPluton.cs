using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator___Hamburguesa_espacial
{
    public class VitaminasPluton:Suplementros
    {
        public VitaminasPluton(ComidaBase comida) : base(comida) { }
        public override string Descripcion() => comida.Descripcion() + "Vitaminas de pluton ";
        public override double calorias() => comida.calorias() + 20.8;
    }
}
