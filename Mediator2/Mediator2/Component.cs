using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator2
{
    public abstract class Component
    {
        protected IMediator _dialog;

        public Component(IMediator dialog)
        {
            _dialog = dialog;   
        }

        public virtual void Click()
        {
            _dialog.notify(this, "Click");
        }

        public virtual void KeyPress(string value)
        {
            _dialog.notify(this, $"input:{value}");
        }
    }
}
