using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator2
{
    public interface IMediator
    {
        void notify(Component sender, string ev);
    }
}
