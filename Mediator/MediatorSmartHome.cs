using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class MediatorSmartHome
    {
        public abstract void Send(string msg, Composition composition);
    }
}
