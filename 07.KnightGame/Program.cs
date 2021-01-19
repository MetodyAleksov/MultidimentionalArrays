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

            List<Knight> knights = new List<Knight>();

            for (int row = 0; row < n; row++)
            {
                char[] arr = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    if (arr[col] == 'K')
                    {
                        knights.Add(new Knight(row, col));
                    }
                    matrix[row, col] = arr[col];
                }
            }

            int removedKnights = 0;

            foreach (Knight knight in knights)
            {
                //row axis positive
                if (isValid(knight.Row + 2, knight.Col - 1, n))
                {
                    if (matrix[knight.Row + 2, knight.Col - 1] == 'K')
                    {
                        removedKnights++;
                        matrix[knight.Row + 2, knight.Col - 1] = 'O';
                    }
                }
                if (isValid(knight.Row + 2, knight.Col + 1, n))
                {
                    if (matrix[knight.Row + 2, knight.Col + 1] == 'K')
                    {
                        removedKnights++;
                        matrix[knight.Row + 2, knight.Col + 1] = 'O';
                    }
                }
                //row axis negative
                if (isValid(knight.Row - 2, knight.Col + 1, n))
                {
                    if (matrix[knight.Row - 2, knight.Col + 1] == 'K')
                    {
                        removedKnights++;
                        matrix[knight.Row - 2, knight.Col + 1] = 'O';
                    }
                }
                if (isValid(knight.Row - 2, knight.Col - 1, n))
                {
                    if (matrix[knight.Row - 2, knight.Col - 1] == 'K')
                    {
                        removedKnights++;
                        matrix[knight.Row - 2, knight.Col - 1] = 'O';
                    }
                }
                //col axies positive
                if (isValid(knight.Row + 1, knight.Col + 2, n))
                {
                    if (matrix[knight.Row + 1, knight.Col + 2] == 'K')
                    {
                        removedKnights++;
                        matrix[knight.Row + 1, knight.Col + 2] = 'O';
                    }
                }
                if (isValid(knight.Row - 1, knight.Col + 2, n))
                {
                    if (matrix[knight.Row - 1, knight.Col + 2] == 'K')
                    {
                        removedKnights++;
                        matrix[knight.Row - 1, knight.Col - 1] = 'O';
                    }
                }
                //col axis negative
            }
        }

        private static bool isValid(int row, int col, int n)
        {
            return row >= 0 && row < n && col >= 0 && col < n;
        }
    }
    class Knight
    {
        public Knight(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public int Row { get; set; }
        public int Col { get; set; }
    }
}
