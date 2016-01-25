using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        public UnitTest1()
        {
            Console.WriteLine("Constructor");
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Console.WriteLine("ClassInitialize {0}", context.FullyQualifiedTestClassName);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Console.WriteLine("ClassCleanup");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine("TestInitialize {0}", TestContext.TestName);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine("TestCleanup {0} Outcome={1}", TestContext.TestName, TestContext.CurrentTestOutcome);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Running test case " + TestContext.TestName);
        }

    }
}
