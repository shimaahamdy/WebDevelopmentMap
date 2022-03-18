using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Soliders
    {
        string weapon;

        public Soliders(string w)
        {
            weapon = w;
        }
        public string provide()
        {
            return weapon;
        }
    }
}
