using System;
using System.Collections.Generic;

namespace D07
{
    internal class Program
    {

        //public static int SumLst ( ArrayList aLst )
        //{
        //    int Sum = 0;
        //    for (int i = 0; i < aLst?.Count; i++)
        //        Sum +=(int) aLst[i]; // UnBoxing , unsafe

        //    return Sum;
        //}

        public static int SumLst (List<int> aLst)
        {
            int Sum = 0;
            for( int i = 0; i < aLst?.Count; i++ )
                Sum += aLst[i];
            return Sum;
        }
        static void Main(string[] args)
        {
            #region Generics
            //int A = 7;
            //int B = 3;

            ////Helper.SWAP(ref A , ref B);
            ////Helper.SWAP<int>(ref A, ref B); ///Generic Method
            //Helper<int>.SWAP(ref A,ref B);

            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //double D1 = 1.2345, D2 = 1234.5;
            ////Helper.SWAP(ref D1, ref D2); ///Generic Method , Type inference
            //Helper<double>.SWAP(ref D1, ref D2); ///Generic Class ,No Type inference


            //Console.WriteLine($"D1 = {D1}");
            //Console.WriteLine($"D2 = {D2}");

            //string Str1 = "ABC", Str2 = "XYZ";
            ////Helper.SWAP(ref Str1, ref Str2);
            //Helper<string>.SWAP(ref Str1, ref Str2);

            //Console.WriteLine($"Str1 = {Str1}");
            //Console.WriteLine($"Str2 = {Str2}");

            //Point P1 = new() {  X = 10 , Y = 20 };
            //Point P2 = new() { X = 30, Y = 40 };

            ////Helper.SWAP(ref P1, ref P2);
            //Helper<Point>.SWAP(ref P1, ref P2);


            //Console.WriteLine($"P1 = {P1}");
            //Console.WriteLine($"P2 = {P2}");

            ////Helper.SWAP(ref P1, ref D1);

            //Helper<int> intHelper = new(); 
            #endregion

            #region UnGeneric Collection
            //ArrayList lst = new ArrayList();

            //lst.Add(1);//Boxing
            //lst.Add(2);
            //lst.Add("3"); ///Compiler can't enforce Type Safety @ Compilation
            //lst.Add(4);


            //Console.WriteLine(lst.Count);

            //Console.WriteLine(SumLst(lst)); 
            #endregion

            #region LIST<T>
            //List<int> Lst = new();
            //Console.WriteLine($"Count {Lst.Count} , Capacity {Lst.Capacity}");


            //Lst.Add(1); ///Resizing
            //Console.WriteLine($"Count {Lst.Count} , Capacity {Lst.Capacity}");

            //Lst.Add(2);
            ////Lst.Add("3");/// Compiler enforce Type safety @ compilation
            //Lst.Add(3);
            //Lst.Add(4);
            //Console.WriteLine($"Count {Lst.Count} , Capacity {Lst.Capacity}");


            //Lst.Add(5); ///Resizing
            //Console.WriteLine($"Count {Lst.Count} , Capacity {Lst.Capacity}");

            //Lst[0] = 11; //update

            //Lst.AddRange(new int[] { 6, 7, 8, 9 });
            //Console.WriteLine($"Count {Lst.Count} , Capacity {Lst.Capacity}");

            ////Console.WriteLine(SumLst(Lst));

            //Lst.TrimExcess();
            //Console.WriteLine($"Count {Lst.Count} , Capacity {Lst.Capacity}");

            //Lst.Add(10);
            //Console.WriteLine($"Count {Lst.Count} , Capacity {Lst.Capacity}");

            ////Lst[10] = 11; //exception

            //for ( int i = 0; i < Lst?.Count;i++ )
            //    Console.Write($"{Lst[i]} , "); //O(1) 
            #endregion

            #region Dictionary
            //Dictionary<string, long> PhoneBook = new Dictionary<string, long>();

            //PhoneBook.Add("ABC", 123);
            //PhoneBook.Add("XYZ", 456);
            //PhoneBook.Add("KLM", 789);

            //PhoneBook["DEF"] = 707;//Add

            //PhoneBook["XYZ"] = 654; ///update

            /////unsafe
            ////PhoneBook.Add("XYZ", 654); // if Key already existing , Exception

            //if ( PhoneBook.TryAdd("XYZ" , 654))
            //    Console.WriteLine("Added");
            //else
            //    Console.WriteLine("Existing Key");

            //Console.WriteLine(PhoneBook["XYZ"]);

            ////unsafe
            ////Console.WriteLine(PhoneBook["ADC"]); ///if Key not existing , throw exception

            //if (PhoneBook.ContainsKey("ADC"))
            //    Console.WriteLine(PhoneBook["ADC"]);
            //else
            //    Console.WriteLine("Not Found");

            //if ( PhoneBook.TryGetValue("ADC" , out long Number))
            //    Console.WriteLine(Number);
            //else
            //    Console.WriteLine("Not Found");



            //foreach (KeyValuePair<string , long>  item in PhoneBook)
            //{
            //    Console.WriteLine($"{item.Key}:::{item.Value}");
            //} 
            #endregion

            //Mutable
            //Point P1 = new() {  X = 10 , Y = 20 };
            //Point P2 = new() { X = 15, Y = 15 };
            //Point P3 = new();
            //Point P4 = new() { X = 10 , Y = 20 };
            //Point P5 = P1;

            //Immutable
            Point P1 = new(10, 20);// { X = 10, Y = 20 };
            Point P2 = new(15, 15);// { X = 15, Y = 15 };
            Point P3 = new(0,0);
            Point P4 = new(10, 20);// { X = 10, Y = 20 };
            Point P5 = P1;



            Console.WriteLine($"P1 {P1.GetHashCode()}");
            Console.WriteLine($"P2 {P2.GetHashCode()}");
            Console.WriteLine($"P3 {P3.GetHashCode()}");
            Console.WriteLine($"P4 {P4.GetHashCode()}");
            Console.WriteLine($"P5 {P5.GetHashCode()}");

            //P4 same state as P1 , Diff Identity
            //P5 same State , same identity as P1

            Dictionary<Point , String> map = new Dictionary<Point , String>();
            map.Add(P1, "Left Corner");
            map.Add(P2, "Right Corner");
            map.Add(P3, "Center");

            //Dictionary check Uniqness for KEy , Search for Value Bucket based on 
            //1. Key Hash Code , return GetHashCode()
            //2. if Hash code initially matched with another hash 
            //3. verify using Equals


            if ( map.TryGetValue(P4 , out string Str))
                Console.WriteLine(Str);
            else
                Console.WriteLine("P4 not Found");


            if (map.TryGetValue(P5, out string Str2))
                Console.WriteLine(Str2);
            else
                Console.WriteLine("P5 not Found");

            #region New Identity
            /////Remove P3 first from Dictionay 
            /////Create new Identity
            /////re Add Key Value Pair
            //map.Remove(P3);

            //P3 = new Point() { X = 50 , Y = 50 };
            ////P3 having new Identity 
            ////value is lost 
            //Console.WriteLine($"P3 {P3.GetHashCode()}");

            //map.Add(P3, "Center");


            //if (map.TryGetValue(P3, out string Str3))
            //    Console.WriteLine(Str3);
            //else
            //    Console.WriteLine("P3 lost "); 
            #endregion


            #region Loss Value Proplem
            /////when overrding GethashCode , Equals to be based on Values (State)
            /////Solution : use Immutable Key Datatype
            /////Lost Values 
            //P3.X = 50;P3.Y = 50;
            ////Changing P3 state will result in loss of Value inside Dictionry

            //Console.WriteLine($"P3 {P3.GetHashCode()}");

            //if (map.TryGetValue(P3, out string Str3))
            //    Console.WriteLine(Str3);
            //else
            //    Console.WriteLine("P3 Value Lost"); 
            #endregion

            //map.remove(P3)
            //to change P3 state , you have to create new identity , new object
            P3 = new(50, 50);
       
            //reAdd P3
            //map.Add(P3 ,"Center");
        
        }

    }
}
