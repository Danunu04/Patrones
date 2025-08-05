using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator___ChatRoom
{
    public interface IChatRoom
    {
        void EnviarMensaje(string Mensaje, Usuario u);
    }
}
