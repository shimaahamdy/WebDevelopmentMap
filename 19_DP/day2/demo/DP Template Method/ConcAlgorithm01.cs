using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Template_Method
{
    class ConcAlgorithm01 : AbsAlgorithm
    {
        protected override void LoadData()
        {
            Console.WriteLine("Loading Data from DB");
        }

        protected override void SaveResults()
        {
            Console.WriteLine("Saving Results in DB");
        }
    }
}
