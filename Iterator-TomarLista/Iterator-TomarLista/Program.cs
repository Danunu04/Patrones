using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_TomarLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaAlumnos lista = new ListaAlumnos();
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Elija la opcion:");
                Console.WriteLine("1. Agregar alumno");
                Console.WriteLine("2. tomar lista");
                Console.WriteLine("0. Salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "0":
                        Console.WriteLine("chau");
                        salir = true;
                        Console.ReadKey();
                        break;
                    case "1":
                        Console.WriteLine("Ingrese el nombre");
                        string nombre = Console.ReadLine();
                        Alumno alumno = new Alumno(nombre);
                        lista.agregar(alumno);
                        break;
                    case "2":
                        IteradorAlumnos ia = new IteradorAlumnos(lista);
                        while(ia.HaySiguiente())
                        {
                            Alumno al = ia.Siguiente();
                            Console.WriteLine(al.Nombre.ToString());
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
