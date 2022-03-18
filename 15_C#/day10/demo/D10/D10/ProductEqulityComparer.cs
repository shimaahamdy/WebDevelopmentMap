using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10
{
    class ProductEqulityComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product x, Product y)
        {
            return x.ProductID == y.ProductID;
        }

        public int GetHashCode( Product obj)
        {
            return (int)obj.ProductID;
        }
    }
}
