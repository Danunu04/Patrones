using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Tren
    {
        private string estado;

        public void registrarEstado(string estado)
        { this.estado = estado; }
        public Memento GuardarEstado()
        {
            Memento me = new Memento(); 
            me.setState(estado);
            return me;
        }

        public void RestaurarEstado (Memento m)
        {
            estado = m.getState();
        }
    }
}
