using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_TomarLista
{
    public class ListaAlumnos:Icolleccion_alumnos
    {
        private List<Alumno> Alumnos = new List<Alumno>();
        public void agregar (Alumno alumno)
        {
            Alumnos.Add(alumno);
        }

        public int Total()
        {
            return Alumnos.Count;
        }

        public Alumno Obtener (int index)
        {
            return Alumnos[index];
        }

        public IIterator CrearIterador()=> new IteradorAlumnos(this);
    }
}
