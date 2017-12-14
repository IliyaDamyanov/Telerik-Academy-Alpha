using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 5 };
            int[] arr2 = new int[] { 2, 3, 8 };
            long[] sortedArr = new long[arr.Length + arr2.Length];
            int arr_i = 0;
            int arr2_i = 0;
            int sArr_i = 0;
            while (arr_i < arr.Length && arr2_i < arr2.Length)
            {
                if (arr[arr_i] <= arr2[arr2_i])
                {
                    sortedArr[sArr_i] = arr[arr_i];
                    sArr_i++;
                    arr_i++;
                }
                else
                {
                    sortedArr[sArr_i] = arr2[arr2_i];
                    sArr_i++;
                    arr2_i++;
                }
            }
            if (arr_i == arr.Length && arr2_i != arr2.Length)
            {
                while (arr2_i < arr2.Length)
                {
                    sortedArr[sArr_i] = arr2[arr2_i];
                    sArr_i++;
                    arr2_i++;
                }
            }
            else if (arr2_i == arr2.Length && arr_i != arr.Length)
            {
                while (arr_i < arr.Length)
                {
                    sortedArr[sArr_i] = arr[arr_i];
                    sArr_i++;
                    arr_i++;
                }
            }
            for (int i = 0; i < sortedArr.Length; i++)
            {
                Console.WriteLine(sortedArr[i]);
            }
        }
    }
}
