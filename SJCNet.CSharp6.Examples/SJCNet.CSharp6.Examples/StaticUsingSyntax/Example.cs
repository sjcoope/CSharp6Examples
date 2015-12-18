using static System.Console;

namespace SJCNet.CSharp6.StaticUsingSyntax
{
    public class Example : IExample
    {
        public void Execute()
        {
            WriteLine("This is written using a static using statement.");
        }
    }
}
