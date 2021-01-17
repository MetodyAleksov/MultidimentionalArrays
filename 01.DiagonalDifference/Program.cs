using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int rows = 0; rows < n; rows++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = arr[cols];
                }
            }

            int primarySum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primarySum += matrix[i, i];
            }

            int secondarySum = 0;
            int row = 0;
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                secondarySum += matrix[row, i];
                row++;
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}
