using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first array separated by emptyspace:");
            string[] arrInString;
            int[] arr = null;
            while (true)
            {
                try
                {
                    arrInString = Console.ReadLine().Split(' ');
                    arr = Array.ConvertAll(arrInString, int.Parse);
                    break;
                }
                catch (FormatException fmEx)
                {
                    Console.Error.WriteLine(fmEx.Message + " \nEnter a valid integer.");
                }
                catch (OverflowException oflEx)
                {
                    Console.Error.WriteLine(oflEx.Message + $" \nEnter a valid integer between {int.MinValue} and {int.MaxValue}.");
                }
            }          
            Console.WriteLine("Enter the second array separated by emptyspace:");

            string[] arr2InString;
            int[] arr2 = null;
            while (true)
            {
                try
                {
                    arr2InString = Console.ReadLine().Split(' ');
                    arr2 = Array.ConvertAll(arr2InString, int.Parse);
                    break;
                }
                catch (FormatException fmEx)
                {
                    Console.Error.WriteLine(fmEx.Message + " \nEnter a valid integer.");
                }
                catch (OverflowException oflEx)
                {
                    Console.Error.WriteLine(oflEx.Message + $" \nEnter a valid integer between {int.MinValue} and {int.MaxValue}.");
                }
            }
            int[] sortedArr = new int[arr.Length + arr2.Length];
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
