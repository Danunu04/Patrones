using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Editor_de_Texto
{
    public class EditorDeTexto
    {
        private string contenido = "";
        public void escribir (string texto)
        {
            contenido += texto;
        }
        public void Mostrarcontenido()
        {
            Console.WriteLine(contenido);
        }
        public Memento GuardarEstado()
        {
            return new Memento(contenido);
        }

        public void restaurar (Memento memento)
        {
            contenido = memento.getState();
        }
    }
}
