using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory
{
    interface IFrontWing
    {
        int NumberofFins { get; }
        string Material { get;  }
    }

    class DownforceFrontWing : IFrontWing
    {
        public int NumberofFins => 4;
        public string Material => "Carbon Fiber";
    }

    class SpeedFrontWing : IFrontWing
    {
        public int NumberofFins => 5;
        public string Material => "Carbon Fiber";
    }
}
