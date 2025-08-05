using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator___ChatRoom
{
    public class ChatRoom:IChatRoom
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public void Registrar(Usuario usuario)
        {
            usuarios.Add(usuario);
            usuario.ChatRoom = this;
        }

        public void EnviarMensaje (string Mensaje, Usuario u)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario != u)
                    usuario.recibir(Mensaje, u.Nombre);
            }
        }
    }
}
