using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy.WithDP
{
    interface IFly
    {
        void PerformFly();
    }
    class FlyNormalSpeed : IFly
    {
        public void PerformFly() => Console.WriteLine("Fly Normal Speed");
    }
    class NoFly : IFly
    {
        public void PerformFly() => Console.WriteLine("No Wings To Fly");
    }
    ///Open for Extension , new class to introduce new Behaviour 
    class FlyRocketSpeed :IFly
    {
        public void PerformFly() => Console.WriteLine("Fly Rocket Speed");
    }



}
