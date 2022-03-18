using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public delegate string BookFuncDel<in T>(T i); //class delgate class return string and take andy type t
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, BookFuncDel<Book>fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
