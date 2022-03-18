using graphics;
namespace main
{
    class Program
    {
        public static void Main() //Main in capital
        {
            Point3D p1 = new(); //deafault constructor
            Point3D p2 = new Point3D(5, 2, 7); //paramter construcotr
            Point3D p3 = new Point3D(p2); //copy construcotr

            Console.WriteLine(p1 + "  "+ p1.GetHashCode());
            Console.WriteLine(p2.ToString() + "  " + p2.GetHashCode());
            Console.WriteLine(p3.ToString() + "  " + p3.GetHashCode());

            //string strp1 = (string)p1; //not vaild casting

            //after override string casting
            string strp1 = (string)p1;
            Console.WriteLine(strp1);

            //== check reference
            if(p2==p3)
                Console.WriteLine(" == ");

            if(p2.Equals(p3))
                Console.WriteLine("Equals");


        }
    }
}