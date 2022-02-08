using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            FillSet(firstSet, lengths[0]);
            FillSet(secondSet, lengths[1]);
            CheckSets(firstSet, secondSet); 

        }

        private static void CheckSets(HashSet<int> firstSet, HashSet<int> secondSet)
        {
            List<int> nums = new List<int>();
            foreach(int currNum  in firstSet)
            {
                if (secondSet.Contains(currNum))
                {
                    nums.Add(currNum);
                }
            }
            Console.WriteLine(string.Join(' ', nums));
        }

        private static HashSet<int> FillSet(HashSet<int> set, int length)
        {
            for(int i = 0; i < length; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }
            return set;
        }
    }
}
