using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp26
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = arr[0];
            int S = arr[1];
            int X = arr[2];

            int[] inputElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            for(int i = 0; i < N; i++)
            {
               
                stack.Push(inputElements[i]);
            }

            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }

            int minElement = int.MaxValue;

            if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
            
        }
    }
}

