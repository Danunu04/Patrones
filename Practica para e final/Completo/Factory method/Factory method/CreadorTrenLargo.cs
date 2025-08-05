using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    public class CreadorTrenLargo:Creador
    {
        public override Tren crearTren()
        {
            TrenLargo tl = new TrenLargo();
            return tl;
        }
    }
}
