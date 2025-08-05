using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDNI
{
    public interface IDocumentoValidador
    {
        bool EsValido(string Documento);
    }
}
