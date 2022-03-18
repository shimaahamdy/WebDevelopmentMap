using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Defenders
    {
        Mediator mediator;
        string weapon;
        bool reachCastle;

        public Defenders(Mediator m, string w, bool Castle)
        {
            mediator = m;
            weapon = w;
            reachCastle = Castle;
        }

        public void  buyweapons()
        {
            weapon = mediator.SolidersWeapons();
            Console.WriteLine("good weapons reached");


        }

        public bool castle()
        {
            if (reachCastle)
            {
                Console.WriteLine("Defenders in castle");
                return true;

            }

            else
            {
                Console.WriteLine("Defenders not in the castle"); 
                return false;
            }
        }
    }
}
