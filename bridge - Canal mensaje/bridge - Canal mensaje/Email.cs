using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge___Canal_mensaje
{
    public class Email: ICanal
    {
        public void Enviar (string mensaje)
        {
            Console.WriteLine("Enviando Email con el mensaje: " + mensaje);
        }
    }
}
