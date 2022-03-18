using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Defend:TeamStrategy
    {
        public void play()
        {
            Console.WriteLine("play with Defend");
        }
    }
}
