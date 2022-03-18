using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class FieldPlayer:Player
    {
        public override void passBall()
        {
            Console.WriteLine($"Field player {ID}");

        }
    }
}
