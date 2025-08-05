using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Comida:Adicionales
    {
        public Comida(ObjetoBase obj):base(obj) { }

        public override string Descripcion()=> obj.Descripcion() + "+ "+"Agregado comida";
        public override double precio() => obj.precio() + 1500.68;
    }
}
