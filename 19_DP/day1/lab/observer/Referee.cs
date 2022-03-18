using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    internal class Referee:IObserver
    {
        Position pos = new(0,0,0);
        public int ID;
        public FootBall Ball { get; set; }

        

        public void Update()
        {
            pos.X = Ball.GetPosition().X;
            pos.Y = Ball.GetPosition().Y;
            pos.Z = Ball.GetPosition().Z;
            Console.WriteLine($"referee {ID} move to {pos}");
        }
        public override string ToString() => $"refree position {pos}";
    }
}
