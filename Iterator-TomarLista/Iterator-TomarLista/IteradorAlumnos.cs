using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_TomarLista
{
    public class IteradorAlumnos:IIterator
    {
        private ListaAlumnos lista;
        private int posicion;

        public IteradorAlumnos(ListaAlumnos la)
        {
            lista = la;
        }

        public bool HaySiguiente()
        {
            if (posicion < lista.Total())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Alumno Siguiente()
        {
            return lista.Obtener(posicion++);
        }
    }
}
