using SJCNet.CSharp6.Utility;

namespace SJCNet.CSharp6.ExpressionBodiedMembers
{
    public class Example : IExample
    {
        public void Execute()
        {
            Logger.WriteSubHeader("Expression Bodied Members");

            var person = new Person("Arthur James", "Smith", 92);
            Logger.Write($"FullName: {person.FullName}");
            Logger.Write($"Greet: {person.Greet("G'day")}");
            Logger.AddLineBreak();
        }
    }
}