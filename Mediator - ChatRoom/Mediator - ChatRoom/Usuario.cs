using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator___ChatRoom
{
    public class Usuario
    {
        public string Nombre { get;}
        public IChatRoom ChatRoom { get; set; }

        public Usuario(string nombre)
        {
            Nombre = nombre;
        }

        public void Enviar(string mensaje)
        {
            Console.WriteLine($"{Nombre} envía: {mensaje}");
            ChatRoom.EnviarMensaje(mensaje, this);
        }
        public void recibir (string mensaje, string remitente)
        {
            Console.WriteLine($"{Nombre} recibe de {remitente}: {mensaje}");
        }
    }
}
