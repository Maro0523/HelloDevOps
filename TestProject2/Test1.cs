using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using HelloDevOps;

namespace TestProject2
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Test_ConsoleOutput_Content()
        {
            using var sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(Array.Empty<string>());

            var result = sw.ToString().Trim();
            Assert.AreEqual("Hello DevOps", result);
        }

        [TestMethod]
        public void EnnekAzIssueMiattElKellBuknia()
        {
            Assert.Fail("Pipeline teszt hiba Issue generáláshoz.");
        }
    }
}