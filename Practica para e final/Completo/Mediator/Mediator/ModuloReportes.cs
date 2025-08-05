using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ModuloReportes:ModuloBase
    {
        public ModuloReportes(Mediator m) : base(m) { }
        public override void Accion()
        {
            Console.WriteLine("Reportes: Reporte generado con éxito.");
        }
    }
}
