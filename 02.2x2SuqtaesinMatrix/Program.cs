using System;
using System.Collections;
using System.Linq;

namespace _02._2x2SuqtaesinMatrix
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] arr = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int equalMatrixes = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    string[,] currMatrix = new string[2, 2];
                    currMatrix[0, 0] = matrix[row, col];
                    currMatrix[0, 1] = matrix[row, col + 1];
                    currMatrix[1, 0] = matrix[row + 1, col];
                    currMatrix[1, 1] = matrix[row + 1, col + 1];

                    for (int row1 = 0; row1 < rows - 1; row1++)
                    {
                        for (int col1 = 0; col1 < cols - 1; col1++)
                        {
                            string[,] currMatrix1 = new string[2, 2];
                            currMatrix1[0, 0] = matrix[row1, col1];
                            currMatrix1[0, 1] = matrix[row1, col1 + 1];
                            currMatrix1[1, 0] = matrix[row1 + 1, col1];
                            currMatrix1[1, 1] = matrix[row1 + 1, col1 + 1];

                            if (currMatrix[0, 0] == currMatrix1[0, 0] && currMatrix[1, 0] == currMatrix1[1, 0] && currMatrix[0, 1] == currMatrix1[0, 1] && currMatrix[1, 1] == currMatrix1[1, 1])
                            {
                                equalMatrixes++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(equalMatrixes);
        }
    }
}
