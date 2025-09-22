using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype___Ejemplo_clase
{
    public class Motor
    {
        public double Numero { get; set; } 
        public string Potencia { get; set; }

        public Motor(double n, string potencia)
        {
            Numero = n;
            Potencia = potencia;
        }
    }
}
