using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General___App.Iterator
{
    public interface IIteradorTramos
    {
        bool TieneSiguiente();
        Tramo Siguiente();
    }
}
