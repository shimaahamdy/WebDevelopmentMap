//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace D07
//{
//    public class Point:IComparable<Point>
//    {
//        public int X { get; set; }
//        public int Y { get; set; }

//        public int CompareTo(Point other)
//        {
//            if ( X == other?.X)
//                return Y.CompareTo(other.Y);
//            return X.CompareTo(other?.X);
//        }

//        public override int GetHashCode()
//        {
//            return HashCode.Combine(X, Y);
//        }


//        public override bool Equals(object obj)
//        {

//            Console.WriteLine("EQ");
//            Point Right = obj as Point; // if casting fails , return null , no exceptions will be thrown
            
//            if ( Right == null) return false;

//            if ( this.GetType() != Right.GetType() ) return false;

//            if (object.ReferenceEquals(Right, this)) return true;

//            return X == Right.X && Y == Right.Y;

//        }

//        public override string ToString()
//        {
//            return $"({X},{Y})";
//        }
//    }
//}
