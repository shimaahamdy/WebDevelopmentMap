
namespace math
{
    class Program
    {
        public static void Main() 
        {
            Console.WriteLine(calculations.Add(5, 6)); //11
            Console.WriteLine(calculations.Sub(8,3)); //5
            Console.WriteLine(calculations.Multiply(3,-9)); //-27
            Console.WriteLine(calculations.Divide(5,5)); //1
            Console.WriteLine(calculations.Divide(5, 0)); //-unknown num



        }
    }
}