using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator___Playlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaCanciones canciones = new ListaCanciones();
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("1. Agregar cancion a la cola");
                Console.WriteLine("2. Reproducir");
                Console.WriteLine("0. Salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "0":
                        salir = true;
                        break;
                    case "1":
                        Console.WriteLine("Ingrese el titulo de la cancion");
                        string titulo = Console.ReadLine();
                        Cancion cancion = new Cancion(titulo);
                        canciones.Agregar(cancion);
                        break;
                    case "2":
                        Iterator iterador = canciones.CrearIterator();
                        while (iterador.HaySiguiente())
                        {
                            Console.WriteLine(iterador.Siguiente().titulo);
                            Console.ReadKey();
                        }
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                
                }
            }
            
        }
    }
}
