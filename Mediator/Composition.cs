using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class Composition
    {
        protected MediatorSmartHome mediator;

        protected Composition(MediatorSmartHome mediator)
        {
            this.mediator = mediator;
        }

    }
}
