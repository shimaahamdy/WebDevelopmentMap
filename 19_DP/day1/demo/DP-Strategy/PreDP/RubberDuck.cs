using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy.PreDP
{
    class RubberDuck : Duck
    {
        public override void Display() => Console.WriteLine("I am Rubber Duck");

        public new void Fly() => Console.WriteLine("No Wings to Fly");

        public new void Quack ()
        {
            Console.WriteLine("Sqeak");
            Console.Beep(32676, 1500);
        }
    }
}
