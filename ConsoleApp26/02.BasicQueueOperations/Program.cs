using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
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

           Queue<int> queue = new Queue<int>();

            for (int i = 0; i < N; i++)
            {

                queue.Enqueue(inputElements[i]);
            }

            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }

            int minElement = int.MaxValue;

            if (queue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }

        
         }
    }
}
