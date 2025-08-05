using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Iestacion
    {
        public string Nombre { get; set; }
        protected Iestacion(string n)
        {
            Nombre = n;
        }
        public virtual void Agregar(Iestacion estacion) { }
        public virtual void eliminar(Iestacion estacion) { }
        public virtual void Buscar(Iestacion estacion) { }
        public virtual void ActivarEmergencia(Iestacion estacion) { }
    }
}
