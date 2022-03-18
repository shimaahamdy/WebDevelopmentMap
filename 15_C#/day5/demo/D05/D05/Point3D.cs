using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    struct Point3D
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int ZPos { get; set; }

        public static implicit operator Point (Point3D P)
        {
            return new() { X = P.XPos, Y = P.YPos };
        }

        public override string ToString()
        {
            return $"({XPos},{YPos},{ZPos})";
        }

    }
}
