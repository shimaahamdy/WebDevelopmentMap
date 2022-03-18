using DP_AbstractFactory;

Formula1Car Team01Car = new Formula1Car(new MercTeamFactory());
Team01Car.AssembleCar();
Console.WriteLine(Team01Car);

Formula1Car Team02Car = new Formula1Car(new NewTeamEntry());
Team02Car.AssembleCar();
Console.WriteLine(Team02Car);

Team02Car.CarFactory = new RenaultTeamFactory();
Team02Car.AssembleCar();
Console.WriteLine(Team02Car);


