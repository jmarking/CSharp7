using CSharp7.NewFeatures;
using System;

namespace CSharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            UseOutVariables();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void UseOutVariables()
        {
            var outVariables = new OutVariables();

            Console.WriteLine("Enter int value to try parse: ");
            var input = Console.ReadLine();

            Console.WriteLine("\nBoth usages will still provide same result as expected.");
            Console.WriteLine($"Old 'out' variable parse result: {outVariables.OldoutVariableUsage(input)}");
            Console.WriteLine($"New 'out' variable parse result: {outVariables.NewoutVariableUsage(input)}\n");
        }
    }
}
