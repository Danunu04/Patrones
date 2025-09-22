using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype___Ejemplo_clase
{
    public abstract class AutoPrototype
    {
        public Motor motor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int cantidadPuertas { get; set; }

        protected AutoPrototype()
        {}

        protected AutoPrototype(AutoPrototype source)
        {
            motor = source.motor;
            Marca = source.Marca;
            Modelo = source.Modelo;
            cantidadPuertas = source.cantidadPuertas;
        }
        public abstract AutoPrototype Clonar();  

    }
}
