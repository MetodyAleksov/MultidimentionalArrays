using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            matrix = MatrixInput(n);

            string[] arr = Console.ReadLine().Split();

            while (arr[0] != "END")
            {
                int row = int.Parse(arr[1]);
                int col = int.Parse(arr[2]);

                if (row >= 0 && col >= 0 && row < n && col < n)
                {
                    if (arr[0] == "Add")
                    {
                        matrix[int.Parse(arr[1]), int.Parse(arr[2])] += int.Parse(arr[3]);
                    }
                    else if (arr[0] == "Subtract")
                    {
                        matrix[int.Parse(arr[1]), int.Parse(arr[2])] -= int.Parse(arr[3]);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                arr = Console.ReadLine().Split();
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
        static int[,]MatrixInput(int n)
        {
            int[,] matrix = new int[n, n];

            for (int rows = 0; rows < n; rows++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = arr[cols];
                }
            }

            return matrix;
        }
    }
}
