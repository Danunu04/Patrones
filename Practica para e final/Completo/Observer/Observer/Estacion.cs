using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Estacion:subject
    {
        private List<Observer> TrenesCercanos = new List<Observer>();
        public void subscribir(Observer observer)
        {
            TrenesCercanos.Add(observer);
        }
        public void desubscribir(Observer observer)
        {
            TrenesCercanos.Remove(observer);
        }

        public void notificar(string descripcion)
        {
            Console.WriteLine($"Estación: {descripcion}");
            foreach (Trenes tren in TrenesCercanos)
                tren.notificar("Incidente: " + descripcion);
        }
    }
}
