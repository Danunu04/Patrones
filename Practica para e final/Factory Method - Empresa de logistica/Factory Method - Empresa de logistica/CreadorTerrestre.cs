using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method___Empresa_de_logistica
{
    public class CreadorTerrestre :CreadorDeDocumetos
    {
        public override DocEnvio CrearDocumento()
        {
            DocTerreste terrestre = new DocTerreste();
            return terrestre;
        }
    }
}
