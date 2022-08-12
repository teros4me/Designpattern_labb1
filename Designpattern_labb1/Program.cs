using Designpattern_labb1.Methods;
using System;

namespace Designpattern_labb1
{
    partial class Program
    {
        // Valda designmönster: Factory Method, Strategy och Singleton.

        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Här kan du beställa kött i hel-, halv-, eller kvartsbit.");

            MenuMethod.Menu();
        }
    }
}
