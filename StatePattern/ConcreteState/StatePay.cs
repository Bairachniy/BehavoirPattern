﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.ConcreteState
{
    class StatePay : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Order pay ");
            context.State = new StateGoodsStock();
        }
    }
}
