using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAppTests
{
    [TestClass]
    public class AssemblyHandler
    {
        [AssemblyInitialize]
        public static void AssmeblyInitialize(TestContext testContext)
        {
            testContext.WriteLine("Assembly init");
        }

        [AssemblyCleanup]
        public static void CleanUp()
        {

        }
    }
}
