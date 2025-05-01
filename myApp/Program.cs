 using System;

namespace myApp
{
    public class Program
    {
        public static void Main()
        {
            Program helloApp = new();
            Console.WriteLine(helloApp.ToString());
        }

        protected Program()
        {
            this.say_hello();
            this.say_bye();
        }

        protected virtual void say_hello()
        {
            try {
                Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Hello, World!"));
            } catch (Exception ex) {
                Console.Error.WriteLine(ex.Message);
            }
        }

        protected virtual void say_bye()
        {
            try {
                Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Bye, World!"));
            } catch (Exception ex) {
                Console.Error.WriteLine(ex.Message);
            }
        }
    }
}
/* namespace myApp
{
    public class Program
    {
        public static void Main()
        {
            Program helloApp = new();
            Console.WriteLine(helloApp.ToString());
        }

        private Program() {
            this.say_hello();
            this.say_bye();
        }

        private void say_hello()
        {
            try{
                Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Hello, World!"));
                //Console.WriteLine("The current time is " + DateTime.Now);
                //Console.WriteLine(result);
            }catch (Exception ex){
                Console.Error.WriteLine(ex.Message);
            }
        }

        private void say_bye()
        {
            try{
                Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Bye, World!"));
                //Console.WriteLine("The current time is " + DateTime.Now);
                //Console.WriteLine(result);
            }catch (Exception ex){
                Console.Error.WriteLine(ex.Message);
            }
        }

    }
} */