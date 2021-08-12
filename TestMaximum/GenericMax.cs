using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    // Generic class
    public class GenericMax<T> where T : IComparable
    {
        // Instance variables
        public T first, second, third;

        // Constructor
        public GenericMax(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        // Generic method to find maximum value
        public static T MaxValue(T first, T second, T third) 
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

        // Generic method to call maximum method
        public T MaxMethod()
        {
            T max = GenericMax<T>.MaxValue(this.first, this.second, this.third);
            return max;
        }
    }
}
