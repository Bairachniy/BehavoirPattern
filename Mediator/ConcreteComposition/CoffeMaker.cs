using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ConcreteComposition
{
    class CoffeMaker : Composition
    {
        public CoffeMaker(MediatorSmartHome mediator) : base(mediator)
        {
        }

        public void CoffeeTurn(string msg)
        {
            string coffee = " Coffeemaker turn on";
            Console.WriteLine(this.GetType().Name + coffee);
            mediator.Send(coffee, this);
        }
    }
}
