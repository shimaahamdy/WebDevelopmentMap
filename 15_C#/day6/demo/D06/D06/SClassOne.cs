using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06
{
    sealed class SClassOne 
    {
    }

    //class ClassTwo : SClassOne { }

    abstract class AbsType022
    {
        public abstract void MyFun();
    }

    class ConcType022 : AbsType022
    {
        public sealed override void MyFun()
        {
            Console.WriteLine("Only Implementation");
        }
    }

    class ConcType0221 : ConcType022
    {
        //public override  void MyFun() //Error
        public new void MyFun() //valid
        {

        }
    }



}
