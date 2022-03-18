using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    ///Bit Flag Enum
    [Flags]
    enum Permissions : Byte
    { Read = 0x08 , Write = 0b_0000_0100 , Execute = 2 , Delete = 0x01 , SuperUser = 0b_0000_1110 , Root = 0x0F}

    internal class Class1
    {
        public static void Main ()
        {
            #region Bit Flag Enum
            //Permissions MyP;
            //MyP = Permissions.Read;

            //Console.WriteLine(MyP);

            //MyP ^= Permissions.Execute;

            //Console.WriteLine(MyP);

            //MyP ^= Permissions.Read;
            //Console.WriteLine(MyP);

            //MyP = (Permissions)0x0F;

            //Console.WriteLine(MyP); 
            #endregion

            #region Properties
            //Employee E = new Employee ();

            //E.EmpID = -101;

            //Console.WriteLine(E.EmpID);

            //E.SetName("Ahmed");

            //Console.WriteLine(E.GetName());

            //E.Salary = 1200;

            //Console.WriteLine(E.Salary);

            //decimal T = E.Taxes; // Get

            ////E.Taxes = 500; 
            #endregion

            PhoneBook phoneBook = new PhoneBook (5);

            phoneBook.SetEntry(0, "ABC", 123);
            phoneBook.SetEntry(1, "XYZ", 456);
            phoneBook.SetEntry(2, "KLM", 789);

            phoneBook[3, "DEF"] = 707;

            phoneBook["ABC"] = 321; //set

            Console.WriteLine(
                
                //phoneBook.GetNumber("ABC")
                phoneBook["ABC"] //Get
                );

            for (int i = 0; i < phoneBook.Size; i++)
                Console.WriteLine(phoneBook[i]);


        }
    }
}
