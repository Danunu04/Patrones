using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator2
{
    public class CheckBox: Component
    {
        public bool Marcado { get; private set; }

        public CheckBox(IMediator dialog) : base(dialog) { }

        public void Check()
        {
            Marcado = !Marcado;
            _dialog.notify(this, "check");
        }
    }
}
