using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            FillWardrobe(wardrobe, lines);
            string[] clothesToFind = Console.ReadLine().Split(); //Blue Dress

            string color = clothesToFind[0];
            string cloth = clothesToFind[1];

            PrintWardrobe(wardrobe, color, cloth);

        }

        private static void PrintWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, string color, string cloth)
        {
            foreach(var colorKey in wardrobe)
            {
                Console.WriteLine($"{colorKey.Key} clothes:");
                foreach(var clothing in colorKey.Value)
                {
                    if (color == colorKey.Key && cloth == clothing.Key)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} ");
                    }
                }
            }
        }

        private static Dictionary<string, Dictionary<string, int>> FillWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, int lines)
        {
            for(int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string currColor = input[0]; //Blue
                string[] clothes = input[1].Split(','); // dress, jeans, hat
                if (!wardrobe.ContainsKey(currColor))
                {
                    wardrobe.Add(currColor, new Dictionary<string, int>());
                }
                foreach(var cloth in clothes)
                {
                    if (!wardrobe[currColor].ContainsKey(cloth))
                    {
                        wardrobe[currColor].Add(cloth, 0);
                    }
                    wardrobe[currColor][cloth]++;
                }

            }
            return wardrobe;
        }
    }
}
