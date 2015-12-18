﻿using SJCNet.CSharp6.Utility;
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

            Logger.WriteFooter("Ended");
            Read();
        }
    }
}
