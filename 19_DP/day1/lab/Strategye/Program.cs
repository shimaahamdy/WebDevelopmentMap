using Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategye
{
    internal class Program
    {
        public static void Main()
        {
            Team t1 = new Team();
            t1.setStrategy(new Attack());
            t1.playGame();

            Console.WriteLine("change strategy");
            t1.setStrategy(new Defend());
            t1.playGame();
        }
    }
}
