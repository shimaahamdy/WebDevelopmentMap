global using System; ///Project Level , Assembly File Level
//using static System.Console; ///Call static members from Console Class
//Directly , Only in this cs File

//global using static System.Console;
using Common;

namespace D03_PI
{
    enum Grades
    { A , B , C , D , F }

    enum Branches
    { Smart=101 , NasrCity =205, Mansoura=220 , Alex , Assuit , Ismailia}

    class Program
    {
        static void Main(string[] args)
        {
            Branches MyB = Branches.Smart ;

            Console.WriteLine(MyB);

            MyB = (Branches)3;

            Console.WriteLine(MyB);

            MyB = (Branches)223;
            Console.WriteLine(MyB);



            #region Enum Ex01
            //Grades MYG = Grades.C;

            //Console.WriteLine(MYG);

            //MYG = Grades.F;

            //if ( MYG == Grades.A)
            //    Console.WriteLine(":)");
            //else if ( MYG == Grades.F)
            //    Console.WriteLine(":("); 
            #endregion


            //Console.WriteLine("Hello C#10");
            //WriteLine("Hello C#9"); /// static using

            #region Casting between Numeric Value Types

            //Int32 X = 500;
            //Int64 Y = 50_000;

            /////Implicit Casting 
            ////Y = X;

            /////Explicit Casting
            ////Y = (Int64)X;
            ////Y = (long)X;

            /////Safe Casting - no overflow 
            /////you can use it as implicit or explicit 

            //Y = Int64.MaxValue;

            /////UnSafe Casting , Overlow may occurs
            /////Must be Explicit Casting
            //X = (int)Y;
            /////default action for CLR no overlowexception is thrown

            /////to force CLR to throw OverFlowException
            //checked
            //{
            //    X = (int)Y;
            //}


            //Console.WriteLine($"X = {X}");
            //Console.WriteLine($"Y = {Y}");

            #endregion

            #region Casting between Value Types and System.Object

            //int X = 50;

            //Object O1 = new();

            //O1 = X;
            /////ref to Base = Derived
            /////Safe
            /////Boxing

            //int Y;

            //O1 = "Hello";

            //Y = (int)O1;
            ////Derived = Base ??
            /////UnSafe , Explicit
            /////UnBoxing


            #endregion

            #region Nullable Types
            ////int X = 70;

            //////X = null; //not valid

            ////Object O1 = null; // valid

            /////Nullable Value Types
            /////Value Types allow Null as a valid value 
            //int X = 70; //non nullable int Variable
            //int? Y = 7000; // nullable int Variable

            ////Nullable<int> Y = 7000;

            //Y = null;

            ////Safe
            ////Y = X;


            ////UnSafe
            ////X = (int)Y;
            ////X = Y.Value; 
            ////un Protective coding Style


            /////Protective Programming
            ////V1
            ////if (Y != null)
            ////    X = (int)Y;
            ////else
            ////    X = -1;

            ////V2
            ////if (Y.HasValue)
            ////    X = Y.Value;
            ////else
            ////    X = -1;

            ////V3
            ////X = Y.HasValue ? Y.Value : -1;

            ////V4
            ////X = Y ?? -1;

            /////(Left )?? (Right)
            /////if Left == Null return Right else return Left.Value

            //Console.WriteLine($"X = {X}");
            //Console.WriteLine($"Y = {Y}");
            #endregion

            #region Null Propagation Operator
            //bool Flag = default;

            //int[] Arr = default;
            /////Arr is Null

            ////for (int i = 0; (Arr != null) && (i < Arr.Length); i++)
            ////    Console.WriteLine(Arr[i]);

            ////Null Propagation Operator
            ////for (int i = 0; i < Arr?.Length; i++)
            ////    Console.WriteLine(Arr[i]);


            ////int R;
            //////R = Arr.Length; ///UnProtective Code , May Throw Exception

            ////R = Arr != null ? Arr.Length : -1;

            ///////Arr.Lenght : int //UnSafe
            ///////Arr?.Lenght : int?
            ///////Arr?.lenght??-1 : int //Safe
            ///////Arr?.lenght === (Arr != null)? Arr.Lenght : Null;

            //////R = Arr?.Length;
            ////R = Arr?.Length ?? -1;

            //Employee E1 = default;

            //Employee E2 = new();

            //Employee E3 = new() { Department = new() };


            ////if ((E3 != null) && (E3.Department != null) && (E3.Department.Name != null))
            ////    Console.WriteLine(E3.Department.Name.Length);
            ////else
            ////    Console.WriteLine("-1");

            ////Safe , Protective , No NullRefrenceExceptions 
            //Console.WriteLine(E3?.Department?.Name?.Length ?? -1);
            #endregion

            #region Struct
            ////TypeA A;

            //////A.Y = 20;// Internal , in Diff Assembly file , Diff Project
            ////A.Z = 8;


            ////Point P1;
            /////Allocation 8 uninitialized bytes in Stack
            /////no Ctor have been called
            ////Console.WriteLine(P1.PrintState());
            ////Console.WriteLine(P1.ToString());

            //Point P2 = new Point(10, 10);
            /////Allocation 8 Bytes in Stack
            /////use new with Struct just for Selecting which Ctor to initialize struct variable in Stack
            //P2.PrintState();

            //Point P3 = new(15);
            //P3.PrintState();

            /////for ANY Struct ,Compiler will Generate Default Paramterless ctor
            /////Initializing ALL Members with Default Value
            /////C#1.0 - C#9.0 , No Explicit userdefined Paramterless Ctor can exists
            /////C#10 , Allow Userdefined Paramterless ctor
            ////Point P4 = new Point();
            //Point P4 = new();

            //P4.PrintState();

            //Point P5 = default; //use original Paramterless Ctor
            //P5.PrintState();

            //Console.WriteLine(P5.ToString());
            //Console.WriteLine(P4); 
            #endregion
        }
    }

    //class Department
    //{
    //    public string Name = null;
    //}

    //class Employee
    //{
    //    public Department Department = null;
    //}

}
