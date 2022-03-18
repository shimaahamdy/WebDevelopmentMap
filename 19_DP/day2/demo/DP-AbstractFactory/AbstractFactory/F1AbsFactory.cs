using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory
{
    interface F1AbsFactory
    {
        ///3 Factory Methods , One per Part
        IEngine GetEngine();
        IFrontWing GetWing();
        IGearBox GetGearBox();
    }

    class MercTeamFactory : F1AbsFactory
    {
        public IEngine GetEngine() => new MercEngine();

        public IGearBox GetGearBox()=> new WilliamsGearBox();
        
        public IFrontWing GetWing()=> new SpeedFrontWing();
       
    }

    class NewTeamEntry : F1AbsFactory
    {
        public IEngine GetEngine() => new FerrariEngine();

        public IGearBox GetGearBox() => new GenericGearBox();

        public IFrontWing GetWing() => new DownforceFrontWing();
    }

    ///Open for Extension
    class RenaultTeamFactory : F1AbsFactory
    {
        public IEngine GetEngine() => new RenaultEngine();

        public IGearBox GetGearBox() => new GenericGearBox();

        public IFrontWing GetWing() => new SpeedFrontWing();
    }
}
