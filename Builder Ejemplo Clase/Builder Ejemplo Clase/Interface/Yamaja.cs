using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Ejemplo_Clase
{
    internal class Yamaja
    {
        public void BuildMoto(MotoBuilder moto)
        {
            moto.BuildCarroceria();
            moto.BuildLlantas();
            moto.BuildMotor();
        }
    }
}
