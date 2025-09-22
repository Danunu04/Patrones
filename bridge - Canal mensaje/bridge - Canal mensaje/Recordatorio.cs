using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge___Canal_mensaje
{
    public class Recordatorio:INotificacion
    {
        public Recordatorio(ICanal canal):base(canal)
        { }

        public override void Enviar(string mensaje)
        {
            _canal.Enviar("Recordatorio: " + mensaje);
        }
    }
}
