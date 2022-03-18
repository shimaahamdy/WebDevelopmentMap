using System;

namespace D02
{
    class Program
    {
        public static void Main()
        {
            #region Value Types
            //int x;
            ////int C# Keyword

            //x = 5;

            //Int32 Y;
            ////FCL Struct

            //Y = x;
            //x++;



            //Console.WriteLine(x);
            //Console.WriteLine(Y); 
            #endregion

            #region Reference Types

            //Object O1;
            ////Zero bytes have been allocated in Heap

            //O1 = new object();

            //object O2 = new(); //C# 9.0 Feature 

            //Console.WriteLine(O1.GetHashCode());
            //Console.WriteLine(O2.GetHashCode());


            //O2 = O1;
            //Console.WriteLine("O2 = O1");


            //Console.WriteLine(O1.GetHashCode());
            //Console.WriteLine(O2.GetHashCode());



            #endregion

            #region String Formating

            //int X,Z;
            //Int32 Y;

            //X = int.Parse(Console.ReadLine());
            //Y = Convert.ToInt32(Console.ReadLine());

            //Z = X + Y;

            //Console.WriteLine(Z);

            //String Str = string.Format("{0} + {1} = {2}", X, Y, Z);
            //Console.WriteLine(Str);

            //Console.WriteLine("{0} + {1} = {2}", X, Y, Z);

            ///String Maniplulation operator $

            //String Str = string.Format($"{X} + {Y} = {X+Y}");
            //Console.WriteLine(Str);

            //Console.WriteLine($"{X} + {Y} = {X + Y:X}");

            #endregion

            #region Promotion Rules
            //long L = 5_000_000_000;

            //float MyV = 13.5f;
            //double D1 = 13.5;
            //decimal D2 = 13.5M;

            //double Result = 7.0 / 2;
            /////Promotion Rules
            //Console.WriteLine(Result); 
            #endregion

            #region Block Statement
            //decimal i = 20.3;

            //{

            ///Block Statement
            //{
            //    int i = 0; ///Block Scope
            //    i = 7;
            //    i++;

            //    Console.WriteLine(i);
            //} //end of i scopt

            ////Console.WriteLine(i);
            //{
            //    string i;
            //    i = "Hello";
            //    Console.WriteLine(i.ToLower());
            //}
            //}

            #endregion

            #region if \ else
            //int X = 5;
            ///C++ Style
            ///Not Valid in C#
            //if (X) ;
            //if (X = 5) ;
            //if (1) ;
            //if (!X) ;


            //if (X > 0)
            //    Console.WriteLine("+ve");
            //else if (X < 0)
            //    Console.WriteLine("-ve");
            //else
            //    Console.WriteLine("Zero");

            //Console.WriteLine("Enter Month : ");
            //int M = int.Parse(Console.ReadLine());

            //if (M == 1)
            //    Console.WriteLine("Jan");
            //else if (M == 2)
            //    Console.WriteLine("Feb");
            //else if (M == 3)
            //    Console.WriteLine("Mar");
            //else if (M == 4)
            //    Console.WriteLine("Apr");
            //else if (M ==5)
            //    Console.WriteLine("May");
            //else
            //    Console.WriteLine("Out of Scope"); 
            #endregion

            #region Switch \ Case
            //int M = 7;

            //switch(M)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //   case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Not in Q01");
            //        break;
            //}


            //switch (M)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("31");
            //        break;
            //    case 2:
            //        Console.WriteLine("28");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("30");
            //        break;
            //    default:
            //        break;
            //}


            int Value = 3000;

            ///without Fall into / fall through
            //switch (Value)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 3");
            //        Console.WriteLine("Option 2");
            //        Console.WriteLine("Option 1");
            //        break;

            //    case 2000:
            //        Console.WriteLine("Option 2");
            //        Console.WriteLine("Option 1");
            //        break;

            //    case 1000:
            //        Console.WriteLine("Option 1");
            //        break;

            //    default:
            //        break;
            //}


            //switch (Value)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 3");
            //        goto case 2000;
            //        //break;
            //    case 2000:
            //        Console.WriteLine("Option 2");
            //        goto case 1000;
            //        //break;
            //    case 1000:
            //        Console.WriteLine("Option 1");
            //        break;

            //    default:
            //        break;
            //}

            #endregion

            #region Array
            ///Array Refrenece Type 
            ///C++ Array 
            ///int X[5];  X[2] = 22;
            ///int Marks[3][5] ; X[i][j] = i*j

            //int[] Arr;
            //Array reference Declaration
            //Zero Bytes have been allocated in Heap

            //int[] Arr = new int[5];
            ///allocation array of 5 int Cells in Heap , Initialized

            //int n = int.Parse(Console.ReadLine());
            //int[] Arr = new int[n];

            //int[] Arr = new int[3] { 5, 10, 15 };
            //int[] Arr = new int[] { 5, 10, 15 };

            //int[] Arr = { 1, 2, 3 };            

            //for ( int i=0; i < Arr.Length; i++)
            //    Console.WriteLine(Arr[i]);

            //Arr[3] = 30;

            //int[,] Marks = new int[3, 5];// { { 1, 2, 3 ,4,5}, { 4, 5, 6,7,8 }, {7,8,9,10,11 } };

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //        Marks[i, j] = i * j;

            //Console.WriteLine($" Number of Dim : { Marks.Rank}");

            //int[] Arr1 = { 1, 2, 3, 4, 5 };
            //int[] Arr2 = { 7, 8, 9 };

            //Console.WriteLine($"Arr1 {Arr1.GetHashCode()}");
            //Console.WriteLine($"Arr2 {Arr2.GetHashCode()}");


            ////Arr2 = Arr1;
            /////One Object with Two References , Same Identity , same state
            ////Console.WriteLine("Arr2 = Arr1");


            //Arr2 = (int[])Arr1.Clone();
            ////int[] = Object
            //Derived = Base Ref 

            //// Arr2 new object with the same state as Arr1 , but with Diff identity

            //Console.WriteLine($"Arr1 {Arr1.GetHashCode()}");
            //Console.WriteLine($"Arr2 {Arr2.GetHashCode()}");

            //Arr1[0] = 77;

            //for ( int i=0; i < Arr2.Length; i++ )
            //    Console.WriteLine(Arr2[i]);


            #endregion

            ///Jagged Array
            //int[][] JArr = new int[3][];

            //JArr[0] = new int[10];
            //JArr[1] = new int[15];
            //JArr[2] = new int[5];


            //JArr[0][0] = 20;


        }
    }

}
