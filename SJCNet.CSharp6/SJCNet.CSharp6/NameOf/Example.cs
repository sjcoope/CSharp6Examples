using SJCNet.CSharp6.Utility;
using static System.Console;

namespace SJCNet.CSharp6.NameOf
{
    public class Example : IExample
    {
        public void Execute()
        {
            Logger.WriteSubHeader("Name Of Expression Example");

            var person = new Person(Genders.Male);

            // Null reference check
            if (person.GivenNames == null)
            {
                // Previous approach
                WriteLine("GivenNames is null");

                // New approach
                WriteLine($"{nameof(person.GivenNames)} is null");
            }
        }
    }
}
