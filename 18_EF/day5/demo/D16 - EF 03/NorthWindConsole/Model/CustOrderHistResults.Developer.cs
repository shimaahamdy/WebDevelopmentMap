using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindConsole
{
    partial class CustOrderHistResult
    {
        public override string ToString() => $"{this.ProductName },{ this.Total}";
    }
}
