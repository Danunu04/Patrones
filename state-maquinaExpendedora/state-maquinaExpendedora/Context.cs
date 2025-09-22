using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state_maquinaExpendedora
{
    public class Context
    {
        private IState _state;

        public Context(IState s)
        {
            SetState(s);
        }

        public void SetState(IState s)
        {
            _state = s;
        }

        public void Request(string accion) => _state.Handle(this, accion);
         
    }
}

