using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PrediccionMeteorologica
    {
        public double predecirtemp()
        {
            Random random = new Random();
            double temp = random.NextDouble() * 10;
            return temp;
        }

        public DateTime dia()
        {
            DateTime dia = DateTime.Now.AddDays(1);
            return dia;
        }
    }
}
