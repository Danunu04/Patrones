using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDNI
{
    public class RegistroInternacionalAdapter:IDocumentoValidador
    {
        RegistroInternacional internacional = new RegistroInternacional();
        public bool EsValido(string Documento)
        {
            try
            {
                var Partes = Documento.Split('-');
                int numero = int.Parse(Partes[0].Replace("A","").Replace("B", ""));
                string pais = Partes[1];
                int valido = internacional.CheckPassport(numero, pais);
                if(valido == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
