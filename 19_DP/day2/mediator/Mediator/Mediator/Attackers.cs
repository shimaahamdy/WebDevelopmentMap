using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Attackers
    {
        Mediator mediator;
       

        public Attackers(Mediator m)
        {
            mediator = m;
         
        }
        public void move(string GuardsPosition)
        {
            if(mediator.GuardPosition(GuardsPosition))
            {
              
                Console.WriteLine("attacker move to  guards position");
            }
        }
       
    }
}
