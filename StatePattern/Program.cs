using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.ConcreteState;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new StateWait());

            for (int i = 0; i < 8; i++)
            {
                context.Request();
            }


            Console.ReadKey();
        }
    }
}
