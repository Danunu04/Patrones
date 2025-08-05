using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator___Playlist
{
    public class ListaCanciones:IcoleccionCanciones
    {
        private List<Cancion> canciones = new List<Cancion>();

        public void Agregar(Cancion c) => canciones.Add(c);
        public int Total() => canciones.Count;
        public Cancion Obtener(int index) => canciones[index];

        public Iterator CrearIterator() => new IteradorCanciones(this);
    }
}
