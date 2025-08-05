using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method___Empresa_de_logistica
{
    public class Cliente
    {
        public void GenerarEnvio(string medio, double peso, double distancia)
        {
            CreadorDeDocumetos creador = null;
            switch (medio.ToLower())
            {
                case "aereo":
                    creador = new CreadorAereo();
                    break;
                case "terrestre":
                    creador = new CreadorTerrestre();
                    break;
                case "maritimo":
                    creador = new CreadorMaritimo();
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if(creador !=  null)
            {
                DocEnvio envio = creador.CrearDocumento();
                envio.ValidarRequicito();
                envio.CalcularCosto(peso,distancia);
            }
            else
            {
                Console.WriteLine("Debes ingresar los valores correctos");
            }
        }
    }
}
