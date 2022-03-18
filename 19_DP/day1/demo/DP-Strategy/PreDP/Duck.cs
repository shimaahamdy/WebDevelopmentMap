using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy.PreDP
{
    abstract class Duck
    {
        public void Swim ()
        {
            Console.WriteLine("Swimming");
        }

        public abstract void Display();

        public void Fly ()
        {
            Console.WriteLine("Fly Normal Speed");
        }

        public void Quack ()
        {
            Console.WriteLine("Quacking");
            Console.Beep();
        }
    }
}
