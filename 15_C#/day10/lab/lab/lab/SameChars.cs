using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public class SameChars : IEqualityComparer<string>
    {
        public bool Equals(string a, string b)
        {
            var str1 = a.ToList();
            var str2 = b.ToList();

            // Get lengths of both strings
            int n1 = str1.Count;
            int n2 = str2.Count;

            // If length of both strings is not
            // same, then they cannot be anagram
            if (n1 != n2)
            {
                return false;
            }

            // Sort both strings
            str1.Sort();
            str2.Sort();

            // Compare sorted strings
            for (int i = 0; i < n1; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public int GetHashCode( string obj)
        {
            return HashCode.Combine(obj);
        }
    }
}
