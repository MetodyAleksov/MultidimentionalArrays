using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] arr = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int removedKnights = 0;

            while(true)
            {
                int maxAttackedKnights = 0;
                int knightRow = 0;
                int knightCol = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char symbow = matrix[row, col];

                        if (symbow != 'K')
                        {
                            continue;
                        }

                        int count = GetCountofAttackedKnights(matrix, row, col);

                        if (count > maxAttackedKnights)
                        {
                            maxAttackedKnights = count;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }

                if (maxAttackedKnights == 0)
                {
                    break;
                }

                matrix[knightRow, knightCol] = '0';
                removedKnights++;
            }

            Console.WriteLine(removedKnights);
        }

        private static int GetCountofAttackedKnights(char[,] matrix, int row, int col)
        {
            int numOfAttackedKnights = 0;

            if (isValid(row + 2, col - 1, matrix.GetLength(0)))
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    numOfAttackedKnights++;
                }
            }
            if (isValid(row + 2, col + 1, matrix.GetLength(0)))
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    numOfAttackedKnights++;
                }
            }
            if (isValid(row - 2, col - 1, matrix.GetLength(0)))
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    numOfAttackedKnights++;
                }
            }
            if (isValid(row - 2, col + 1, matrix.GetLength(0)))
            {
                if (matrix[row - 2, col + 1] == 'K')
                {
                    numOfAttackedKnights++;
                }
            }
            if (isValid(row + 1, col + 2, matrix.GetLength(0)))
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    numOfAttackedKnights++;
                }
            }
            if (isValid(row + 1, col - 2, matrix.GetLength(0)))
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    numOfAttackedKnights++;
                }
            }
            return numOfAttackedKnights;
        }

        private static bool isValid(int row, int col, int n)
        {
            return row >= 0 && row < n && col >= 0 && col < n;
        }
    }
}
