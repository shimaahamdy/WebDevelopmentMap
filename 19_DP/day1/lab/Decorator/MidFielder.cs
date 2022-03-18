using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class MidFielder:PlayerRole
    {
        public void Dribble()
        {
            Console.WriteLine("MidFileder player");
        }
        public override void passBall()
        {
            Console.WriteLine("MidFileder");
            player.passBall();
        }

        public string toString() => "MidFielder";
    }
}
