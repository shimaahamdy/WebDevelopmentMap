using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Team
    {
        TeamStrategy strategy;

        public void setStrategy(TeamStrategy s)
        {
            strategy = s;
        }
        public void playGame()
        {
            Console.WriteLine("Game is runing");
            strategy.play();
        }

    }
}
