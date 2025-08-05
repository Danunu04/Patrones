using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_mensajeria
{
    public class JeroglificosAdapter:IMensajeriaInstantanea
    {
        Jeroglificos jero = new Jeroglificos();
        public override void WhatsappModerno(string mensaje)
        {
            jero.MensajeJeroglifico(mensaje);
        }
    }
}
