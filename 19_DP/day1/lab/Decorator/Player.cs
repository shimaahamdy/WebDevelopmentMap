using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Player
    {
        public int ID { get; set; }

       
        virtual public void passBall()
        {
            Console.WriteLine($"player {ID}");

        }
    }
}
