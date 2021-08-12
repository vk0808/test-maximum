using System;

namespace TestMaximum
{
    class Program 
    {
        // Generic method with Comparable interface from System
        static T MaxMethod<T>(T first, T second, T third) where T : IComparable
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 ||
                third.CompareTo(first) >= 0 && third.CompareTo(second) > 0 ||
                third.CompareTo(first) > 0 && third.CompareTo(second) >= 0)
            {
                return third;
            }

            throw new Exception("All three values are same");
        }


        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine(CheckMaximumInt.welcome());


            // Passing integer input with max number at first place
            int outputInt1 = MaxMethod<int>(34, 34, 12);
            //int outputInt2 = MaxMethod<int>(34, 12, 34);
            //int outputInt3 = MaxMethod<int>(12, 34, 12);


            // Passing double input with max number at second place
            double outputInt2 = MaxMethod<double>(12.9, 48.9, 1.9);


            // Passing string input with max number at third place
            string outputInt3 = MaxMethod<string>("apple", "peach", "banana");


            // Print output
            Console.WriteLine($"Max of 3 int (34, 23, 12) is {outputInt1}");
            Console.WriteLine($"Max of 3 double (12.9, 48.9, 1.9) is {outputInt2}");
            Console.WriteLine($"Max of 3 string (apple, peach, banana) is {outputInt3}");
        }
    }
}
