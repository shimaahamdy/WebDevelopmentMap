using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Class2
    {
        public Class2()
        {
            TypeOne O1 = new();
            O1.Z = 1;//internal
            O1.M = 2;//Public
            O1.K = 3;
            
        }
    }

    class TypeTwo:TypeOne
    {
        public TypeTwo()
        {
            this.Y = 3; //protected
            this.Z = 4;
            this.M = 5;
            this.K = 6;
            L = 7;
        }
    }
}
