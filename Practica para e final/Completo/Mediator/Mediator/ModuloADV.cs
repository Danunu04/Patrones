using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ModuloADV:ModuloBase
    {
        public ModuloADV(Mediator m) : base(m) { }
        public override void Accion()
        {
            Console.WriteLine("Asignación de Vías: Vía asignada al tren.");
            mediator.notificar(this, "ViaAsignada");
        }
    }
}
