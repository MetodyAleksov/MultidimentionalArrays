using System;
using System.Linq;

namespace _05.SquarewithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = arr1[0];
            int colls = arr1[1];

            int[,] matrix = new int[rows, colls];

            for (int i = 0; i < rows; i++)
            {
                int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int row = 0; row < colls; row++)
                {
                    matrix[i, row] = arr[row];
                }
            }

            int maxSum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < colls - 1; col++)
                {
                    int suqareSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (suqareSum > maxSum)
                    {
                        maxSum = suqareSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }

            for (int row = maxSumRow; row < maxSumRow + 2; row++)
            {
                for (int col = maxSumCol; col < maxSumCol + 2; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}

