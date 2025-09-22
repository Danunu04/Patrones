using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_clase
{
    public class GerenteSucursal: Aprobador
    {
        public override void ProcesarSolicitud(Prestamo p)
        {
            if (p.Monto > 5000 && p.Monto <= 50000)
            {
                Console.WriteLine("El gerente de sucursal ha aprobado la solicitud de: " + p.Monto.ToString());
            }
            else
            {
                _NextHandler?.ProcesarSolicitud(p);
            }
        }
    }
}
