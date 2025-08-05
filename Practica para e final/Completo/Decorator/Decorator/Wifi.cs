using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Wifi:Adicionales
    {
        public Wifi(ObjetoBase obj):base(obj) { }

        public override string Descripcion() => obj.Descripcion() + "+ " + "Agregado WIFI";
        public override double precio() => obj.precio() + 50.6;
    }
}
