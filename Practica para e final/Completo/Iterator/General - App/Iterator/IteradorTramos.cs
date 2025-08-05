using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General___App.Iterator
{
    public class IteradorTramos:IIteradorTramos
    {
        private ListaTramo lista;
        private int posicion;

        public IteradorTramos(ListaTramo t)
        {
            lista = t;
        }
        public bool TieneSiguiente()
        {
            if(posicion < lista.Total())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Tramo Siguiente()
        {
            return lista.Buscar(posicion++);
        }
    }
}
