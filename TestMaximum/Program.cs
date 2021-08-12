using System;

namespace TestMaximum
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = { 34, 23, 12, 36 };

            // Passing integer input with max number at first place
            GenericMaxLarge<int> genInt = new GenericMaxLarge<int>(array);
            int outputInt = genInt.MaxMethod();


            // Display welcome message
            Console.WriteLine(genInt.welcome());


            // Print output
            Console.WriteLine($"Max value is {outputInt}");
        }
    }
}
