using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator___Playlist
{
    public interface Iterator
    {
        bool HaySiguiente();
        Cancion Siguiente();
    }
}
