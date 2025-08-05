using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_TomarLista
{
    public interface IIterator
    {
        bool HaySiguiente();
        Alumno Siguiente();
    }
}
