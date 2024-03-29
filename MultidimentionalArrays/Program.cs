﻿using System;
using System.Linq;

namespace MultidimentionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = arr1[0];
            int colls = arr1[1];

            int[,] matrix = new int[rows, colls];

            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int row = 0; row < colls; row++)
                {
                    matrix[i, row] = arr[row];
                    sum += matrix[i, row];
                } 
            }

            Console.WriteLine(rows);
            Console.WriteLine(colls);
            Console.WriteLine(sum);
            
        }
    }
}
