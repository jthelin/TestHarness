using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    public class TestHarness
    {
        public static void Main(string[] args)
        {
            try
            {
                TestContext context = new MockTestContext();

                Console.WriteLine("\n===== ClassInitialize");
                MyTests.UnitTest1.ClassInitialize(context);

                Console.WriteLine("\n===== Constructor");
                var test = new MyTests.UnitTest1
                {
                    TestContext = context
                };

                Console.WriteLine("\n---- TestInitialize");
                test.TestInitialize();

                Console.WriteLine("\n---- Run test method\n");

                test.TestMethod1();

                Console.WriteLine("\n---- Test method ran ok");

                Console.WriteLine("\n---- TestCleanup");
                test.TestCleanup();

                Console.WriteLine("\n===== Ended Test successfully - Press Enter to exit.\n");
                Console.ReadLine();
            }
            catch (Exception exc)
            {
                Console.WriteLine("\n===== ERROR: Exception during test execution\n");
                Console.WriteLine(exc.ToString());
                Debugger.Break();
            }
            finally
            {
                Console.WriteLine("\n===== ClassCleanup\n");
                MyTests.UnitTest1.ClassCleanup();
            }
        }
    }
}
