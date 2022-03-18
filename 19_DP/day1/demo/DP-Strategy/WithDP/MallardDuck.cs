using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy.WithDP
{
    class MallardDuck : Duck
    {
        public override void Display() => Console.WriteLine("I am Mallard Duck");

        //Specify Initial Fly , Quack Behaviours
        public MallardDuck() : base(new FlyNormalSpeed(), new NormalQuack()) { }
    }
}
