using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator___Hamburguesa_espacial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool salir = false;
            while (!salir)
            {   ComidaBase comida = null;
                Console.WriteLine("==============================================");
                Console.WriteLine("Que Comdia desea?");
                Console.WriteLine("1. Hamburguesa Plutoneana");
                Console.WriteLine("2. Hamburguesa Terrestre");
                Console.WriteLine("0. Salir");
                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("El ingreso de datos debe ser numerico");
                }
                switch (opcion)
                {
                    case 0:
                        salir = true;
                        break;
                    case 1:
                        comida = new HamburguesaPlutoneana();
                        break;
                    case 2:
                        comida = new HamburguesaTerrestre();
                        break;
                    default:
                        Console.WriteLine("Error de seleccion las opciones validas son 1 y 2");
                        break;
                }
                bool agregado = false;
                while (!agregado)
                {
                    Console.WriteLine($"Desea agregar un suplemento a su comida? SI/NO");
                    string op = Console.ReadLine();
                    if (op.ToLower() == "si")
                    {
                        Console.WriteLine("Que desea agregar");
                        Console.WriteLine("1. Vitaminas de pluton");
                        Console.WriteLine("2. Sales marcianas");
                        Console.WriteLine("3. Proteinas de jupiter");
                        int suplemento;
                        if (!int.TryParse(Console.ReadLine(), out suplemento))
                        {
                            Console.WriteLine("Error, la entrada debe ser numérica");
                        }
                        switch (suplemento)
                        {
                            case 1:
                                comida = new VitaminasPluton(comida);
                                break;
                            case 2:
                                comida = new SalesMarcianas(comida);
                                break;
                            case 3:
                                comida = new ProteinasdeJupite(comida);
                                break;
                            default:
                                Console.WriteLine("Error de entrada, la entrada debe ser entre 1 y 3");
                                break;
                        }
                    }
                    else if (op.ToLower() == "no")
                    {
                        agregado = true;
                    }
                    else
                    {
                        Console.WriteLine("Opcion Incorrecta, la entrada debe ser en letras y debe ser SI o NO");
                    }
                }
                Console.WriteLine($"La comida seleccionada es {comida.Descripcion()} y la carga calórica es de {comida.calorias().ToString()}");
                Console.ReadKey();
            }
        }
    }
}
