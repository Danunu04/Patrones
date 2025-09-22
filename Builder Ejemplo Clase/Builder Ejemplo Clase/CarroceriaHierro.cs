using Builder_Ejemplo_Clase.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Ejemplo_Clase
{
    public class CarroceriaHierro:Carroceria
    {
        public string Descripcion { get { return "Carroceria de Hierro"; } }
    }
}
