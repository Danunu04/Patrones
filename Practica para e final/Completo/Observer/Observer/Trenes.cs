using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Trenes:Observer
    {
        public string Nombre;
        public Trenes(string n)
        {
            Nombre = n;
        }
        public void notificar(string mensaje)
        {
            Console.WriteLine($"Tren {Nombre} recibe alerta: {mensaje}");
        }
    }
}
