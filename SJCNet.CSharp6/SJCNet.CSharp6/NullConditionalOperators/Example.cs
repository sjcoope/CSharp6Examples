using System.Collections.Generic;
using System.Linq;
using SJCNet.CSharp6.Utility;

namespace SJCNet.CSharp6.NullConditionalOperators
{
    public class Example : IExample
    {
        public void Execute()
        {
            Logger.WriteSubHeader("Expression Bodied Members");

            var people = new List<Person>
            {
                new Person("Barry Clive", "Jones", 57),
                null,
                new Person("Smith")
            };

            // Null Conditional Member Operator
            if (people?.Count() > 0)
            {
                for (var i = 0; i < people.Count; i++)
                {
                    // Null Conditional Index Operator
                    var person = people?[i];

                    // Null Conditional Member Operator
                    Logger.Write($"Full Name: {person?.FullName}");
                }
            }

            Logger.AddLineBreak();
        }
    }
}