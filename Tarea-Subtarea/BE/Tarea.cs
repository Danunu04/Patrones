using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tarea:Component
    {
        public List<Component>componentes=new List<Component>();
        public List<Tarea>tareas=new List<Tarea>();
        public List<SubTarea>SubTareas=new List<SubTarea>();
        public Tarea(string nombre) : base(nombre) { }
        public override void Agregar(Component componente)
        {
           componentes.Add(componente);
        }
        public override void Eliminar(Component componente)
        {
            componentes.Remove(componente);
        }
        public override void Mostrar()
        {
            foreach (Component comp in componentes)
            {
                comp.Mostrar();
            }
        }
    }
}
