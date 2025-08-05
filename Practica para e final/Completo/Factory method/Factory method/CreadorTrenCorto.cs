using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    public class CreadorTrenCorto:Creador
    {
        public override Tren crearTren()
        {
            TrenCorto tc = new TrenCorto();
            return tc;
        }
    }
}
