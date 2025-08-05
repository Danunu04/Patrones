using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_mensajeria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Escriba el mensaje a enviar, escriba 0 para salir");
                string mensaje = Console.ReadLine();
                if(mensaje == "0")
                {
                    salir = true;
                }
                IMensajeriaInstantanea mesg = new MensajeriaActual();
                IMensajeriaInstantanea jero = new JeroglificosAdapter();
                mesg.WhatsappModerno(mensaje);
                jero.WhatsappModerno(mensaje);
                Console.ReadKey();
            }
        }
    }
}
