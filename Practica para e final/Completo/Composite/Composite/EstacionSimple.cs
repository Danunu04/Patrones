using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class EstacionSimple:Iestacion
    {
        public EstacionSimple(string nombre) : base(nombre) { }

        public override void ActivarEmergencia(Iestacion estacion)
        {
            Console.WriteLine($"EMERGENCIA EN ESTACION SIMPLE {estacion.Nombre} CORRAAAAAAAAAAAAAAAAAAAAAAAAN.");
        }
    }
}
