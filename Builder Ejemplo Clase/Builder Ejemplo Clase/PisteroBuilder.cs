using Builder_Ejemplo_Clase.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Ejemplo_Clase
{
    public class PisteroBuilder:MotoBuilder
    {
        public Moto moto = new Moto();
        public void BuildMotor()
        {
            moto.SetMotor(new Motor500cc());
        }
        public void BuildCarroceria()
        {
            moto.SetCarroceria(new CarroceriaCarbono());
        }
        public void BuildLlantas()
        {
            moto.SetLlantas(new Llantas19());
        }
        public Moto GetMoto()
        {
            return moto;
        }
    }
}
