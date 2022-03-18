using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Ground
    {
        public string gallery;
        public string groundSurface;
        public string audience;

        public string ToString() => $"{gallery}, {groundSurface}, {audience}";
    }
}
