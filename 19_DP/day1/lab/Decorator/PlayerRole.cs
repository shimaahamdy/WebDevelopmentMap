using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class PlayerRole : Player
    {
        protected Player player;


        public void AssignPlayer(Player p)
        {
            player = p;
        }

       
    }
}
