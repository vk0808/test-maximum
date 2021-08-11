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
            double outputInt1 = CheckMaximumFloat.MaxFloatNumber(3.4, 2.3, 1.2);

            // Passing input with max number at second place
            double outputInt2 = CheckMaximumFloat.MaxFloatNumber(12.9, 48.9, 1.9);

            // Passing input with max number at third place
            double outputInt3 = CheckMaximumFloat.MaxFloatNumber(6.4, 12.0, 18.0);

            // Print output
            Console.WriteLine($"Max of (3.4, 2.3, 1.2) is {outputInt1}");
            Console.WriteLine($"Max of (12.9, 48.9, 1.9) is {outputInt2}");
            Console.WriteLine($"Max of (6.4, 12.0, 18.0) is {outputInt3}");
        }
    }
}
