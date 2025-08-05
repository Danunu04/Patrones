using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory
{
    public class Cliente
    {
        private IrobotExplorador _explorador;
        private IrobotConstructor _constructor;
        public void CrearFabrica (IRobotFactory factory)
        {
            _explorador = factory.CrearExplorador();
            _constructor = factory.CrearConstructor();
        }
        public void ejecutarSimulacion()
        {
            _explorador.RecolectarMuestras();
            _constructor.ConstruirEstructura();
        }
    }
}
