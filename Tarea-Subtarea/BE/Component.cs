using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class Component
    {
        public string Name { get; set; }
        public Component(string nombre)
        {
            Name = nombre;
        }
        public abstract void Agregar(Component componente);
        public abstract void Eliminar(Component componente);
        public abstract void Mostrar();
    }
}
