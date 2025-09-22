using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge___Canal_mensaje
{
    public abstract class INotificacion
    {
        protected ICanal _canal;
        protected INotificacion(ICanal canal)
        {
            _canal = canal;
        }
        public abstract void Enviar(string mensaje);
    }
}
