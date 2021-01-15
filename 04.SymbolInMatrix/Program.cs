using System;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string input1 = Console.ReadLine();

            bool isFound = false;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == input1[0])
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }

            if (isFound == false)
            {
                Console.WriteLine($"{input1} does not occur in the matrix ");
            }
        }
    }
}
