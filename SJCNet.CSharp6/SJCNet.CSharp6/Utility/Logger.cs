using System;
using static System.Console;

namespace SJCNet.CSharp6.Utility
{
    public static class Logger
    {
        private const int SymbolCount = 40;
        private const char HeaderSymbol = '#';
        private const char SubHeaderSymbol = '-';

        public static void WriteHeader(string heading)
        {
            WriteLine(new String(HeaderSymbol, SymbolCount));
            Write(heading);
            WriteLine(new String(HeaderSymbol, SymbolCount));
            WriteLine(String.Empty);
        }

        public static void WriteFooter(string footer)
        {
            WriteLine(String.Empty);
            WriteLine(new String(HeaderSymbol, SymbolCount));
            Write(footer);
            WriteLine(new String(HeaderSymbol, SymbolCount));
        }

        public static void WriteSubHeader(string message)
        {
            WriteLine(String.Empty);
            WriteLine(message);
            WriteLine(new String(SubHeaderSymbol, SymbolCount));
        }

        public static void Write(string message)
        {
            WriteLine($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}: {message}");
        }
    }
}
