using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class BLLCarpeta
    {
        MPPCarpeta MPPC= new MPPCarpeta();
        public List<Carpeta> TraerCarpetasConSCYArchivos()
        {
            return MPPC.TraerCarpetasConSCYArchivos();
        }
    }
}
