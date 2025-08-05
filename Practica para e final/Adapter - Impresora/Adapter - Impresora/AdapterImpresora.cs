using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter___Impresora
{
    public class AdapterImpresora:Impresora
    {
        private ImpresoraAntigua impresoraAntigua;
        private string mensaje;

        public AdapterImpresora(ImpresoraAntigua imp, string Mensaje)
        {
            impresoraAntigua = imp;
            mensaje = Mensaje;
        }
        public void imprimir()
        {
            impresoraAntigua.imprimirTexto(mensaje);
        }
    }
}
