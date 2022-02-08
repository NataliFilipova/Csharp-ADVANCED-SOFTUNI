using System;
using System.Collections.Generic;
using System.Linq;

namespace Phone_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            string[] inpute = Console.ReadLine().Split(" - ");
            while (inpute[0] != "End")
            {
                if (inpute[0] == "Add")
                {
                    if (list.Contains(inpute[1]))
                    {
                        continue;
                    }
                    else
                    {
                        list.Add(inpute[1]);
                    }
                }
                else if (inpute[0] == "Remove")
                {
                    if (list.Contains(inpute[1]))
                    {
                        list.Remove(inpute[1]);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (inpute[0] == "Bonus phone")
                {
                    string[] arr2 = inpute[1].Split(":");
                    if (list.Contains(arr2[0]))
                    {
                        int k = list.IndexOf(arr2[0]) + 1;
                        list.Insert(k, arr2[1]);

                    }

                }
                else if (inpute[0] == "Last")
                {
                    if (list.Contains(inpute[1]))
                    {
                        list.Remove(inpute[1]);
                        list.Add(inpute[1]);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
