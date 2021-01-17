using System;
using System.Linq;

namespace _02._2x2SuqtaesinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int equalMatrixes = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {

                }
            }
        }
    }
}
