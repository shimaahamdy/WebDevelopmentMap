using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory
{
    interface IGearBox
    {
        string MadeBy { get;  }
        int NumberofShifts { get;  }
    }

    class WilliamsGearBox : IGearBox
    {
        public string MadeBy => "Williams";
        public int NumberofShifts => 5;
    }

    class GenericGearBox : IGearBox
    {
        public string MadeBy => "Generic";
        public int NumberofShifts => 4;
    }
}
