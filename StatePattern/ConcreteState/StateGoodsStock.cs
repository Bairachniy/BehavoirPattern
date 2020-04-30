using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.ConcreteState
{
    class StateGoodsStock : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Good is stock ");
            context.State = new StateSell();
        }
    }
}
