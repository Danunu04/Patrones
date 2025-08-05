using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator2
{
    public class Button: Component
    {
        public string _label { get; }

        public Button(IMediator dialog, string label): base(dialog)
        {
            _label = label;
        }
    }
}
