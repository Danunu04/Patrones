using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype___Ejemplo_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    List <AutoPrototype> Autos = new List<AutoPrototype>();
            //    FordPrototype fiesta = new FordPrototype
            //    {
            //        Marca = "Ford",
            //        Modelo = "Fiesta",
            //        cantidadPuertas = 3,
            //        motor = new Motor(1.6, "cc")
            //    };

            //    FordPrototype focus = new FordPrototype
            //    {
            //        Marca = "Ford",
            //        Modelo = "Focus",
            //        cantidadPuertas = 3,
            //        motor = new Motor(2.0, "cc")
            //    };

            //    FiatPrototype palio = new FiatPrototype
            //    {
            //        Marca = "Fiat",
            //        Modelo = "Palio",
            //        cantidadPuertas = 3,
            //        motor = new Motor(1.3, "cc")
            //    };

            //    FiatPrototype siena = new FiatPrototype
            //    {
            //        Marca = "Fiat",
            //        Modelo = "Siena",
            //        cantidadPuertas = 3,
            //        motor = new Motor(1.6, "cc")
            //    };

            //    // Clonamos para obtener versiones de 5 puertas
            //    AutoPrototype fiesta5 = fiesta.Clonar();
            //    fiesta5.cantidadPuertas = 5;

            //    AutoPrototype focus5 = focus.Clonar();
            //    focus5.cantidadPuertas = 5;

            //    AutoPrototype palio5 = palio.Clonar();
            //    palio5.cantidadPuertas = 5;

            //    AutoPrototype siena5 = siena.Clonar();
            //    siena5.cantidadPuertas = 5;

            //    // Agregamos todos a la lista
            //    Autos.Add(fiesta);
            //    Autos.Add(fiesta5);
            //    Autos.Add(focus);
            //    Autos.Add(focus5);
            //    Autos.Add(palio);
            //    Autos.Add(palio5);
            //    Autos.Add(siena);
            //    Autos.Add(siena5);

            //    // Mostrar en consola
            //    Console.WriteLine("=== Autos creados con Prototype ===");
            //    foreach (var auto in Autos)
            //    {
            //        Console.WriteLine($"Auto marca = {auto.Marca}\n " +
            //            $"Modelo = {auto.Modelo}\n " +
            //            $"Cantidad de Puertas: {auto.cantidadPuertas.ToString()}\n " +
            //            $"Motor = {auto.motor.Numero} {auto.motor.Potencia}");
            //        Console.WriteLine("--------------------------------------------------");
            //        Console.WriteLine("");
            //    }
            //}

            // Prototipos base
            FordPrototype fiesta = new FordPrototype { Marca = "Ford", Modelo = "Fiesta", cantidadPuertas = 3, motor = new Motor(1.6, "cc") };
            FordPrototype focus = new FordPrototype { Marca = "Ford", Modelo = "Focus", cantidadPuertas = 3, motor = new Motor(2.0, "cc") };
            FiatPrototype palio = new FiatPrototype { Marca = "Fiat", Modelo = "Palio", cantidadPuertas = 3, motor = new Motor(1.3, "cc") };
            FiatPrototype siena = new FiatPrototype { Marca = "Fiat", Modelo = "Siena", cantidadPuertas = 3, motor = new Motor(1.6, "cc") };

            Dictionary<int, AutoPrototype> prototipos = new Dictionary<int, AutoPrototype>
            {
                { 1, fiesta },
                { 2, focus },
                { 3, palio },
                { 4, siena }
            };

            List<AutoPrototype> autosCreados = new List<AutoPrototype>();

            Console.WriteLine("=== Bienvenido a Creacar ===");
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nSeleccione un modelo:");
                Console.WriteLine("1. Ford Fiesta");
                Console.WriteLine("2. Ford Focus");
                Console.WriteLine("3. Fiat Palio");
                Console.WriteLine("4. Fiat Siena");
                Console.Write("Opción: ");
                int opcion = int.Parse(Console.ReadLine());

                if (prototipos.ContainsKey(opcion))
                {
                    AutoPrototype autoBase = prototipos[opcion];
                    AutoPrototype nuevoAuto = autoBase.Clonar();

                    Console.Write("Ingrese cantidad de puertas (3 o 5): ");
                    if(!int.TryParse(Console.ReadLine(), out int puertas) || (puertas != 3 && puertas != 5))
                    {
                        Console.WriteLine("❌ Cantidad de puertas inválida. Se asignarán 3 puertas por defecto.");
                        puertas = 3;
                    }
                    nuevoAuto.cantidadPuertas = puertas;

                    autosCreados.Add(nuevoAuto);

                    Console.WriteLine("\n✅ Auto creado:");
                    Console.WriteLine($"Marca: {nuevoAuto.Marca}");
                    Console.WriteLine($"Modelo: {nuevoAuto.Modelo}");
                    Console.WriteLine($"Puertas: {nuevoAuto.cantidadPuertas}");
                    Console.WriteLine($"Motor: {nuevoAuto.motor.Numero} {nuevoAuto.motor.Potencia}");
                }
                else
                {
                    Console.WriteLine("❌ Opción inválida.");
                }

                Console.Write("\n¿Desea crear otro auto? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();
                if (respuesta != "s") continuar = false;
            }

            // Mostrar todos los autos creados
            Console.WriteLine("\n=== Autos creados ===");
            foreach (var auto in autosCreados)
            {
                Console.WriteLine($"{auto.Marca} {auto.Modelo} - {auto.cantidadPuertas} puertas - Motor {auto.motor.Numero} {auto.motor.Potencia}");
            }
        }
    }
}
