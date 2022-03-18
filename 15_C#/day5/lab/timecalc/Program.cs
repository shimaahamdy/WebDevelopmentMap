
namespace timecalc
{
    class Program
    {
        public static void Main()
        {
            Duration D1 = new Duration(1, 10, 15);  //1,10,15
            Console.WriteLine(D1.ToString());

            Duration D2 = new Duration(3600);       //1 0 0
            Console.WriteLine(D2.ToString());

            Duration D3 = new Duration(7800);        //2 10 0
            Console.WriteLine(D3.ToString());

            Duration D4 = new Duration(666);        //0 11 6
            Console.WriteLine(D4.ToString());


            Duration D5 = D1 + D2;                  //2 10 15
            Console.WriteLine(D5.ToString());

            Duration D6 = D1 + 3600;                //2 10 15
            Console.WriteLine(D6.ToString());

            Duration D7 = 666 + D1;                  //1 21 21
            Console.WriteLine(D7.ToString());

            Duration D8 = ++D1;
            Console.WriteLine(D8.ToString());         // 1 11 15
            Console.WriteLine(D1.ToString());         //1 11 15
            Duration D9 = D1--;                      
            Console.WriteLine(D9.ToString());          //1 11 15
            Console.WriteLine(D1.ToString());          //1 10 15

            if (D1 > D2)
                Console.WriteLine("D1 > D2");

            if(D5 <= D6)
                Console.WriteLine("D5 <= D6");
            if (D1)
                Console.WriteLine("D1");
            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj.ToString());


        }
    }
}