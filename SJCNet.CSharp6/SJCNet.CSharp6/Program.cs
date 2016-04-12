using SJCNet.CSharp6.Utility;
using static System.Console;

namespace SJCNet.CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.WriteHeader("Started");

            // Example: Static Using Syntax
            var staticUsingSyntaxExample = new StaticUsingSyntax.Example();
            staticUsingSyntaxExample.Execute();

            // Example: Auto Property Initializers
            var autoPropertyInitializerExample = new AutoPropertyInitializer.Example();
            autoPropertyInitializerExample.Execute();

            // Example: Index Initializers
            var indexInitializerExample = new IndexInitializers.Example();
            indexInitializerExample.Execute();

            // Example: String Interpolation
            var stringInterpolationExample = new StringInterpolation.Example();
            stringInterpolationExample.Execute();

            // Example: Name Of
            var nameOfExample = new NameOf.Example();
            nameOfExample.Execute();

            // Example: Exception Filter
            var exceptionFilterExample = new ExceptionFilter.Example();
            exceptionFilterExample.Execute();

            // Example: Expression Bodied Members
            var expressionBodiedMembersExample = new ExpressionBodiedMembers.Example();
            expressionBodiedMembersExample.Execute();

            // Example: Null Conditional Operators
            var nullConditionalOperatorsExample = new NullConditionalOperators.Example();
            nullConditionalOperatorsExample.Execute();

            // Example: Await in Catch and Finally
            var awaitInCatchAndFinallyExample = new AwaitInCatchAndFinally.Example();
            awaitInCatchAndFinallyExample.Execute();

            Logger.WriteFooter("Ended");
            ReadLine();
        }
    }
}
