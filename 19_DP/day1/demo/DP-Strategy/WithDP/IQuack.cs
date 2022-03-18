using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy.WithDP
{
    abstract class IQuack
    {
        public abstract void PerformQuack();
    }
    class NormalQuack : IQuack
    {
        public override void PerformQuack()
        {
            Console.WriteLine("Quacking ....");
            Console.Beep();
        }
    }
    class Sqeak : IQuack
    {
        public override void PerformQuack()
        {
            Console.WriteLine("Sqeaaaaaaaaaaaak ....");
            Console.Beep(32000,1500);
        }
    }
}
