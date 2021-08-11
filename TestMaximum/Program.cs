using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine(CheckMaximumInt.welcome());


            // Passing input with max number at first place
            int outputInt1 = CheckMaximumInt.MaxIntNumber(34, 23, 12);

            // Passing input with max number at second place
            int outputInt2 = CheckMaximumInt.MaxIntNumber(129, 489, 19);

            // Print output
            Console.WriteLine($"Max of (34, 23, 12) is {outputInt1}");
            Console.WriteLine($"Max of (129, 489, 19) is {outputInt2}");
        }
    }
}
