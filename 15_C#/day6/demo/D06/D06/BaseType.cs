using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06
{
     class BaseType
    {
        int x;
        public int X { get => x; set => x = value; }

        public BaseType(int _X = 0)
        {
            X = _X;
        }

        public void Show ()
        {
            Console.WriteLine("I am Base");
        }

        ///Dynamically Binded Method
        ///virtual , non private
        internal virtual void DynShow ()
        {
            Console.WriteLine("Base Show");
        }
    }

    class DerivedType : BaseType
    {
        int y;
        public int Y { get => y; set => y = value; }

        public DerivedType(int _X =0 , int _Y =0) : base(_X)
        {
            y = _Y;
        }

        public void Show ()
        {
            Console.WriteLine("I am Derived");
        }

        ///override using keywork override , same signature , same access modifier
        internal override void DynShow()
        {
            Console.WriteLine("Derived Show");

            //base.DynShow(); // Base version
        }

    }

    class DerivedType02 : DerivedType
    {
        internal override void DynShow()
        {
            Console.WriteLine("Derived 02 Show");
        }
    }

    class DerivedType03 : DerivedType02
    {
        internal /*new*/ void DynShow ()
        {
            Console.WriteLine("New Implementation");
        }
    }
}
