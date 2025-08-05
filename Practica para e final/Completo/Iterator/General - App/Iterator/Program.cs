using General___App.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General___App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaTramo lista = new ListaTramo();
            lista.Agregar(new Tramo("Tramo A"));
            lista.Agregar(new Tramo("Tramo B"));
            lista.Agregar(new Tramo("Tramo C"));

            // Crear iterador
            IteradorTramos iterador = new IteradorTramos(lista);

            // Recorrer usando el iterador
            while (iterador.TieneSiguiente())
            {
                Tramo actual = iterador.Siguiente();
                Console.WriteLine(actual.name.ToString());
            }

            Console.ReadLine();
        }
    }
}
