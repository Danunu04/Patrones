using Builder_Ejemplo_Clase.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Ejemplo_Clase
{
    public class Moto
    {
        public Motor Motor;
        public Carroceria Carroceria;
        public Llantas Llantas;
        public void SetMotor(Motor motor)
        {
            this.Motor = motor;
            Console.WriteLine($"Motor asignado. {motor.Descripcion}");
        }
        public void SetCarroceria(Carroceria carroceria)
        {
            this.Carroceria = carroceria;
            Console.WriteLine($"Carroceria asignada. {carroceria.Descripcion}");
        }
        public void SetLlantas(Llantas llantas)
        {
            this.Llantas = llantas;
            Console.WriteLine($"Llantas asignadas. {llantas.Descripcion}");
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Moto creada con las siguientes especificaciones:");
            Console.WriteLine($"Motor: {Motor.Descripcion}");
            Console.WriteLine($"Carroceria: {Carroceria.Descripcion}");
            Console.WriteLine($"Llantas: {Llantas.Descripcion}");
        }
    }
}
