using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            FillDictionary(numbers, lines);
            PrintResult(numbers);
        }

        private static void PrintResult(Dictionary<int, int> numbers)
        {
            int num = 0;
            foreach(KeyValuePair<int, int> kvp in numbers)
            {
                if(kvp.Value % 2 == 0)
                {
                    num = kvp.Key;
                }
            }
            Console.WriteLine(num);

        }

        private static Dictionary<int,int> FillDictionary(Dictionary<int, int> numbers, int lines)
        {
            for(int i = 0; i<lines;i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(currNum))
                {
                    numbers.Add(currNum, 0);
                }
                numbers[currNum]++;
            }
            return numbers;
        }
    }
}
