using SJCNet.CSharp6.Utility;
using System.Collections.Generic;
using static System.Console;

namespace SJCNet.CSharp6.IndexInitializers
{
    public class Example : IExample
    {
        public void Execute()
        {
            Logger.WriteSubHeader("Dictionary Initializer Example");

            Logger.Write("Populating dictionary");
            var familtyMembers1 = InitializeUsingNewWay();

            Logger.Write("Outputting dictionary contents");
            foreach(var kvp in familtyMembers1)
            {
                Logger.Write($"Family Member: {kvp.Key} - {kvp.Value}");
            }

            Logger.AddLineBreak();
            Logger.Write("Populate non dictionary type");
            var familyMembers2 = InitializeNonDictionaryType();

            Logger.Write("Outputting non dictionary type contents");
            foreach(var familyMember in familyMembers2)
            {
                Logger.Write($"Family Member: {familyMember}");
            }
        }

        private Dictionary<string, string> InitializeUsingNewWay()
        {
            var output = new Dictionary<string, string>()
            {
                ["Father"] = "John Smith",
                ["Mother"] = "Jane Smith",
                ["Daughter"] = "Sally Smith",
                ["Son"] = "Bertie Smith"
            };

            return output;
        }

        private Dictionary<string, string> InitializeUsingOldWay()
        {
            var output = new Dictionary<string, string>()
            {
                {"Father", "John Smith"},
                {"Mother", "Jane Smith"},
                {"Daughter", "Sally Smith"},
                {"Son", "Bertie Smith"},
            };
            
            return output;
        }

        private List<string> InitializeNonDictionaryType()
        {
            var array = new[] { "John Smith", "Jane Smith", "Incorrect Input", "Bertie Smith" };
            var output = new List<string>(array) { [2] = "Sally Smith" };
            return output;
        }

        private Dictionary<string, string> DuplicateInitializationUsingNewWay()
        {
            // Output is a dictionary of one item with a key of "Father" and a value of "Jane Smith".
            var output = new Dictionary<string, string>
            {
                ["Father"] = "John Smith",
                ["Father"] = "Jane Smith",
            };

            return output;
        }

        private Dictionary<string, string> DuplicateInitializationUsingOldWay()
        {
            // Throws an error
            var output = new Dictionary<string, string>()
            {
                {"Father", "John Smith"},
                {"Father", "Jane Smith"},
            };

            return output;
        }
    }
}
