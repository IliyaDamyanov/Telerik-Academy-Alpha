using System;

namespace _08.Number_as_array
{
    class Program
    {
        static int[] NumberAsArrSum(int[] firstArr, int[] secondArr)
        {
            int biggerSize = Math.Max(firstArr.Length, secondArr.Length);
            int smallerSize = Math.Min(firstArr.Length, secondArr.Length);
            int[] finalArr = new int[biggerSize+1];
            int tens = 0;
            for (int i = 0; i < smallerSize; i++)
            {
                    finalArr[i] = (tens + firstArr[i] + secondArr[i]) % 10;
                    tens = (tens + firstArr[i] + secondArr[i]) / 10;
            }
            if (firstArr.Length>secondArr.Length)
            {
                for (int i = smallerSize; i < biggerSize; i++)
                {
                    finalArr[i] = (tens + firstArr[i]) % 10;
                    tens = (tens + firstArr[i]) / 10;
                }
            }
            if (firstArr.Length < secondArr.Length)
            {
                for (int i = smallerSize; i < biggerSize; i++)
                {
                    finalArr[i] = (tens + secondArr[i]) % 10;
                    tens = (tens + secondArr[i]) / 10;
                }
            }
            finalArr[finalArr.Length - 1] = tens;
            return finalArr;
        }
        static void Print(int[] finalArr)
        {
            if (finalArr[finalArr.Length-1]==0)
            {
                for (int i = 0; i < finalArr.Length-1; i++)
                {
                    Console.Write(finalArr[i]);
                    if (i < finalArr.Length - 2)
                    {
                        Console.Write(" ");
                    }
                }
            }
            else
            {
                for (int i = 0; i < finalArr.Length; i++)
                {
                    Console.Write(finalArr[i]);
                    if (i < finalArr.Length - 1)
                    {
                        Console.Write(" ");
                    }
                }
            }
            
        }
        
        static void Main()
        {
            string[] sizes = Console.ReadLine().Split(' ');
            string[] firstArrInString = Console.ReadLine().Split(' ');
            int[] firstArr = new int[int.Parse(sizes[0])];
            for (int i = 0; i < firstArrInString.Length; i++)
            {
                firstArr[i] = int.Parse(firstArrInString[i]);
            }
            string[] secondArrInString = Console.ReadLine().Split(' ');
            int[] secondArr = new int[int.Parse(sizes[1])];
            for (int i = 0; i < secondArrInString.Length; i++)
            {
                secondArr[i] = int.Parse(secondArrInString[i]);
            }
            Print(NumberAsArrSum(firstArr, secondArr));
        }
    }
}
