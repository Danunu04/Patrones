using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_clase
{
    public class Cajero:Aprobador
    {
        public override void ProcesarSolicitud(Prestamo p)
        {
            if (p.Monto > 0 && p.Monto <= 5000)
            {
                Console.WriteLine("El cajero ha aprobado la solicitud de: " + p.Monto.ToString());
            }
            else
            {
                _NextHandler?.ProcesarSolicitud(p);
            }
        }
    }
}
