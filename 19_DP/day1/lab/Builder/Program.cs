namespace Builder
{
    public class Program
    {
        public static void Main()
        {
            EnglandGround EngGround = new EnglandGround();
            EngGround.ConstructGround();
            Console.WriteLine(EngGround.print());

            italyGround ItlayGround = new italyGround();
            ItlayGround.ConstructGround();
            Console.WriteLine(ItlayGround.print());
        }
    }
}
