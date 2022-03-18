using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07
{
     class MyType<T>
    {
        T x;
        public T X { get => x; set => x = value; }
    }

    class MyType2 : MyType<int> { }

    class MyType3<T> : MyType<T> { }

    class MyType<T1,T2>
    {

    }

    ///interface , Delegate only
    interface IType <out TResult , in T>
    {
        TResult MyFun();
        void Fun2(T x);

        //not valid
        //T MyDemoFun (TResult x);
    }

}
