using System;
using System.Linq;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];

            for (int row = 0; row < n; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();


            }
            int removedKnigts = 0;
            while (true)
            {
                int knightRow = -1;
                int knightCol = -1;
                int maxAttacked = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row][col] == 'K')
                        {
                            int temAttack = CountAttacks(matrix, row, col);
                            if (temAttack > maxAttacked)
                            {
                                maxAttacked = temAttack;
                                knightRow = row;
                                knightCol = col;
                            }
                        }
                    }
                }
                if (maxAttacked > 0)
                {
                    matrix[knightRow][knightCol] = '0';
                    removedKnigts++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(removedKnigts);


        }

        static int CountAttacks(char[][] matrix, int row, int col)
        {
            int attacks = 0;

            if (IsInMatrix(row + 1, col - 2, matrix.Length) && matrix[row + 1][col - 2] == 'K')
            {
                attacks++;
            }

            if (IsInMatrix(row - 1, col - 2, matrix.Length) && matrix[row - 1][col - 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row - 1, col + 2, matrix.Length) && matrix[row - 1][col + 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row + 1, col + 2, matrix.Length) && matrix[row + 1][col + 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row - 2, col - 1, matrix.Length) && matrix[row - 2][col - 1] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row - 2, col + 1, matrix.Length) && matrix[row - 2][col + 1] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row + 2, col - 1, matrix.Length) && matrix[row + 2][col - 1] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row + 2, col + 1, matrix.Length) && matrix[row + 2][col + 1] == 'K')
            {
                attacks++;
            }


            return attacks;
        }

        private static bool IsInMatrix(int row, int col, int length)
        {
            return row >= 0 && row < length && col >= 0 && col < length;
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] rowValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            return matrix;
        }

    }
}
