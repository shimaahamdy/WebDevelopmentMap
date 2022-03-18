using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory
{
    interface IEngine
    {
        string Manufacturere { get; }
        int HPower { get;  }
    }
    class MercEngine : IEngine
    {
        public string Manufacturere => "Mercedes";
        public int HPower => 1200;
    }

    class FerrariEngine : IEngine
    {
        public string Manufacturere => "Ferrari";
        public int HPower => 1100;
    }

    class HondaEngine : IEngine
    {
        public string Manufacturere => "Honda";
        public int HPower => 1150;
    }
    ///Open for Extension
    class RenaultEngine : IEngine
    {
        public string Manufacturere => "Renault";
        public int HPower => 950;
    }
}
