using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    internal class Program
    {
        public static void Main()
        {
            FootBall ball = new FootBall();
            Player player1 = new Player();
            Player player2 = new Player();
            player1.Ball = ball;
            player1.ID = 1;
            player2.Ball = ball;
            player2.ID = 2;
            Referee refree = new Referee();
            refree.ID = 5486;
            refree.Ball = ball;
            ball.Attach(player1);
            ball.Attach(player2);
            ball.Attach(refree);

            Console.WriteLine(ball);
            Console.WriteLine(player1);
            Console.WriteLine(player2);
            Console.WriteLine(refree);

            Console.WriteLine("********** ball move **********");
            ball.setPostiton(new Position(5, 10, 1));
            Console.WriteLine(ball);



        }
    }
}
