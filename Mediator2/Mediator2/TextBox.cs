using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator2
{
    public class TextBox: Component
    {
        public string Valor { get; private set; }

        public TextBox(IMediator dialog) : base(dialog) 
        {
        
        }

        public override void KeyPress (string value)
        {
            Valor = value;
            base.KeyPress(value);
        }
    }
}
