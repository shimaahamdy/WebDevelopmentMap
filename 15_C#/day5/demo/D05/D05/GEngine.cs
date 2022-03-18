//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace D05
//{
//    class GEngine
//    {
//        int Data;

//        GEngine(int _Data)
//        {
//            Console.WriteLine("Ctor");
//            Data = _Data;
//        }

//        static GEngine SingleObj;

//        public static GEngine GetEngine()
//        {
//            if (SingleObj == null)

//                SingleObj =new GEngine(123456);

//            return SingleObj;
//        }

//        public void DoSomeGraphicsWork ()
//        {
//            Console.WriteLine("Processing....");
//        }
//    }
//}
