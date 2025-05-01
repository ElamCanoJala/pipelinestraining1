 using Microsoft.VisualStudio.TestTools.UnitTesting;
using myApp;

namespace myApp.Tests
{
    [TestClass]
    public class myApp_PrintsOutput
    {
        [TestMethod]
        public void IsConsoleOutput_Printed()
        {
            
            // Program _program = new Program();
            // _program.say_hello();
            // _program.say_bye();
         
            Program.Main();
           
        }
    }
} 
//
/*  using Microsoft.VisualStudio.TestTools.UnitTesting;
using myApp;
using System;
using System.IO;

namespace myApp.Tests
{
    [TestClass]
    public class myApp_PrintsOutput
    {
        [TestMethod]
        public void IsConsoleOutput_Printed()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw); // Redirigir la salida de consola

                var messagePrinter = new MessagePrinter();
                messagePrinter.PrintHello();
                messagePrinter.PrintBye();

                var output = sw.ToString().Trim(); // Obtener el contenido de la salida
                var expectedOutput = Figgle.FiggleFonts.Standard.Render("Hello, World!").Trim() + Environment.NewLine + 
                                     Figgle.FiggleFonts.Standard.Render("Bye, World!").Trim();

                Assert.AreEqual(expectedOutput, output); // Comparar la salida con la esperada
            }
        }
    }
} */


 //
/*  using Microsoft.VisualStudio.TestTools.UnitTesting;
using myApp;
using System;

namespace myApp.Tests
{
    [TestClass]
    public class myApp_PrintsOutput
    {
        [TestMethod]
        public void IsConsoleOutput_Printed()
        {
            // Crear un StringWriter para capturar la salida de la consola
            using (var sw = new StringWriter())
            {
                // Redirigir la salida de la consola al StringWriter
                Console.SetOut(sw);

                // Crear una instancia de MessagePrinter y ejecutar el método
                var printer = new MessagePrinter();
                printer.PrintMessages();

                // Obtener la salida de la consola
                var output = sw.ToString().Trim();

                // Crear la salida esperada
                var expectedOutput = Figgle.FiggleFonts.Standard.Render("Hello, World!").Trim() + Environment.NewLine + 
                                     Figgle.FiggleFonts.Standard.Render("Bye, World!").Trim();

                // Verificar que la salida es la esperada
                Assert.AreEqual(expectedOutput, output);
            }
        }
    }
} */