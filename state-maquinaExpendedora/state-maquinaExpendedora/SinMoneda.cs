using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state_maquinaExpendedora
{
    public class SinMoneda: IState
    {
        public void Handle(Context context, string accion)
        {
            switch (accion)
            {
                case "insertar":
                    Console.WriteLine("Has insertado una moneda. Pasando al estado: Con Moneda.");
                    context.SetState(new ConMoneda());
                    break;

                case "producto":
                    Console.WriteLine("⚠️ No puedes seleccionar un producto sin insertar una moneda.");
                    break;

                case "devolver":
                    Console.WriteLine("⚠️ No hay moneda para devolver.");
                    break;
            }
        }
    }
}
