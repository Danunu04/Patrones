using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MotorCentral motor = new MotorCentral();
            bool salir = false;
            while(!salir)
            {
                Console.WriteLine("================================");
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("1. Utilizar el motor central");
                Console.WriteLine("2. Ver si alguien esta utilizando el motor central");
                Console.WriteLine("3. Dejar de utilizar el motor central");
                Console.WriteLine("0. Salir");
                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opcion incorrecta, la entrada debe de ser numérica");
                }
                switch (opcion)
                {
                    case 0:
                        salir = true;
                        break;
                    case 1:
                        Console.WriteLine("Ingrese su nombre");
                        string nombre = Console.ReadLine();
                        motor.usuario = nombre;
                        MotorCentral.LogIn();
                        break;
                    case 2:
                        if(MotorCentral.GetInstance == null)
                        {
                            Console.WriteLine("motor central libre");
                        }
                        else
                        {
                            Console.WriteLine("motor central en uso");
                        }
                        break;
                    case 3:
                        MotorCentral.LogOut();
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
        }
    }
}
