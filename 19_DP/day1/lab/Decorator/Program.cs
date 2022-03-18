namespace Decorator
{
    public class Program
    {
        public static void Main()
        {
            Player player1 = new Player(); //normal player
            player1.ID = 1;

            //assign player to be defender+normal player
            PlayerRole role = new Defender();
            role.AssignPlayer(player1);
            player1 = role;

            //add responsibity to be forward to 
            //forward + defender + player
            role = new Forward();
            role.AssignPlayer(player1);
            player1 = role;

            player1.passBall();

            Console.WriteLine(" ***************************** ");

            Player player2 = new FieldPlayer();
            player2.ID = 2;
            PlayerRole role2 = new MidFielder();
            role2.AssignPlayer(player2);
            player2 = role2;

            role2 = new Forward();
            role2.AssignPlayer(player2);
            player2 = role2;

            player2.passBall();



           


        }
    }
}