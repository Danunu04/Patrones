using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDNI
{
    public class RegistroNacionalAdapter:IDocumentoValidador
    {
        RegistroNacional Nacional = new RegistroNacional();
        public bool EsValido(string documento)
        {
            if (Nacional.ValidarDocumento(documento))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
