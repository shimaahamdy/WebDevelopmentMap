using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class GroundBuilder : IBuild
    {
        Ground ground;
        public GroundBuilder()
        {
            ground = new Ground();
        }
        public Ground Build()
        {
            return ground;
        }

        public IBuild setAudience(string _audiaence)
        {
            ground.audience = _audiaence;
            return this;
        }

        public IBuild setGallery(string _gallery)
        {
            ground.gallery = _gallery;
            return this;
        }

        public IBuild setGroundSurface(string _groundSurface)
        {
            ground.groundSurface = _groundSurface;
            return this;
        }

        public string print() => ground.ToString();
        
    }
}
