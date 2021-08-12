using System;

namespace TestMaximum
{
    class Program 
    {

        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine(CheckMaximumInt.welcome());


            // Passing integer input with max number at first place
            GenericMax<int> genInt = new GenericMax<int>(34, 23, 12);
            int outputInt1 = genInt.MaxMethod();


            // Passing double input with max number at second place
            GenericMax<double> genFloat = new GenericMax<double>(12.9, 48.9, 1.9);
            double outputInt2 = genFloat.MaxMethod();


            // Passing string input with max number at third place
            GenericMax<string> genString = new GenericMax<string>("apple", "banana", "peach");
            string outputInt3 = genString.MaxMethod();


            // Print output
            Console.WriteLine($"Max of 3 int (34, 23, 12) is {outputInt1}");
            Console.WriteLine($"Max of 3 double (12.9, 48.9, 1.9) is {outputInt2}");
            Console.WriteLine($"Max of 3 string (apple, banana, peach ) is {outputInt3}");
        }
    }
}
