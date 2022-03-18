using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_PI
{
    struct Point
    {
        int X;
        int Y;


        #region Ctor
        ///User defined Ctors inside Struct
        ///Any User Defined Ctor must FULLY initialize ALL struct Attributes
        public Point(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        ///Ctor Overloading
        public Point(int n)
        {
            X = Y = n;
        }
        /// Paramterless Ctor
        public Point()
        {
            X = Y = -1;
        }
        #endregion

        //System.Object Members
        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public void PrintState()
        {
            Console.WriteLine($"({X},{Y})");
        }
    }
}
