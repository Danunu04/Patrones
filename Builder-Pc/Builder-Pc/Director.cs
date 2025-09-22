using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pc
{
    public class Director
    {
        public void ArmarPC(PcBuilder pConstructor)
        {
            pConstructor.BuildCPU();
            pConstructor.BuildMother();
            pConstructor.BuildRAM();
        }
    }
}
