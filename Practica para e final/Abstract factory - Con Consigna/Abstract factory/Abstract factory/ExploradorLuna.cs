using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory
{
    public class ExploradorLuna:IrobotExplorador
    {
        public override void RecolectarMuestras()
        {
            Console.WriteLine("Recolectando muestras en la luna :) ...");
        }
    }
}
