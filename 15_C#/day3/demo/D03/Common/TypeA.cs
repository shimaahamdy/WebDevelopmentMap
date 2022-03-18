namespace Common
{
    ///default access level inside Namespace : Internal 
    ///Available Access levels inside namespace : Internal or Public
   public struct TypeA
    {
        ///default access Modifier : Private
        int X;

        internal int Y; ///Accessable inside the same project / Same Assembly file

        public int Z;

        public void Print()
        {
            Console.WriteLine($"{X} , {Y}, {Z}");
        }
    }
}