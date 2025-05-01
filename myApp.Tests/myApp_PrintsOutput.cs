using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myApp;

namespace myApp.Tests
{
    [TestClass]
    public class myApp_PrintsOutput
    {
        class BrokenProgram : Program
        {
            protected override void say_hello()
            {
                throw new Exception("Forcing failure in say_hello");
            }

            protected override void say_bye()
            {
                throw new Exception("Forcing failure in say_bye");
            }
        }

        [TestMethod]
        public void IsConsoleOutput_Printed()
        {
            Program.Main(); // test original

            try
            {
              var program = new BrokenProgram();
            }
            catch
            {
                Assert.Fail("The exception was not caught within Program");
            }
        }
    }
}