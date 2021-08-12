using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    public class CheckMaximumString
    {
        // Method to find the maximum of 3 numbers
        public static string MaxStringNumber(string first, string second, string third)
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
    }
}
