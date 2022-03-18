using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Template_Method
{
     class ConcAlgorithm02:AbsAlgorithm
    {
        protected override void LoadData() => Console.WriteLine("Load Data from Windows Azure");
        protected override void SaveResults() => Console.WriteLine("Saving Data into the Cloud");

        protected override void OptionalStep() => Console.WriteLine("Ad Hock Method");
    }
}
