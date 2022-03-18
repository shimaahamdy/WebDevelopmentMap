using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    class NegativeOperandException : Exception
    {
        public NegativeOperandException():base("Y Must be Greater than 0")
        {

        }
    }
}
