using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface subject
    {
        void subscribir (Observer observer);
        void desubscribir(Observer observer);
        void notificar(string descripcion);
    }
}
