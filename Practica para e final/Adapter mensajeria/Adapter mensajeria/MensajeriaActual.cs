using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_mensajeria
{
    public class MensajeriaActual:IMensajeriaInstantanea
    {
        public override void WhatsappModerno(string mensaje)
        {
            Console.WriteLine("Mensaje moderno: " + mensaje);
        }
    }
}
