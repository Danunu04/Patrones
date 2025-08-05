using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdaptadorPrediccionMeteorologica:InterfaesCompatibles
    {
        PrediccionMeteorologica pred = new PrediccionMeteorologica();
        public void funcion()
        {
            double temp = pred.predecirtemp();
            DateTime dia = pred.dia();
            Console.WriteLine($"La temperatura para el dia {dia} va a ser de {temp}°C");
        }
    }
}
