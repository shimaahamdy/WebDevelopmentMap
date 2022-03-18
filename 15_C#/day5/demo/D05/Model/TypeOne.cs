namespace Model
{
    public class TypeOne
    {
        int x; //Default access in class & Struct : Private

        private protected int L; ///Only in Derived classes in the same Assembly file

        protected int Y;

        internal int Z;

        internal protected int K;

        public int M;
        public override string ToString()
        {
            return $"{x} {Y} {Z} {K} {L} {M}";
        }
    }
}