using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiTrials
{
    interface ICar
    {
        int Run();
    }

    class BMW : ICar
    {
        int KM;

        public int Run() => ++KM;
    }

    class Ford : ICar
    {
        int KM;
        public int Run() => ++KM;
    }


///IOC : Inversion of Control , Dependancy Inversion
class Driver
    {
        //BMW Car = new(); ///Tightly Coupled 
        
        ICar Car;
        public Driver(ICar car)=> Car = car;

        public override string ToString() => $"Drivig Car {Car.GetType().Name} for {Car.Run()} KM";

    }


}
