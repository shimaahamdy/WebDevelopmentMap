using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Forward: PlayerRole
    {
        public void ShootGoal()
        {
            Console.WriteLine("Forward player");
        }

        public override void passBall()
        {
            Console.WriteLine("Forward");
            player.passBall();
        }

        public string toString() => "Forward";
    }
}
