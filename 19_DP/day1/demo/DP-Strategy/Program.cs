using DP_Strategy;
//using DP_Strategy.PreDP;
using DP_Strategy.WithDP;


MallardDuck MD = new();
MD.Swim();
MD.Fly();
MD.Display();
MD.Quack();

RubberDuck RD = new();
RD.Swim();
RD.Fly();
RD.Display();
RD.Quack();

Console.WriteLine("Hunting Mode");
///Open for Extension , Closed for Modification
///Introduce new Fly Behaviour - Fly Rocket Speed
///through new code  , through new class
MD.FlyBehaviour = new FlyRocketSpeed();
MD.Fly(); ///Rocket Speed Fly