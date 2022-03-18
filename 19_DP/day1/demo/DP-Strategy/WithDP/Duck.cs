using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy.WithDP
{
    abstract class Duck
    {
        public abstract void Display();
        public void Swim() => Console.WriteLine("Swimming");

        ///Gain Fly , Quack Behaviour Through Composition
        public IFly FlyBehaviour { get; set; }
        public IQuack QuackBehaviour { get; set; }
        //Develop Against Abstraction not Conceret Impelmentation
        //Composited Object is from BASE type no Specific Derived Type

        public Duck(IFly fly , IQuack quack)
        {
            FlyBehaviour = fly;
            QuackBehaviour = quack;
        }
        ///Delegation
        ///redirect Message (Function call) to Composited Object 
        public void Fly() => FlyBehaviour.PerformFly();
        public void Quack()=> QuackBehaviour.PerformQuack();



    }
}
