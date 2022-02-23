using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Armory
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];

            int officerRow = 0;
            int officerCol = 0;

            List<int> mirror = new List<int>(); //filling it with indexes of the mirrors
            bool areThereMirrors = false;

            int sumOfGoldCoins = 0;
            
            for (int i = 0; i < n; i++)
            {
                var currentRow = Console.ReadLine().ToCharArray();
                matrix[i] = currentRow;

                if (currentRow.Contains('A'))
                {
                    officerRow = i;
                    officerCol = currentRow.ToList().IndexOf('A');
                }
                if (currentRow.Contains('M'))
                {
                    mirror.Add(i);            
                    mirror.Add(currentRow.ToList().IndexOf('M'));
                    areThereMirrors = true;
                }
            }
            

           
            while (true)
            {
                string command = Console.ReadLine().ToLower();

                matrix[officerRow][officerCol] = '-';
                if (command == "up" ) 
                {
                    officerRow--;
                }
                else if (command == "down" )
                {
                    officerRow++;
                }
                else if (command == "left" ) 
                {
                    officerCol--;
                }
                else if (command == "right" ) 
                {
                    officerCol++;
                }

                if (officerRow < 0 || officerRow >= n || officerCol < 0 || officerCol >= n)
                {
                    Console.WriteLine($"I do not need more swords!");
                    break;
                }

                bool result = Char.IsDigit(matrix[officerRow][officerCol]);
                if(result == true)
                {
                int num = matrix[officerRow][officerCol] - '0';

                // int num = (int)char.GetNumericValue(matrix[officerRow][officerCol]);

                    sumOfGoldCoins += num;

                    matrix[officerRow][officerCol] = '-';
                    
                }

                if(sumOfGoldCoins >= 65)
                {
                    matrix[officerRow][officerCol] = 'A';
                    Console.WriteLine("Very nice swords, I will come back for more!");
                    break;
                }

                if (areThereMirrors == true)
                {
                    if (matrix[officerRow][officerCol] == 'M')
                    {
                        int[] mirrors = mirror.ToArray();

                        if (mirrors[0] == officerRow && mirror[1] == officerCol)
                        {
                            officerRow = mirrors[2];
                            officerCol = mirrors[3];
                          
                        }
                        else
                        {
                            officerRow = mirrors[0];
                            officerCol = mirrors[1];
                        }
                        matrix[mirrors[0]][mirrors[1]] = '-';
                        matrix[mirrors[2]][mirrors[3]] = '-';
                        areThereMirrors = false;
                        matrix[officerRow][officerCol] = 'A';

                    }
                }
            }
            Console.WriteLine($"The king paid {sumOfGoldCoins} gold coins.");
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(new string(matrix[i]));
            }
        }
    }
}
