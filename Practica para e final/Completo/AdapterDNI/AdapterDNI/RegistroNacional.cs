using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDNI
{
    public class RegistroNacional
    {
        internal bool ValidarDocumento(string documento)
        {
            return documento.All(Char.IsDigit)&&documento.Length==8;
        }
    }
}
