using System;
using System.Linq;

namespace _02.MatrixCollSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = arr[0];
            int cols = arr[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = arr1[col];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                int sum = 0;
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col]; 
                }
                Console.WriteLine(sum);
            }
        }
    }
}
