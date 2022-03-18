using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Attack : TeamStrategy
    {
        public void play()
        {
            Console.WriteLine("play with Attack");
        }
    }
}
