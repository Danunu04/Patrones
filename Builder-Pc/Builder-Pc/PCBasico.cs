using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pc
{
    public class PCBasico: PcBuilder
    {
        PC pc = new PC();
        public void BuildRAM()
        {
            pc.ColocarRam(new Ram8GB());
        }

        public void BuildMother()
        {
            pc.ColocarMother(new MotherMeh());
        }   

        public void BuildCPU()
        {
            pc.ColocarCPU(new CPU_I3());
        }

        internal PC ObtenerProducto()
        {
            return pc;
        }
    }
}
