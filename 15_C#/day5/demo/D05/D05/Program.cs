using System;
using Model;

namespace D05
{
    class TypeThree:TypeOne
    {
        public TypeThree()
        {
            this.Y = 1;
            this.M = 2;
            this.K = 3;
            //this.L = 4; Inaccessable
            //this.Z = 3;///Inaccessable , out of assembly file
        }
    }

    internal class Program
    {
        public static void Main ()
        {
            Point P1 = new Point() { X = 10, Y = 20 };
            Point P2 = new Point() { X = 30, Y = 40 };
            Point P3 = default;
            Point P4 = default;

            //P3 = P1 + P2;
            //P3 = P1 + 50;
            //P3 = 50 + P1;

            //P1 += P2;

            P3 = ++P1;
            P4 = P2++;

            Console.WriteLine(P1);
            Console.WriteLine(P2);
            Console.WriteLine(P3);
            Console.WriteLine(P4);

            if (P1 == P2)
                ;

            string Str = (string)P1; //explicit Casting
            int R = P1; ///implicit Casting

            Point3D PP =  new Point3D() {  XPos = 10 , YPos = 20  , ZPos = 30};

            P1 = PP;

            //if (P1) ; //implicit operator Bool or Operator overloading for true\false

            #region SingleTon
            //GEngine G01 = GEngine.SingleTonObj;
            //    //GEngine.GetEngine();
            ////= new GEngine(123);
            //GEngine G02 = GEngine.SingleTonObj;
            ////GEngine.GetEngine();
            //;//= new GEngine(456);



            //Console.WriteLine(G01.GetHashCode());
            //Console.WriteLine(G02.GetHashCode()); 
            #endregion

            #region Static Class , Ctor
            //Console.WriteLine(Utility.Inch2CM(10));
            //Console.WriteLine(Utility.CircleArea(20));

            ////Utility U1 = new Utility();// {  X = 1 , Y = 2 };
            ////Utility U2 = new Utility();// { X = 3 , Y = 4 };

            ////Console.WriteLine(U1.Inch2CM(10));
            ////Console.WriteLine(U2.Inch2CM(10));
            //Console.WriteLine(Utility.CircleArea(20)); 
            #endregion

            #region Class Ctors
            //TypeOne O2 = new();
            //O2.M = 1;

            ////Point P1 = new();
            ////P1.X = 20;
            ////P1.Y = 50;

            ////Point P1 = new Point() { X = 20, Y = 20 };
            ////Object Initializer with any accessable Attribute\Property


            //Point P1;
            /////Zero Bytes have been allocated

            //P1 = new Point();
            /////new Allocate in Heap (8 Byte + OverHead Variables) in Heap
            /////Initialize Allocated Bytes( all Members will be initialized with default value)
            /////Call Ctor if exists
            /////Assign Refrence to newely allocated object

            ////Point P2 = new Point(P1); /// Copy Ctor
            //Point P2 = new(P1);

            //P1 = null;

            //Console.WriteLine(P1); 
            #endregion

            #region Exception Handling
            //try
            //{
            //    //DoSomeWork();
            //    DoSomeProtectiveWork();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Main Catch Block {ex.Message}");
            //} 
            #endregion
        }

        static void DoSomeProtectiveWork ()
        {
            int X, Y, Z;

            do
            {
                Console.WriteLine("Enter First Number");
            } while (int.TryParse(Console.ReadLine () , out X) ==false);

            do
            {
                Console.WriteLine("Enter Second Number");
            } while ((!int.TryParse(Console.ReadLine(), out Y))||(Y<=0));

            int[] Arr = { 1, 2, 3, 4, 5 };

            if (5 < Arr?.Length)
                Arr[5] = 20;

        }

        static void DoSomeWork()
        {
            int X = default, Y = default, Z;

            try
            {
                X = int.Parse(Console.ReadLine());
                Y = Convert.ToInt32(Console.ReadLine());

                Z = X / Y;

                if (Y < 0)
                    throw new NegativeOperandException();

                Console.WriteLine(Z);

                int[] Arr = { 1, 2, 3, 4, 5 };

                Arr[5] = 20;

                Console.WriteLine("End of try");
            }
            catch (NegativeOperandException Ex)
            {

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Casting Error");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Y should not be Zero");
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            finally
            {
                Console.WriteLine("Inside Finally");
            }

            Console.WriteLine("After Try & Catch");

        }
    }
}
