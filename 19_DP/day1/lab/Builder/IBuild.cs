using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface IBuild
    {
        Ground Build();

        IBuild setGallery(string gallery);
        IBuild setGroundSurface(string groundSurface);
        IBuild setAudience(string audinence);

        string print();

    }
}
