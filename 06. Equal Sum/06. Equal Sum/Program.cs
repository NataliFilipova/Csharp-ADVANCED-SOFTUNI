using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                for(int sumLeft = i; sumLeft > 0; i--)
                {
                    int nextElementPosition = sumLeft - 1;
                    if(sumLeft > 0)
                    {
                        leftSum += numbers[nextElementPosition];
                    }
                }

                for(int j = i; j < numbers.Length)
                {
                    int nextElementPosition = sumLeft - 1;
                    if (sumLeft > 0)
                    {
                        leftSum += numbers[nextElementPosition];
                    }
                }
            }
        }
    }
}
