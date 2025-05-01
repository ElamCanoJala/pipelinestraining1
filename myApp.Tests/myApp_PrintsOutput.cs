 using Microsoft.VisualStudio.TestTools.UnitTesting;
using myApp;

namespace myApp.Tests
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
        Program.Main();

        try
        {
            var broken = new BrokenProgram();
        }
        catch
        {
            // just ignore this
        }
    }
}




   /*  [TestClass]
    public class myApp_PrintsOutput
    {
        [TestMethod]
        public void IsConsoleOutput_Printed()
        {
            
            // Program _program = new Program();
             //_program.say_hello();
            // _program.say_bye();
         
            Program.Main();
           
        }
    }
}  */