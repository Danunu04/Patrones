using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator___ChatRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChatRoom chat = new ChatRoom();

            Usuario juan = new Usuario("Juan");
            Usuario maria = new Usuario("Maria");
            Usuario pedro = new Usuario("Pedro");

            chat.Registrar(juan);
            chat.Registrar(maria);
            chat.Registrar(pedro);

            juan.Enviar("Hola a todos!");
            maria.Enviar("¡Hola Juan!");
            Console.ReadKey();
        }
    }
}
