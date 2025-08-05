using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator___Playlist
{
    public class IteradorCanciones:Iterator
    {
        private ListaCanciones cancions;
        int posicion = 0;
        public IteradorCanciones(ListaCanciones canciones)
        {
            this.cancions = canciones;
        }
        public bool HaySiguiente() => posicion < cancions.Total();

        public Cancion Siguiente() => cancions.Obtener(posicion++);
    }
}
