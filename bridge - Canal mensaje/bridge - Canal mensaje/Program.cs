using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge___Canal_mensaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            INotificacion notificacion = null;
            string mensaje = string.Empty;
            while (continuar)
            {
                Console.WriteLine("Bridge - Canal mensaje");
                Console.WriteLine("----------------------");
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("1. Enviar Alerta por Email");
                Console.WriteLine("2. Enviar Alerta por SMS");
                Console.WriteLine("3. Enviar Recordatorio por Email");
                Console.WriteLine("4. Enviar Recordatorio por SMS");
                Console.WriteLine("9. Salir");
                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Console.WriteLine("Opcion no valida, solo la entrada nuemrica está permitida");
                }
                switch (opcion)
                {
                    case 1:
                        notificacion = new Alerta(new Email());
                        Console.WriteLine("Ingrese el mensaje de la alerta:");
                        mensaje = Console.ReadLine();
                        notificacion.Enviar(mensaje);
                        break;
                    case 2:
                        notificacion = new Alerta(new SMS());
                        Console.WriteLine("Ingrese el mensaje de la alerta:");
                        mensaje = Console.ReadLine();
                        notificacion.Enviar(mensaje);
                        break;
                    case 3:
                        notificacion = new Recordatorio(new Email());
                        Console.WriteLine("Ingrese el mensaje del recordatorio:");
                        mensaje = Console.ReadLine();
                        notificacion.Enviar(mensaje);
                        break;
                    case 4:
                        notificacion = new Recordatorio(new SMS());
                        Console.WriteLine("Ingrese el mensaje del recordatorio:");
                        mensaje = Console.ReadLine();
                        notificacion.Enviar(mensaje);
                        break;
                    case 9:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }
    }
}
