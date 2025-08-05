using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method___Empresa_de_logistica
{
    public class CreadorAereo:CreadorDeDocumetos
    {
        public override DocEnvio CrearDocumento()
        {
            DocAereo Aereo = new DocAereo();
            return Aereo;
        }
    }
}
