using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Memento
    {
        private string estado;
        public void setState(string estado)
        { this.estado = estado; }

        public string getState()
        {
            return estado;
        }
    }
}
