using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy.WithDP
{
     class RubberDuck: Duck
    {
        public override void Display() => Console.WriteLine("I am Rubber Duck");

        public RubberDuck() : base(new NoFly(), new Sqeak()) { }
    }
}
