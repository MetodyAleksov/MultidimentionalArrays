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


        }
    }
}
