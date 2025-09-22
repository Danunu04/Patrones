using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_CalcDescuentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Ingrese el mes de la compra de forma numérica: ");
                if (!int.TryParse(Console.ReadLine(), out int mes) || mes < 1 || mes > 12)
                {
                    Console.WriteLine("Mes inválido. Por favor, ingrese un número entre 1 y 12.");
                    continue;
                }
                Console.WriteLine("Ingrese el día de la compra de forma numérica: ");
                if (!int.TryParse(Console.ReadLine(), out int dia) || dia < 1 || dia > 31)
                {
                    Console.WriteLine("Día inválido. Por favor, ingrese un número entre 1 y 31.");
                    continue;
                }
                else if (mes == 2 && dia > 28 || mes == 4 && dia > 30 || mes == 6 && dia > 30 || mes == 9 && dia > 30 || mes == 11 && dia > 30)
                {
                    Console.WriteLine("Día inválido para el mes ingresado.");
                    continue;
                }
                Console.WriteLine("Ingrese el precio del producto sin el signo '$': ");
                if (!double.TryParse(Console.ReadLine(), out double precio))
                {
                    Console.WriteLine("Precio inválido. ");
                    continue;
                }
                else if (precio < 0)
                {
                    Console.WriteLine("El precio no puede ser negativo.");
                }

                Carrito_Context carrito = new Carrito_Context(mes, dia);
                double precioFinal = carrito.CalcularPrecioFinal(precio);

                Console.WriteLine("El precio original del producto era $" + precio);
                Console.WriteLine($"El precio final del producto es: ${precioFinal}");
                Console.WriteLine("Presione 1 para salir");
                if(Console.ReadLine() == "1") break;
            }
        }
    }
}
