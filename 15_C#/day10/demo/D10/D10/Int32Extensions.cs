using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace D10
{
    static class Int32Extensions
    {
        ///Extension Method
        public static int Mirror (this int X)
        {
            var Chrs = X.ToString().ToCharArray();
            Array.Reverse (Chrs);

            if (int.TryParse( new string (Chrs) , out int R))
                return R;
            return 0;
        }
    }
}
