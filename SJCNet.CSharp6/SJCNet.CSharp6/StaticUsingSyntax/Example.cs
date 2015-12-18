using SJCNet.CSharp6.Utility;
using static System.Console;

namespace SJCNet.CSharp6.StaticUsingSyntax
{
    public class Example : IExample
    {
        public void Execute()
        {
            Logger.WriteSubHeader("Static Using Syntax Example");
            WriteLine("This is written using a static using statement.");
        }
    }
}
