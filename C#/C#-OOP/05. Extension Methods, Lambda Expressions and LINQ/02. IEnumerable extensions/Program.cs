using System.Collections.Generic;

namespace _02.IEnumerable_extensions
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> list)
        {
            dynamic sum = default(T);
            foreach (T item in list)
            {
                sum += item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> list)
        {
            dynamic product = default(T);
            foreach (T item in list)
            {
                product *= item;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> list)
        {
            int i = 0;
            dynamic min = default(T);
            foreach (T item in list)
            {
                i++;
                if (i == 1)
                {
                    min = item;
                }
                else if (min < item)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> list)
        {
            int i = 0;
            dynamic max = default(T);
            foreach (T item in list)
            {
                i++;
                if (i == 1)
                {
                    max = item;
                }
                else if (max > item)
                {
                    max = item;
                }
            }
            return max;
        }

        public static T Avarage<T>(this IEnumerable<T> list)
        {
            dynamic avarage = default(T);
            int i = 0;
            dynamic sum = 0;
            foreach (T item in list)
            {
                sum += item;
                i++;
            }
            avarage = sum / i;
            return avarage;
        }
    }
}
