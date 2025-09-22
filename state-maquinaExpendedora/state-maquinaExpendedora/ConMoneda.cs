using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace state_maquinaExpendedora
{
    public class ConMoneda: IState
    {
        public void Handle(Context c, string accion)
        {
            switch (accion)
            {
                case "insertar":
                    Console.WriteLine("⚠️ Ya hay una moneda, no puedes insertar otra.");
                    break;

                case "producto":
                    Console.WriteLine("✅ Producto entregado. Pasando al estado: Sin Moneda.");
                    c.SetState(new SinMoneda());
                    break;

                case "devolver":
                    Console.WriteLine("Moneda devuelta. Pasando al estado: Sin Moneda.");
                    c.SetState(new SinMoneda());
                    break;
            }
        }
    }
}
