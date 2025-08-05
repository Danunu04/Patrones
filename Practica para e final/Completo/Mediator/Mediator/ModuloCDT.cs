using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ModuloCDT:ModuloBase
    {
        public ModuloCDT(Mediator m):base(m) { }
        public override void Accion()
        {
            Console.WriteLine("Control de Tráfico: Tren detectado.");
            mediator.notificar(this, "TrenDetectado");
        }
    }
}
