using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Template_Method
{
    abstract class AbsAlgorithm
    {
        ///Define Skelton of an Algorithm in a Method
        public void ExecuteAnAlgorithm()
        {
            ///Step 1
            LoadData();
            ///Step 2
            ProcessData();
            ///Step 3
            SaveResults();
            ///Step 4
            PublishResults();

            ///Optional Step
            OptionalStep();
        }
        ///Deferring Some Steps to Sub Class
        protected abstract void LoadData();
        protected abstract void SaveResults();

        protected virtual void OptionalStep() { }

        protected void ProcessData() => Console.WriteLine("Data Processing");
        protected void PublishResults() => Console.WriteLine("Results .....");
    }
}
