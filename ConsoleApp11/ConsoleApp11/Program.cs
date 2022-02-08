using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> list2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> mergedlist = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int biggerListCount = list1.Count;
            if(biggerListCount < list2.Count)
            {
                biggerListCount = list2.Count;
            }
            for(int i = 0;  i<biggerListCount; i++)
            {
                if(list1.Count > i)
                {
                    mergedlist.Add(list1[i]);
                }
                if(list2.Count > i)
                {
                    mergedlist.Add(list2[i]);
                }
                
            }
            Console.WriteLine(string.Join(" ", mergedlist));
        }

    }
}
