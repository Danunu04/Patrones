using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method___Empresa_de_logistica
{
    public class DocTerreste: DocEnvio
    {
        public override void CalcularCosto(double peso, double distancia)
        {
            var random = new Random();
            double coefDistancia = random.NextDouble(); // ej. 0.73
            double coefPeso = random.NextDouble();      // ej. 0.42

            double costo = (distancia * coefDistancia) + (peso * coefPeso);
            Console.WriteLine($"Costo terrestre es de {costo}");
        }

        public override void ValidarRequicito()
        {
            Console.WriteLine("Verificando seguro de ruta y permisos nacionales.");
        }
    }
}
