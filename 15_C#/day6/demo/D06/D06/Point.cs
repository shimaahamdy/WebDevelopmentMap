using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06
{
    internal class Point:IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int CompareTo(object obj)
        {
            //Console.WriteLine("CompareTo");

            //foreach (var item in (new StackTrace()).GetFrames())
            //{
            //    Console.WriteLine(item.GetMethod());
            //}


            if (obj is Point Right)
            {
                if ( X == Right.X)
                    return Y.CompareTo(Right.Y);
               return X.CompareTo(Right.X);
            }
            else
                return 1;
        }

        public override bool Equals(object obj)
        {
            #region Casting
            //Point Right = (Point)obj; ///unsafe Casting 

            ///Safe
            //if (obj is Point) ///return true if valid casting , return false if casting will fails , no Exceptions will be thrown
            //{
            //    Point Right = (Point)obj;

            //    return X == Right.X && Y == Right.Y;
            //}
            //return false;

            ///C# 6.0 Patterns
            //if ((obj is Point Right)&&(Point !=null)) ///return true if valid casting , return false if casting will fails , no Exceptions will be thrown
            //    return X == Right.X && Y == Right.Y;
            //return false;

            #endregion

            Point Right = obj as Point; // if casting fails , return null , no exceptions will be thrown
            
            if ( Right == null) return false;

            if ( this.GetType() != Right.GetType() ) return false;

            if (object.ReferenceEquals(Right, this)) return true;

            return X == Right.X && Y == Right.Y;

        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
