using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class italyGround
    {
        IBuild Ground;

        public IBuild ConstructGround()
        {
            Ground = new GroundBuilder();
            Ground.setGroundSurface("italy ground").setGallery("italy Gallery").setAudience("loud italian audience");

            return Ground;
        }

        public string print() => Ground.print();
    }
}
