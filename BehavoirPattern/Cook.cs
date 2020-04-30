using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavoirPattern
{
    abstract class Cook
    {
        public abstract void BoilWater();
        public abstract void PourCereal();
        public abstract void AddSpices();

        public void TemplateMethod()
        {
            BoilWater();
            PourCereal();
            AddSpices();
            Console.WriteLine("Cooked\n");
        }
    }
}
