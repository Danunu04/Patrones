using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Calculadora
{
    public class EXPRESION_RESTA:IExpression
    {
        public void Interpretar(Contexto contexto)
        {
            string[] partes = contexto.Expression.Split('-');
            if (partes.Length == 2)
                contexto.resultado = int.Parse(partes[0].Trim()) + int.Parse(partes[1].Trim());
        }
    }
}
