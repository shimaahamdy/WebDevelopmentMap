using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class EnglandGround
    {
        IBuild Ground;

        public IBuild ConstructGround()
        {
            Ground = new GroundBuilder();
            Ground.setGroundSurface("England ground").setGallery("England Gallery");

            return Ground;
        }

        public string print()
        {
            return Ground.print();
        }


    }
}
