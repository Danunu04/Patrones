using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AuthenticarionDialog dialog = new AuthenticarionDialog();

            Console.WriteLine("¿Qué desea hacer? (1 = Login, 2 = Registro)");
            var opcion = Console.ReadLine();
            dialog.LoginOrRegister = (opcion == "1");

            if (dialog.LoginOrRegister)
            {
                Console.Write("Usuario: ");
                var user = Console.ReadLine();
                dialog.loginUsername.KeyPress(user);

                Console.Write("Contraseña: ");
                var pass = Console.ReadLine();
                dialog.loginPassword.KeyPress(pass);

                Console.Write("¿Recordar sesión? (s/n): ");
                if (Console.ReadLine().ToLower() == "s")
                    dialog.rememberMe.Check();

                dialog.ok.Click();
            }
            else
            {
                Console.Write("Nuevo Usuario: ");
                dialog.regUsername.KeyPress(Console.ReadLine());

                Console.Write("Contraseña: ");
                dialog.regPassword.KeyPress(Console.ReadLine());

                Console.Write("Email: ");
                dialog.regEmail.KeyPress(Console.ReadLine());

                dialog.ok.Click();
            }

            Console.WriteLine("\nFin del proceso.");
        }
    }
}

