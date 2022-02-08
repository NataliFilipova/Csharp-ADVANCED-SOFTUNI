using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SetsAndDictionariesAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> numberOccurrences = new Dictionary<double, int>();

            foreach(var number in numbers)
            {
                if (!numberOccurrences.ContainsKey(number))
                {
                    numberOccurrences.Add(number, 0);

                }
                numberOccurrences[number]++;
            }

            foreach(var occurence in numberOccurrences)
            {
                Console.WriteLine($"{occurence.Key} - {occurence.Value} times");
            }
            

            
        }
    }
    
}
