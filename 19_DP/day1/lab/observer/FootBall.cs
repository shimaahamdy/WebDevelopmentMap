using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    internal class FootBall:Ball
    {
        Position pos = new Position(0,0,0);
        public void setPostiton(Position _pos)
        {
            pos = _pos;
            Notify();
        }
        
        public Position GetPosition()
        {
            return pos;
        }
        public override string ToString() => $"ball position {pos}";
    }
   
}

