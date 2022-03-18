using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Guards
    {
        public string Position;
        Mediator mediator;
        public bool run;

        public Guards(string pos, Mediator m, bool run)
        {
            Position = pos;
            mediator = m;
            run = run;
        }

        public bool position(string _POS)
        {
            if (Position == _POS) return true;
            else return false;
        }

        public  void RuntoCastle()
        {
            run = mediator.DefendersINCastle();
            if (run)
                Console.WriteLine("Guards runing");
            else Console.WriteLine("Guars waiting");

        }

    }
}
