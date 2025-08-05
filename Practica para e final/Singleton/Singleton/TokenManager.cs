using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class TokenManager
    {
        private static readonly object _lock = new object();
        private static TokenManager _instance;
        private static int ContadorDeAcceso = 0;
        private static string LogPath = "Auditoria.txt";

        private TokenManager()
        {
            EscribirLog("Instancia Creada");
        }

        public static TokenManager GenInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new TokenManager();
                }
                ContadorDeAcceso++;
                EscribirLog("Acceso" + ContadorDeAcceso.ToString() + "a la instancia de TokenManager.");
                return _instance;
            }
        }

        internal static string ObtenerCantidadAccesos()
        {
            return ContadorDeAcceso.ToString();
        }

        private static void EscribirLog(string mensaje)
        {
            System.IO.File.AppendAllText(LogPath, $"{DateTime.Now:HH:mm:ss} - {mensaje}{Environment.NewLine}");
        }

        public string GenerarToken()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
