using Builder_Ejemplo_Clase.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Ejemplo_Clase
{
    public interface MotoBuilder
    {
        void BuildMotor();
        void BuildCarroceria();
        void BuildLlantas();
        Moto GetMoto();
    }
}
