using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BE
{
    public class Archivo:Component
    {
        public Archivo(string nombre) : base(nombre) { }

        public override void Agregar(Component elemento)
        {
            throw new NotImplementedException("Un archivo no puede contener otros elementos.");
        }

        public override void Eliminar(Component elemento)
        {
            throw new NotImplementedException("Un archivo no puede eliminar elementos.");
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Archivo: {Name}");
        }
    }
}
