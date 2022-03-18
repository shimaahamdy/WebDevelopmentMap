using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    class GEngine
    {
        int Data;

        GEngine(int _Data)
        {
            Console.WriteLine("Ctor");
            Data = _Data;
        }
        #region GOF SingleTon

        //static GEngine SingleObj;

        ////public static GEngine GetEngine()
        ////{
        ////    if (SingleObj == null)

        ////        SingleObj = new GEngine(123456);

        ////    return SingleObj;
        ////}

        //static GEngine()
        //{
        //    SingleObj = new GEngine(123456);
        //}

        //public static GEngine SingleTonObj
        //{
        //    get
        //    {
        //        //if (SingleObj == null)
        //        //    SingleObj = new GEngine(123456);
        //        return SingleObj;
        //    }
        //} 
        #endregion

        public static GEngine SingleTonObj { get; } = new GEngine(123456);
        ///Compiler will Define ReadOnly Attribute to Back Field SingleTonObj
        ///Generate Static Ctor , 
        ///Inside static ctor will initialize BackingField = new GEngine(123456);

        public void DoSomeGraphicsWork()
        {
            Console.WriteLine("Processing....");
        }
    }
}
