using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    class Point
    {
        #region Manually 
        int x;//= -1000;
        public int X
        {
            get { return x; }
            set { x = value; }
        }


        int y;//= -1000;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        #endregion

        #region VS Generate
        //int x;
        //public int X { get => x; set => x = value; }
        //public int Y { get => y; set => y = value; }

        //int y;
        #endregion

        #region automatic Property
        //public int X { get; internal set; }

        //public int Y { get; internal set; }

        //public DateTime TimeStamp { get; } = DateTime.Now;
        ////Creation Readonly field , intialization in ctor
        #endregion

        #region ctors
        ///if no User defined ctor exists , 
        ///Compiler will provide empty paramterless ctor , doing NOTHING
        ///if any userdefined ctor exists with any signature , compiler 
        ///will no longer provide parameterless ctor

        public Point(int _X , int _Y)
        {
            X = _X;
            Y = _Y;
        }
        //Copy Ctor
        public Point(Point OldPoint)
        {
            X = OldPoint.X;
            Y = OldPoint.Y;
        }

        public Point(int _X)
        {
            X = _X;
        }

        public Point():this(-1,-1) ///Ctor Chaining 
        {
            Console.WriteLine("Default Ctor");
        }
        #endregion

        #region Operator Overloading
        ///C# Operator overloading must be Static Member function
        ///Non overloadable Operators [ = , [] ,. , ! , new , += , .....]

        public static Point operator + (Point Left , Point Right)
        {
            return new Point()
            {
                X = Left.X + Right.X,
                Y = Left.Y + Right.Y
            };
        }

        public static Point operator +(Point Left, int Right)
        {
            return new Point()
            {
                X = Left.X + Right,
                Y = Left.Y + Right
            };
        }

        public static Point operator ++ (Point P)
        {
            return new Point()
            {
                X = P.X + 1,
                Y = P.Y + 1
            };
        }
        
        public static bool operator == (Point L , Point R)
        {
            return (L.X == R.X) && (L.Y == R.Y);
        }

        public static bool operator !=(Point L, Point R)
        {
            return (L.X != R.X) || (L.Y != R.Y);
        }

        public static explicit operator string (Point P) {  return P.ToString(); }

        public static implicit operator int (Point P) { return (int)Math.Sqrt(P.x * P.x + P.y * P.y); }



        #endregion

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
