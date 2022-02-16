using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Warm_Winter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> scarf = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            List<int> sets = new List<int>();

            while (scarf.Count > 0 && hats.Count > 0)
            {
                if(hats.Peek() == scarf.Peek())
                {
                    scarf.Dequeue();
                    hats.Push(hats.Pop() + 1);
                }
                else if(hats.Peek() < scarf.Peek())
                {
                    hats.Pop();
                }
                else if(hats.Peek() > scarf.Peek())
                {
                    int set = hats.Pop() + scarf.Dequeue();
                    sets.Add(set);

                }
            }

            int x = sets.OrderByDescending(x => x).FirstOrDefault();
            Console.WriteLine($"The most expensive set is: {x}");
            Console.WriteLine($"{string.Join(" ", sets)}");
        }
    }
}
