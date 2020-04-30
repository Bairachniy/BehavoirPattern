using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavoirPattern
{
    class ConcreteCookRice: Cook
    {
        public override void AddSpices()
        {
            Console.WriteLine("Add paprida and turn off the stove");
        }

        public override void BoilWater()
        {
            Console.WriteLine("Water bul-bul-bul");
        }

        public override void PourCereal()
        {
            Console.WriteLine("Thow rice");
        }
    }
}
