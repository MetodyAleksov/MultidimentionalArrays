using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jarr = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jarr[row] = new int[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    jarr[row][col] = input[col];
                }
            }

            for (int row = 1; row < jarr.Length; row++)
            {
                if (jarr[row].Length == jarr[row - 1].Length)
                {
                    for (int col1 = 0; col1 < jarr[row - 1].Length; col1++)
                    {
                        jarr[row - 1][col1] *= 2;
                    }

                    for (int col1 = 0; col1 < jarr[row].Length; col1++)
                    {
                        jarr[row][col1] *= 2;
                    }
                }
                else
                {
                    for (int col1 = 0; col1 < jarr[row - 1].Length; col1++)
                    {
                        jarr[row - 1][col1] /= 2;
                    }

                    for (int col1 = 0; col1 < jarr[row].Length; col1++)
                    {
                        jarr[row][col1] /= 2;
                    }
                }
            }

            string[] input1 = Console.ReadLine().Split();

            while (input1[0] != "End")
            {
                if (input1[0] == "Add")
                {
                    int row = int.Parse(input1[1]);
                    int col = int.Parse(input1[2]);

                    if (row >= 0 && row < jarr.Length)
                    {
                        if (col >= 0 && col < jarr[row].Length)
                        {
                            jarr[row][col] += int.Parse(input1[3]);
                        }
                    }
                }
                else if (input1[0] == "Subtract")
                {
                    int row = int.Parse(input1[1]);
                    int col = int.Parse(input1[2]);

                    if (row >= 0 && row < jarr.Length)
                    {
                        if (col >= 0 && col < jarr[row].Length)
                        {
                            jarr[row][col] -= int.Parse(input1[3]);
                        }
                    }
                }

                input1 = Console.ReadLine().Split();
            }

            for (int row = 0; row < jarr.Length; row++)
            {
                for (int col = 0; col < jarr[row].Length; col++)
                {
                    Console.Write($"{jarr[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
