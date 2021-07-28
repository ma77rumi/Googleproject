using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestProj
{
    [TestClass]
    public class MSTestDemo
    {
        //[AssemblyInitialize]
        public void AssemblyIni()
        {
            Console.WriteLine("Assembly initialize");
        }

        //[AssemblyCleanup]
        public void AssemblyClean()
        {
            Console.WriteLine("Assembly cleanup");
        }

        [TestInitialize]
        public void BeforeMethod()
        {
            Console.WriteLine("Test initialize");
        }

        [TestCleanup]
        public void AfterMethod()
        {
            Console.WriteLine("Test cleanup");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Test method1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Test method2");
        }
    }
}
