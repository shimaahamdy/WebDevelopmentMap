using System;

namespace D06
{
    class Poit3D : Point
    {
        public int Z {  get; set; }

        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Equality Reference Types
            //Point P1 = new Point() {  X = 10 , Y = 20 };
            //Point P2 = new Point() { X = 15, Y = 15 };
            //Point P3 = new Point() { X =10 , Y = 20 };
            //Point P4 = P1;

            /////P1 , P3 : Same State , Diff Identity
            /////P1 , P4 : Same Identity 

            //P3 = default;

            //Poit3D P5 = new Poit3D() {  X = 10 , Y = 20  , Z =30};


            //if (P1.Equals(P3))
            //    Console.WriteLine("P1 EQ P3");
            //else
            //    Console.WriteLine("P1 NEQ P3");

            //if (P1.Equals(P4))
            //    Console.WriteLine("P1 EQ P4");
            //else
            //    Console.WriteLine("P1 NEQ P4");

            //if (P1.Equals(P5))
            //    Console.WriteLine("P1 EQ P5");
            //else
            //    Console.WriteLine("P1 NEQ P5"); 
            #endregion

            #region Interface EX01
            //int X = 5;

            ////Console.WriteLine(Object.ReferenceEquals(X,X));

            //SeriesByTwo byTwo = new SeriesByTwo();

            //SeriesEngine.ProcessSeries(byTwo);

            //Console.WriteLine($"Current {byTwo.Current}");

            //FibSeries fib = new();

            //SeriesEngine.ProcessSeries(fib);
            //Console.WriteLine($"Current {fib.Current}");



            //ISeries series; ///valid - Object

            //series = byTwo; ///Boxing
            //SeriesEngine.ProcessSeries(series);
            //Console.WriteLine($"Current {series.Current}");
            //Console.WriteLine($"Current {byTwo.Current}"); 
            #endregion

            #region IComparable
            //Point[] pArr = { 
            //    new () {  X = 10 , Y = 15 },
            //    new () {  X = 5 , Y = 5 },
            //    new () {  X = 10 , Y = 5 },
            //    new () 
            //};

            //Array.Sort(pArr);

            //foreach (var item in pArr)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Interface Explicit Implementation
            //Type1 O1 = new();

            //((IType1)O1).MyFun();

            //IType1 T1 = O1;
            //T1.MyFun();

            //Type12 O2 = new();
            //O2.MyFun(); //Type1

            //((IType2)O2).MyFun();//IType2 
            #endregion

            #region Inheritance Ex01
            //Parent P = new(1, 2);
            //P.X = 3;
            //P.Y = 4;

            //Child C = new(5, 6, 7);
            //C.X = 8;
            //C.Y = 9;
            //C.Z = 10;

            //Console.WriteLine(P.Sum());
            ////Console.WriteLine(C.SumXY());
            //Console.WriteLine(C.Sum());
            ////Console.WriteLine(C.base.Sum()); ///Not valid in C# 
            #endregion

            //BaseType BaseRef = new BaseType(1);
            //BaseRef.Show(); // Base
            //BaseRef.DynShow(); //Base


            //DerivedType DerivedRef = new DerivedType( 2 , 3);
            //DerivedRef.Show(); // Derived
            //DerivedRef.DynShow(); // Derived

            //BaseRef = new DerivedType(4, 5);
            ////valid , safe 
            //BaseRef.Show(); //Base
            ////Static , Early Binded Function
            //BaseRef.DynShow(); //Derived
            ////Dynamic , late Binded Function


            BaseType BaseRef = new DerivedType02();

            BaseRef.DynShow(); // Derived 02


            DerivedType DerivedRef = new DerivedType02();
            DerivedRef.DynShow(); //Derived 02


            BaseRef = new DerivedType03();
            BaseRef.DynShow();

            DerivedType03 Derived03Ref = new DerivedType03();
            Derived03Ref.DynShow();

        }
    }

    public class SeriesEngine
    {
        ///SOLID
        ///Open for Extension , Closed for Modification
        public static void ProcessSeries (ISeries series)
        //Develop Against Abstraction (Base) no Concrete Implementation (Derived)
        {
            for ( int i =0; i < 10; i ++)
            {
                series.MoveNext();
                Console.Write($"{series.Current} , ");
            }
            Console.WriteLine();
           //series.Reset();

        }
    }
}
