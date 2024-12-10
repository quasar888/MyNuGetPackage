
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MyNuGetPackage;

namespace MyNuGetTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyNuGetPackage.Program.Add(1,9);
        }
    }
}
