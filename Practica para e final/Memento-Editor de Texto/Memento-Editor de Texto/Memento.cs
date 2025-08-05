using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Editor_de_Texto
{
    public class Memento
    {
        private string estado = "";

        public Memento(string state)
        {
            estado = state;
        }

        public string getState()
        {
            return estado;
        }
    }
}
