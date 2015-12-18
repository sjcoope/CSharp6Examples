using SJCNet.CSharp6.Utility;

namespace SJCNet.CSharp6.AutoPropertyInitializer
{
    public class Example : IExample
    {
        public void Execute()
        {
            Logger.WriteSubHeader("Auto Property Initializer");

            Logger.Write("Person object created with default values");
            var person1 = new Person();
            Logger.Write($"GivenNames: {person1.GivenNames} FamilyName: {person1.FamilyName} Age: {person1.Age}");
            Logger.AddLineBreak();

            Logger.Write("Person object with values set during constructions");
            var person2 = new Person("Barry Nigel", "Adams",62);
            Logger.Write($"GivenNames: {person2.GivenNames} FamilyName: {person2.FamilyName} Age: {person2.Age}");
            Logger.AddLineBreak();
        }
    }
}