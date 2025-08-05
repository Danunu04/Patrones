using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    public class CreadorTrenCarga:Creador
    {
        public override Tren crearTren()
        {
            TrenCarga tc = new TrenCarga();
            return tc;
        }
    }
}
