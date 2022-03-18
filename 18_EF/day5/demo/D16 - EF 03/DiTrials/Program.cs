using DiTrials;
using Unity;

//Driver driver = new Driver(new BMW());
//Console.WriteLine(driver);

//Driver D02 = new Driver(new Ford());
//Console.WriteLine(D02);


//var Container = new UnityContainer();
//Container.RegisterType<ICar, BMW>();


//Driver Driver = Container.Resolve<Driver>();
//Console.WriteLine(Driver);

var Container = new UnityContainer();
Container.RegisterType<ICar, BMW>();
Container.RegisterType<ICar, Ford>();

Driver Driver = Container.Resolve<Driver>();
Console.WriteLine(Driver);
