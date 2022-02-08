using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.Remove(list[i]);
                    i--;
                }
            }
            list.Reverse();
            foreach (int number in list)
            {
                Console.Write($"{number} ");
            }
            for (int i = list.Count; i >= 0; i--)
            {
                Console.Write($"{list[i]} ");
            }
        }
    }
}