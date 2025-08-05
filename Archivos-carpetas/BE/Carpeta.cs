using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BE
{
    public class Carpeta:Component
    {
        public List<Component>componenes = new List<Component>();
        public List<Carpeta> carpeta = new List<Carpeta>();
        public List<Archivo> archivo = new List<Archivo>();
        public Carpeta(string nombre) : base(nombre) { }

        // Método para agregar un componente (archivo o carpeta)
        public override void Agregar(Component elemento)
        {
            componenes.Add(elemento);
        }

        // Método para eliminar un componente
        public override void Eliminar(Component elemento)
        {
            componenes.Remove(elemento);
        }

        // Método para mostrar la información de la carpeta y sus componentes
        public override void Mostrar()
        {
            Console.WriteLine($"Carpeta: {Name}");
            foreach (var componente in componenes)
            {
                componente.Mostrar(); // Llamada recursiva a mostrar el contenido
            }
        }

        // Método para obtener los elementos dentro de la carpeta
        public List<Component> ObtenerElementos()
        {
            return componenes;
        }
    }
}
