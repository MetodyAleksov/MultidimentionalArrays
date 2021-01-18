using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[parameters[0], parameters[1]];

            for (int i = 0; i < parameters[0]; i++)
            {
                string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < parameters[1]; col++)
                {
                    matrix[i, col] = arr[col];
                }
            }

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0] != "END")
            {
                if (input[0] == "swap")
                {
                    if (input.Length == 5)
                    {
                        int row1 = int.Parse(input[1]);
                        int col1 = int.Parse(input[2]);
                        int row2 = int.Parse(input[3]);
                        int col2 = int.Parse(input[4]);

                        if ((row1 >= 0 && row1 < parameters[0]) && (col1 >= 0 && col1 < parameters[1]) && (row2 >= 0 && row2 < parameters[0]) && (col2 >= 0 && col2 < parameters[1]))
                        {
                            string firstValue = matrix[row1, col1];
                            string secondValue = matrix[row2, col2];

                            matrix[row1, col1] = secondValue;
                            matrix[row2, col2] = firstValue;

                            for (int row = 0; row < parameters[0]; row++)
                            {
                                for (int col = 0; col < parameters[1]; col++)
                                {
                                    Console.Write($"{matrix[row, col]} ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
        }
    }
}
