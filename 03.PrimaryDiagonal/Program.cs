using System;
using System.Linq;

namespace _03.PrimaryDiagonal
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

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i]; 
            }

            Console.WriteLine(sum);
        }
    }
}
