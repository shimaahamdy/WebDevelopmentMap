using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public class UniqueName : IEqualityComparer<Product>
    {
        public bool Equals(Product x, Product y)
        {
            return x.Category == y.Category;
        }

        public int GetHashCode(Product obj)
        {
            return HashCode.Combine(obj.Category);
        }
    }
}
