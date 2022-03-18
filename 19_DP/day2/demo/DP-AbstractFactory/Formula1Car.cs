using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory
{
    /// <summary>
    /// Client Class , Final Assembeld Product
    /// </summary>
    class Formula1Car
    {
        IEngine engine;
        IFrontWing wing;
        IGearBox gearBox;

        public F1AbsFactory CarFactory { get; set; }

        public Formula1Car(F1AbsFactory factory) => CarFactory = factory;
        
        public void AssembleCar ()
        {
            engine = CarFactory.GetEngine();
            wing = CarFactory.GetWing();
            gearBox = CarFactory.GetGearBox();
        }

        public override string ToString()
            => $"Engine  {engine.Manufacturere} with Horse Power : {engine.HPower} " +
            $" Front Wing Fins {wing.NumberofFins} from {wing.Material} " +
            $" With {gearBox.NumberofShifts} Shifts Gear box from {gearBox.MadeBy}";
        
    }
}
