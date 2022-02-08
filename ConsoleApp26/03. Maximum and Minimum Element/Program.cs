using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for(int i = 0; i < N; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (int.Parse(command[0]) == 1)
                {
                    stack.Push(int.Parse(command[1]));
                }
                else if (int.Parse(command[0]) == 2)
                {
                    stack.Pop();
                }
                else if (int.Parse(command[0]) == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (int.Parse(command[0]) == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

      

            while (stack.Count > 0)
            {
                if (stack.Count == 1)
                {
                    int k = stack.Pop();
                    Console.Write($"{k} ");
                }
                else
                {
                    int k = stack.Pop();
                    Console.Write($"{k}, ");
                }
            }
        }
    }
}
