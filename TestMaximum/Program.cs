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
            string outputInt1 = CheckMaximumString.MaxStringNumber("34", "23", "12");

            // Passing input with max number at second place
            string outputInt2 = CheckMaximumString.MaxStringNumber("129", "489", "19");

            // Passing input with max number at third place
            string outputInt3 = CheckMaximumString.MaxStringNumber("64", "120", "180");

            // Print output
            Console.WriteLine($"Max of (\"34\", \"23\", \"12\") is {outputInt1}");
            Console.WriteLine($"Max of (\"129\", \"489\", \"19\") is {outputInt2}");
            Console.WriteLine($"Max of (\"64\", \"120\", \"180\") is {outputInt3}");
        }
    }
}
