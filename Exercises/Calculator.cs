using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Calculator
    {
        public static int? Max (List<int> numbers)
        {
            if (numbers?.Any() != true)
            {
                return default;
            }

            var max = numbers[0];

            foreach (var number in numbers.Skip(1))
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }

        public static float? Average(List<int> numbers)
        {
            if(numbers?.Any() != true)
            {
                return default;
            }

            var total = numbers[0];

            foreach (var number in numbers.Skip(1))
            {
                total += number;
            }

            return (float)total / numbers.Count;
        }

        public static int? Min(List<int> numbers)
        {
            if (numbers?.Any() != true)
            {
                return default;
            }

            var min = numbers[0];

            foreach (var number in numbers.Skip(1))
            {
                if (number < min)
                {
                    min = number;
                }
            }

            return min;
        }
    }
}
