using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Calculadora
{
    public class Calculadora
    {
        private int valor;

        public void sumar(int val)
        {
            valor += val;
        }
        public void restar (int val)
        {
            valor -= val;
        }
        public void mostrar()
        {
            Console.WriteLine("Resultado actual: " + valor);
        }
        public void restore (Memento m)
        {
            valor = m.estadoCalculadora();
        }
    }
}
