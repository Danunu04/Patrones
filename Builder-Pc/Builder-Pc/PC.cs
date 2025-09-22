using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pc
{
    public class PC
    {
        ICPU cpu;
        Mother mother;
        RAM ram;
        internal void ColocarCPU(ICPU cPU_I3)
        {
            Console.WriteLine("Colocando CPU: " + cPU_I3.Descripcion);
            cpu = cPU_I3;
        }

        internal void ColocarMother(Mother motherMeh)
        {
            Console.WriteLine("Colocando Mother: " + motherMeh.Descripcion);
            mother = motherMeh;
        }

        internal void ColocarRam(RAM ram8GB)
        {
            Console.WriteLine("Colocando RAM: " + ram8GB.Descripcion);
            ram = ram8GB;
        }

        public void MostrarPC()
        {
            Console.WriteLine("PC Armado. \nMother: {0}\nRAM: {1}\nCPU: {2}", mother.Descripcion, ram.Descripcion, cpu.Descripcion);
        }
    }
}
