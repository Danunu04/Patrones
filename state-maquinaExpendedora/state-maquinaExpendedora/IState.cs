using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state_maquinaExpendedora
{
    public interface IState
    {
        void Handle(Context c, string accion);
    }
}
