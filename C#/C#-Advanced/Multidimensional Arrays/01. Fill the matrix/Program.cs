using System;

namespace _01.Fill_the_matrix
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            char a = char.Parse(Console.ReadLine());
            int[,] arr = new int[N,N];
            int number = 0;
            if (a=='a')
            {
                for (int col = 0; col < N; col++)
                {
                    for (int row = 0; row < N; row++)
                    {
                        arr[row, col] = ++number;
                    }
                }
            }
            if (a == 'b')
            {
                for (int col = 0; col < N; col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < N; row++)
                        {
                            arr[row, col] = ++number;
                        }
                    }
                    else
                    {
                        for (int row = N-1; row >=0; row--)
                        {
                            arr[row, col] = ++number;
                        }
                    }
    
                }
            }
            if (a=='c')
            {
                number++;
                arr[N - 1, 0] = 1;
                int startDiagonal = 2;
                int startRow = N - 1;                
                for (int i = 0; i < N-1; i++)
                {
                    int diagonal = startDiagonal;
                    startRow--;
                    int col = 0;
                    int row = startRow;
                    while (diagonal>0)
                    {                        
                        number++;
                        arr[row, col] = number;
                        diagonal--;
                        row++;
                        col++;
                    }
                    startDiagonal++;
                }
                number =N * N;
                arr[0, N - 1] = number;
                startDiagonal = 2;
                startRow = 0;
                for (int i = 0; i < N-2; i++)
                {
                    int diagonal = startDiagonal;
                    startRow++;
                    int col = N-1;
                    int row = startRow;
                    while (diagonal > 0)
                    {
                        number--;
                        arr[row, col] = number;
                        diagonal--;
                        row--;
                        col--;
                    }
                    startDiagonal++;
                }
            }
            if (a == 'd')
            {
                int mark = N;
                for (int i = 0; i < N; i++)
                {
                    arr[i, 0] = i + 1;
                }
                number = N;
                int col = 0;
                int row = N-1;
                int stop = N - 1;
                while (true)
                {
                    int counter = 0;                  
                    while (counter<stop)
                    {
                        counter++;
                        number++;
                        col++;
                        arr[row, col] = number;
                    }
                    if (number==N*N)
                    {
                        break;
                    }
                    counter = 0;
                    while(counter<stop)
                    {
                        counter++;
                        row--;
                        number++;
                        arr[row, col] = number;
                    }
                    if (number == N * N)
                    {
                        break;
                    }
                    stop--;
                    counter = 0;
                    while (counter < stop)
                    {
                        counter++;
                        number++;
                        col--;
                        arr[row, col] = number;
                    }
                    if (number == N * N)
                    {
                        break;
                    }
                    counter = 0;
                    while (counter < stop)
                    {
                        counter++;
                        row++;
                        number++;
                        arr[row, col] = number;
                    }
                    if (number == N * N)
                    {
                        break;
                    }
                    stop--;
                }
            }
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (col==N-1)
                    {
                        Console.Write("{0}", arr[row, col]);
                    }
                    else
                    {
                        Console.Write("{0} ", arr[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
