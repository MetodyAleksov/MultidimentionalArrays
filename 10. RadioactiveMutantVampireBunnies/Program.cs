using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = arr[0];
            int m = arr[1];

            char[,] field = new char[arr[0], arr[1]];

            int[] playerPosition = new int[2];

            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (input[col] == 'P')
                    {
                        playerPosition[0] = row;
                        playerPosition[1] = col;
                    }
                    field[row, col] = input[col];
                }
            }

            char[] directions = Console.ReadLine().ToCharArray();

            bool hasWon = false;
            bool isDead = false;

            foreach (char direction in directions)
            {
                if (hasWon == false && isDead == false)
                {
                    int newPlayerRow = playerPosition[0];
                    int newPlayerCol = playerPosition[1];

                    if (direction == 'U')
                    {
                        //row axis
                        newPlayerRow--;
                    }
                    else if (direction == 'D')
                    {
                        //row axis
                        newPlayerRow++;
                    }
                    else if (direction == 'L')
                    {
                        //col axis
                        newPlayerCol--;
                    }
                    else if (direction == 'R')
                    {
                        //col axis
                        newPlayerCol++;
                    }

                    if (!isValidCell(newPlayerRow, newPlayerCol, n, m) && isDead != true)
                    {
                        hasWon = true;

                        field[playerPosition[0], playerPosition[1]] = '.';
                    }
                    else if (field[newPlayerRow, newPlayerCol] == '.')
                    {
                        field[playerPosition[0], playerPosition[1]] = '.';
                        field[newPlayerRow, newPlayerCol] = 'P';

                        playerPosition[0] = newPlayerRow;
                        playerPosition[1] = newPlayerCol;
                    }
                    else if (field[newPlayerRow, newPlayerCol] == 'B')
                    {
                        isDead = true;
                        field[playerPosition[0], playerPosition[1]] = '.';

                        playerPosition[0] = newPlayerRow;
                        playerPosition[1] = newPlayerCol;
                    }
                }

                List<Bunnies> bunniesCoord = GetBunniesCoord(field);

                SpreadBunni(bunniesCoord, field);

                if (field[playerPosition[0], playerPosition[1]] == 'B')
                {
                    isDead = true;
                }

                if (isDead)
                {
                    break;
                }
            }

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write($"{field[row, col]}");
                }
                Console.WriteLine();
            }

            if (hasWon)
            {
                Console.WriteLine($"won: {playerPosition[0]} {playerPosition[1]}");
            }
            else
            {
                Console.WriteLine($"dead: {playerPosition[0]} {playerPosition[1]}");
            }
        }

        //Methods

        private static void SpreadBunni(List<Bunnies> bunniesCoord, char[,] field)
        {
            foreach (Bunnies bunni in bunniesCoord)
            {
                if (isValidCell(bunni.Row - 1, bunni.Col, field.GetLength(0), field.GetLength(1)))
                {
                    field[bunni.Row - 1, bunni.Col] = 'B'; 
                }

                if (isValidCell(bunni.Row + 1, bunni.Col, field.GetLength(0), field.GetLength(1)))
                {
                    field[bunni.Row + 1, bunni.Col] = 'B';
                }

                if (isValidCell(bunni.Row, bunni.Col - 1, field.GetLength(0), field.GetLength(1)))
                {
                    field[bunni.Row, bunni.Col - 1] = 'B';
                }

                if (isValidCell(bunni.Row, bunni.Col + 1, field.GetLength(0), field.GetLength(1)))
                {
                    field[bunni.Row, bunni.Col + 1] = 'B';
                }


            }
        }

        private static List<Bunnies> GetBunniesCoord(char[,] field)
        {
            List<Bunnies> bunniCoord = new List<Bunnies>();

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'B')
                    {
                        Bunnies curr = new Bunnies(row, col);
                        bunniCoord.Add(curr);
                    }
                }
            }

            return bunniCoord;
        }

        private static bool isValidCell(int row, int col, int n, int m)
        {
            return row >= 0 && row < n && col >= 0 && col < m;
        }
    }
    class Bunnies
    {
        public Bunnies(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public int Row { get; set; }
        public int Col { get; set; }
    }

}
