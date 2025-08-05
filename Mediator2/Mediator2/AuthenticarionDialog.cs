using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator2
{
    public class AuthenticarionDialog:IMediator
    {
        public bool LoginOrRegister = true;

        public TextBox loginUsername, loginPassword;
        public TextBox regUsername, regPassword, regEmail;
        public Button ok, cancel;
        public CheckBox rememberMe;

        public AuthenticarionDialog()
        {
            loginUsername = new TextBox(this);
            loginPassword = new TextBox(this);
            regUsername = new TextBox(this);
            regPassword = new TextBox(this);
            regEmail = new TextBox(this);

            ok = new Button(this, "OK");
            cancel = new Button(this, "Cancelar");
            rememberMe = new CheckBox(this);
        }

        public void notify(Component sender, string ev)
        {
            if (sender == ok && ev == "click")
            {
                if (LoginOrRegister)
                {
                    Console.WriteLine($"Iniciando sesión como: {loginUsername.Valor}");
                    Console.WriteLine($"Contraseña: {loginPassword.Valor}");
                    Console.WriteLine($"Recordarme: {rememberMe.Marcado}");
                }
                else
                {
                    Console.WriteLine("Registrando nuevo usuario:");
                    Console.WriteLine($"Usuario: {regUsername.Valor}");
                    Console.WriteLine($"Contraseña: {regPassword.Valor}");
                    Console.WriteLine($"Email: {regEmail.Valor}");
                }
            }
            else if (sender == cancel && ev == "click")
            {
                Console.WriteLine("Operación cancelada.");
            }
        }
    }
}
