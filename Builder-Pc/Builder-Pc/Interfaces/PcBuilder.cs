using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pc
{
    public interface PcBuilder
    {
        void BuildRAM();
        void BuildMother();
        void BuildCPU();
    }
}
