using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine(CheckMaximumInt.welcome());


            // Take input from the user
            int outputInt = CheckMaximumInt.MaxIntNumber(12, 23, 34);

            // Print output
            Console.WriteLine(outputInt);
        }
    }
}
