﻿using System;
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
            AddLineBreak();
        }

        public static void WriteFooter(string footer)
        {
            AddLineBreak();
            WriteLine(new String(HeaderSymbol, SymbolCount));
            Write(footer);
            WriteLine(new String(HeaderSymbol, SymbolCount));
        }

        public static void WriteSubHeader(string message)
        {
            AddLineBreak();
            WriteLine(message);
            WriteLine(new String(SubHeaderSymbol, SymbolCount));
        }

        public static void Write(string message)
        {
            WriteLine($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}: {message}");
        }

        public static void AddLineBreak()
        {
            WriteLine(String.Empty);
        }
    }
}
