using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07
{
    public class Helper<T> where T :

        ///Primary Constraint 
        ///Special Primary Constraint 
        ///class,
        ///Special Primary Constraint 
        ///struct,
        ///Enum,
        ///General Primary constraint any specific class
        //Point,

        ///Secondary Constraint
        ///Interface Constraint
        /// Accept any Datatype implementing IComparable interface
        /// 0:* , accept multiple Secondary constraint
        IComparable<T>

        ///Ctor Constraint
        ///Only one available ctor Constraint
        ///can't combine struct , new()
        //,new() /// T data type having accessable paramterless ctor
    {
        public Helper()
        {
            ///Valid
            ///1. Declaration
            T X;
            T Y;

            ///2.Initialization
            X = default;

            ///3. Assigment
            Y = X;

            ///4. return 
            ///T MyFun () { T Y = default ; return Y;}

            ///5. System.Object
            Object O1 = X;

            ///6. 9. System.object Members
            string Str = X.ToString();
            if (X.GetHashCode() != Y.GetHashCode()) ;
            if (X.GetType().Name == "") ;
            if (X.Equals(Y)) ;

            ///where T:Icomparable
            //int R = X.CompareTo(Y);

            ///where T:class
            //X = null;
            //if (X == Y) ;

            //where T:struct
            //X = new T();

            ///valid
            //X = 0;
            //X = null;
            //X = new T();

        }

        //public static T Sum (T X , T Y) {  return X + Y; }

        public static void BSort (T[] items)
        {
            for (int i = 0; i < items?.Length; i++)
                for (int j = 0; j < items.Length - i - 1; j++)
                    if (items[j].CompareTo(items[j + 1]) > 0)
                        SWAP(ref items[j], ref items[j + 1]);
        }

        public int SearchArray (T[] Arr , T Value)
        {
            for (int i = 0; i < Arr?.Length; i++)
                if (Arr[i].Equals(Value))
                    return i;
            return -1;
        }


        public static void SWAP(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }


        #region Non Generic SWAP
        //public static void SWAP ( ref int X , ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref double X, ref double Y)
        //{
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref string X, ref string Y)
        //{
        //    string Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        #endregion
    }
}
