using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BE
{
    public abstract class Component
    {
        public string Name { get; set; }
        public Component(string nombre)
        {
            Name = nombre;
        }
        public abstract void Agregar(Component elemento);
        public abstract void Eliminar(Component elemento);
        public abstract void Mostrar();
    }
}
