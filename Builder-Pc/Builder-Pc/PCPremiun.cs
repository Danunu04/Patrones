using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pc
{
    public class PCPremiun:PcBuilder
    {
        public PC pc = new PC();
        public void BuildRAM()
        {
            pc.ColocarRam(new Ram16GB());

        }

        public void BuildMother()
        {
            pc.ColocarMother(new MotherPro());
        }

        public void BuildCPU()
        {
            pc.ColocarCPU(new CPU_I9());
        }

        internal PC ObtenerProducto()
        {
            return pc;
        }
    }
}
