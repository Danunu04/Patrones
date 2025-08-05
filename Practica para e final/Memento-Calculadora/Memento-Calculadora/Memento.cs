using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Calculadora
{
    public class Memento
    {
        private int valor;
        public Memento(int val)
        {
            valor = val;
        }
        public int estadoCalculadora()
        {
            return valor;
        }
    }
}
