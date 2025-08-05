using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory
{
    public class FactoryVenus:IRobotFactory
    {
        public override IrobotConstructor CrearConstructor()
        {
            ConstructorVenus cm = new ConstructorVenus();
            return cm;
        }
        public override IrobotExplorador CrearExplorador()
        {
            ExploradorVenus em = new ExploradorVenus();
            return em;
        }
    }
}
