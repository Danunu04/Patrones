using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class SubTarea:Component
    {
        public SubTarea(string nombre) : base(nombre) { }
        public override void Agregar(Component componente)
        {
            throw new NotImplementedException("Error");
        }
        public override void Eliminar(Component componente)
        {
            throw new NotImplementedException("Error");
        }
        public override void Mostrar()
        {
            throw new NotImplementedException("Error");
        }
    }
}
