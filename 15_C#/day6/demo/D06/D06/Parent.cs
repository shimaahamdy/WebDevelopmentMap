using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06
{
    class Parent
    {
        int x;
        int y;

        public int X { get => x; internal set => x = value; }
        public int Y { get => y; internal set => y = value; }

        public Parent(int _X , int _Y)
        {
            x = _X;
            y = _Y;
        }

        public int Sum() { return X + Y; }

    }

    class Child : Parent
    {
        int z;

        public int Z { get => z; internal set => z = value; }

        public Child(int _X , int _Y , int _Z):base(_X , _Y)
        {
            z = _Z;
        }

        //public int Sum () { return X + Y + z; }
        public /*new*/ int Sum() { return base.Sum()+ z; }


    }

}
