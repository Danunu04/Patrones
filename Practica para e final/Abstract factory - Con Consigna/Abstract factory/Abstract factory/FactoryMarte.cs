using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory
{
    public class FactoryMarte:IRobotFactory
    {
        public override IrobotConstructor CrearConstructor()
        {
            ConstructorMarte cm = new ConstructorMarte();
            return cm;
        }
        public override IrobotExplorador CrearExplorador()
        {
            ExploradorMarte em = new ExploradorMarte();
            return em;
        }
    }
}
