using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    public class CheckMaximumInt
    {
        // Method to find the maximum of 3 numbers
        public static int MaxIntNumber(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }

            throw new Exception("All three values are same");
        }

        // Method to display welcome message
        public static string welcome()
        {
            return "Welcome to Test Maximum of 3 Variables Program\n";
        }
    }
}