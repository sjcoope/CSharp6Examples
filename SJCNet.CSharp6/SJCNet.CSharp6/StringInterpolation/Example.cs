using SJCNet.CSharp6.AutoPropertyInitializer;
using SJCNet.CSharp6.Utility;
using static System.Console;

namespace SJCNet.CSharp6.StringInterpolation
{
    public class Example : IExample
    {
        public void Execute()
        {
            Logger.WriteSubHeader("String Interpolation Example");

            var person = new Person("John", "Smith", 29, Genders.Male);

            // Previous Approach
            WriteLine(string.Format("Hello, my name is {0} and I am {1} years old!", person.GivenNames, person.Age));

            // New Approach
            WriteLine($"Hello, my name is {person.GivenNames} and I am {person.Age} years old!");
        }
    }
}
