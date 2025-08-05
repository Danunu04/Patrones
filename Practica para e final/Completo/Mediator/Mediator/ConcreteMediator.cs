using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ConcreteMediator:Mediator
    {
        public ModuloCDT ControlDeTrafico {  get; set; }
        public ModuloADV AsignacionDeVias { get; set; }
        public ModuloReportes Reportes { get; set; }

        public void notificar(object remitente, string evento)
        {
            if (evento == "TrenDetectado")
            {
                Console.WriteLine("Mediator: Tren detectado. Asignando vía...");
                AsignacionDeVias.Accion();
            }
            else if (evento == "ViaAsignada")
            {
                Console.WriteLine("Mediator: Vía asignada. Generando reporte...");
                Reportes.Accion();
            }
        }
    }
}
