using Builder_Ejemplo_Clase.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Ejemplo_Clase
{
    public class EnduroBuilder:MotoBuilder
    {
        Moto moto = new Moto();
        public void BuildMotor()
        {
            moto.SetMotor(new Motor250cc());
        }
        public void BuildCarroceria()
        {
            moto.SetCarroceria(new CarroceriaAluminio());
        }
        public void BuildLlantas()
        {
            moto.SetLlantas(new Llantas22());
        }
        public Moto GetMoto()
        {
            return moto;
        }
    }
}
