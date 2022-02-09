﻿using System;
using System.Linq;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] rowValues = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;


            for (int row = 0; row < n; row++)
            {
                primaryDiagonal += matrix[row, row];
                secondaryDiagonal += matrix[row, n - row - 1];
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}