using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Editor_de_Texto
{
    public class Caretaker
    {
        List <Memento> mementos = new List <Memento> ();
        public void add (Memento memento)
        {
            mementos.Add (memento);
        }

        public Memento undo ()
        {
            Memento m = null;
            if (mementos.Count > 0)
            {
                m = mementos[mementos.Count - 1];
                mementos.RemoveAt (mementos.Count - 1);
                
            }
            else
            {
                Console.WriteLine("Error");
            }
            return m;
        }

        internal bool TieneEstados()
        {
            if(mementos.Count > 0)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}
