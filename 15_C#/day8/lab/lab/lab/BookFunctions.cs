using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    internal class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            string s = "";
            foreach (string str in B.Authors)
            {
                s += str;
                s += ", ";
            }
            return s;
        }
        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
    }

}
