using System;
using System.Diagnostics;

namespace D04
{
    class Program
    {

        #region Stack Frame , Stack Trace
        //public static void FunOne()
        //{
        //    FunTwo(10);
        //}

        //public static void FunTwo(int Z)
        //{
        //    //int X = new int();
        //    //int Y = 5 / X; //divid by Zero exception

        //    //Console.WriteLine("Inside FunTwo");

        //    StackTrace stackTrace = new StackTrace();

        //    foreach (StackFrame item in stackTrace.GetFrames())
        //    {
        //        Console.WriteLine(item.GetMethod().Name);
        //    }

        //} 
        #endregion

        #region Default input Paramters
        //public static int Sum1 ( int X , int Y , int Z) { return X + Y + Z; }
        //public static int Sum2(int X=1, int Y=2, int Z=3) { return X + Y + Z; }
        //public static int Sum3(int X , int Y = 2, int Z = 3) { return X + Y + Z; }
        //public static int Sum4(int X, int Y , int Z = 3) { return X + Y + Z; }
        /////Not Valid
        ////public static int SumX(int X=1, int Y, int Z = 3) { return X + Y + Z; } 
        #endregion

        public static void PrintLine(int N = 5 , string Pattern = "#")
        {
            int i;
            for ( i=0; i < N; i++)
                Console.Write(Pattern);
            Console.WriteLine();
            //FunOne();
        }

        ///Value Types pass by Value
        //public static void SWAP (int X , int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}


        ///Value Types , Pass by Ref
        public static void SWAP(ref int X,ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }

        //reference Type , Pass by Value
        //public static int SumArray(int[] MyArr)
        //{
        //    int Sum = 0;

        //    //Console.WriteLine(MyArr.GetHashCode());

        //    for (int i = 0; i < MyArr?.Length; i++)
        //        Sum += MyArr[i];

        //    MyArr[0] = 70;

        //    return Sum;
        //}

        ///Reference Type , Pass by Ref
        //public static int SumArray(ref int[] MyArr)
        //{
        //    int Sum = 0;

        //    //Console.WriteLine(MyArr.GetHashCode());
        //    for (int i = 0; i < MyArr?.Length; i++)
        //        Sum += MyArr[i];

        //    MyArr[0] = 70;
        //    return Sum;
        //}


        public static void SumMul(int X, int Y, out int S, out int M)
        {
            M = X * Y;
            S = X + Y;
        }


        ///Pass by Value : Read only for Function
        ///pass by Ref : Read , Write
        ///pass by out : Write First

        static void MainOld()
        {
            //int A = 5, B = 3;

            //SumMul(A, B, out _, out int MulResult); ///Discard

            //Console.WriteLine($"Mul = {MulResult}");

            

            //int A = 5, B = 3;

            //SumMul(A, B, out int SumResult, out int MulResult);

            //Console.WriteLine($"Sum = {SumResult}");
            //Console.WriteLine($"Mul = {MulResult}");


            //int A = 5, B = 3, SumResult, MulResult;

            //SumMul(A, B, out SumResult, out MulResult);

            //Console.WriteLine($"Sum = {SumResult}");
            //Console.WriteLine($"Mul = {MulResult}");




            #region Value Types

            //int A = 5, B = 3;

            ////SWAP(A, B); //bass by Value
            //SWAP(ref A, ref B);

            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            #endregion

            #region Reference Type
            //int[] Arr= { 1, 2, 3, 4, 5 };
            ////Console.WriteLine(Arr.GetHashCode());

            //Console.WriteLine(SumArray(ref Arr));

            //foreach (var item in Arr)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion



            #region Named & Default input paramters
            //Console.WriteLine("Enter new Value : ");
            //PrintLine(7 , "_");
            //PrintLine();
            //PrintLine(10);
            /////Not Valid
            ////PrintLine(, "=");
            /////Valid 
            //PrintLine(Pattern: "=");

            //int X = int.Parse(Console.ReadLine());
            //++X;
            //PrintLine(5 , "_-_");
            /////Named Input Paramters
            //PrintLine(Pattern: "*", N: 10);
            //Console.WriteLine(X); 
            #endregion

            #region Array Range and Indices
            //char[] Vowels = { 'a', 'o', 'i', 'e', 'u' };

            ////char[] CArr = Vowels[1..3];
            ////Range range = 1..3;
            ////char[] CArr = Vowels[range];

            //char[] CArr = Vowels[..^2]; //from start till second from end
            /////Range : Start included , End Excluded

            //CArr = Vowels[..2]; //['a','o']
            //CArr = Vowels[..^3];//['a','o']
            //CArr = Vowels[2..]; //['i,'e','u']

            //foreach (char c in CArr) ///c : foreach iteration variable , represent CArr[i] 
            //    Console.WriteLine(c);

            /////index
            /////from end we start counting with 1 not 0
            /////from start we start counting with 0
            //Console.WriteLine(Vowels[0]);
            //Console.WriteLine(Vowels[^5]); //vowels[lenght-5]
            //Console.WriteLine(Vowels[^1]); //Vowels[Lenght-1]

            //int n = 1;
            //Console.WriteLine(Vowels[^n]); //Vowels[Lenght-n]


            /////Exception
            /////Arr[^0] : Arr[Lenght-0] Index out of Range
            /////^1 : first index : Arr[Lenght-1]
            ////Vowels[^0] = '2';
            /////^Lenght = 0 from start 
            #endregion

            #region Implicit Typed local Variable
            //double D = 13.5;

            //Console.WriteLine(D.GetType());

            //D = "Hello";


            ///Implicit Typed Local Variable
            //var D = 13.5;
            //Console.WriteLine(D.GetType());

            //D = "Hello"; 
            #endregion

        }
    }
}
