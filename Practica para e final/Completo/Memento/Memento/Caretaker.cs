using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Caretaker
    {
        private List<Memento>historial = new List<Memento>();
        public void Agregar(Memento memento)
        {
            historial.Add(memento);
        }

        public Memento Undo()
        {
            if (historial.Count > 0)
            {
                Memento m = historial[historial.Count - 1];
                historial.RemoveAt(historial.Count - 1);
                return m;
            }
            return null;
        }
    }
}
