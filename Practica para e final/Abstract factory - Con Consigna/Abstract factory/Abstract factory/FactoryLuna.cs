using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory
{
    public class FactoryLuna:IRobotFactory
    {
        public override IrobotConstructor CrearConstructor()
        {
            ConstructorLuna cm = new ConstructorLuna();
            return cm;
        }
        public override IrobotExplorador CrearExplorador()
        {
            ExploradorLuna em = new ExploradorLuna();
            return em;
        }
    }
}
