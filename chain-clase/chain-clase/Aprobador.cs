using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_clase
{
    public abstract class Aprobador //Handler
    {
        protected Aprobador _NextHandler;
        public void SetNextHandler(Aprobador Nexthandler)
        {
            this._NextHandler = Nexthandler;
        }

        public abstract void ProcesarSolicitud(Prestamo p);
    }
}
