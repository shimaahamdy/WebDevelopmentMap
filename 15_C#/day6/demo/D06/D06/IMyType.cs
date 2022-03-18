using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06
{
    interface IMyType
    {
        void FunOne(int X);

        string MyProp { get;  }

        //not Allowed
        //int X;
    }

    class MyTypeOne : IMyType
    {
        public string MyProp { get { return "Demo Test"; } }

        public void FunOne(int X)
        {
            Console.WriteLine(++X);
        }
    }

    struct MyTypeTwo : IMyType
    {
        public string MyProp { get { return "Struct"; } }

        public void FunOne(int X)
        {
            Console.WriteLine(X++);
        }
    }
}
