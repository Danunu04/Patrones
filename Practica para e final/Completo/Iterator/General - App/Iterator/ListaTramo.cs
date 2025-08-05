using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General___App.Iterator
{
    public class ListaTramo:IListaTramos
    {
        private List<Tramo> listaTramo;

        public ListaTramo()
        {
            listaTramo = new List<Tramo>();
        }
        public int Total()
        {
            return listaTramo.Count;
        }

        public Tramo Buscar(int posicion)
        {
            return listaTramo[posicion];
        }

        public void Agregar(Tramo t)
        {
            listaTramo.Add(t);
        }
    }
}
