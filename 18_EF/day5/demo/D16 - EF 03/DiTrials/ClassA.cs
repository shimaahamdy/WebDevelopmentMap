using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiTrials
{
    internal class ClassA
    {
        public int A { get; set; }

        public ClassA(int a) => A = a;

        public override string ToString() => $"{A}";
    }

    class ClassB
    {
        ClassA AObj;

        public ClassB()
        {
            AObj = new(20);
        }

        public void DoSomeBWork ()
        {
            Console.WriteLine(AObj);
        }
    }
}
