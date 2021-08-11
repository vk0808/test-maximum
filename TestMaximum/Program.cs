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


            // Print output
            Console.WriteLine(outputInt1);
        }
    }
}
