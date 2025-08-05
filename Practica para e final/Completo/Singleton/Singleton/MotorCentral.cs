using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class MotorCentral
    {
        public static object _lock = new object();
        private static MotorCentral _instance;
        public string usuario { get; set; }

        public static MotorCentral GetInstance
        {
            get
            {
                if (_instance == null) return null;
                return _instance;
            }
        }
        public static void LogIn()
        {
            lock(_lock)
            {
                if (_instance == null)
                {
                    _instance = new MotorCentral();
                }
                else
                {
                    Console.WriteLine("Error sesion ya iniciada");
                }
            }
        }

        public static void LogOut()
        {
            lock(_lock)
            {
                if (_instance == null)
                {
                    Console.WriteLine("Sesion no iniciada");
                }
                else
                {
                    _instance = null;
                }
            }
        }
    }
}
