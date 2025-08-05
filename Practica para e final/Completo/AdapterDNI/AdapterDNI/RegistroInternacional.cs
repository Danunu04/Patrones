using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDNI
{
    public class RegistroInternacional
    {
        internal int CheckPassport(int numero, string pais)
        {
            if(numero > 10000 && !string.IsNullOrEmpty(pais))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
