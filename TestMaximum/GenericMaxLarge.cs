using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    // Generic class
    public class GenericMaxLarge<T> where T : IComparable
    {
        // Instance variables
        public T[] value;

        // Constructor
        public GenericMaxLarge(T[] value)
        {
            this.value = value;
        }

        // Generic method to sort the array
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        // Generic method to get max value
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }

        // Generic method to call MaxValue method
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        public string welcome()
        {
            return "Welcome to Test Maximum Program";
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine($"Max value is {max}");
        }
    }
}
