﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace D05
//{
//     class Utility
//    {
//        public int X { get; set; }
//        public int Y { get; set; }


//        public Utility()
//        {
//            Console.WriteLine("Default Ctor");
//        }

//        ///can't Specify access modifier for Static Ctor
//        ///will be invoked automatically once per Program Lifetime
//        ///Before first usage of class
//        ///Must be parameterless ctor , No Static ctor overloading
//        static Utility()
//        {
//            Pi = 3.14;
//            Console.WriteLine("Static Ctor");
//        }


//        static double Pi;
//        ///Static Attributes , allocated in Heap , intialized by Default
        
//        public static double PI
//        {
//            get { return Pi; }
//        }

//        public static double CircleArea (double R)
//        {
//            return R * R * Pi; 
//        }

//        public static double Cm2Inch ( double Cm)
//        {
//            return Cm / 2.54;
//        }

//        public static double Inch2CM ( double Inch)
//        {
//            return Inch * 2.54;
//        }


//    }
//}
