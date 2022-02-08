using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"([=\/])([A-Z][A-Za-z]{2,})\1");
            string input = Console.ReadLine();
            var matches = regex.Matches(input);
            int index = 0;
            int matchesLength = 0;
            Console.WriteLine($"Destinations: ");
            foreach (Match match in matches)
            {
                index++;
                Console.Write($"{match.Groups[2].Value}");
                matchesLength += match.Groups[2].Value.Length;
                if(index < matches.Count)
                {
                    Console.Write(", ");
                }
                
               
            }
            Console.WriteLine();
            Console.WriteLine($"Travel points: {matchesLength}");
        }
    }
}
