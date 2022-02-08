using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continentData = new Dictionary<string, Dictionary<string, List<string>>>();


            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var splitted = input.Split(" ");
                var continent = splitted[0];
                var country = splitted[1];
                var town = splitted[2];

                if (!continentData.ContainsKey(continent))
                {
                    continentData[continent] = new Dictionary<string, List<string>>();
                }
                if (!continentData[continent].ContainsKey(country))
                {
                    continentData[continent][country] = new List<string>();
                }
                continentData[continent][country].Add(town);
                
                

               
            }

            foreach(var continentCountries in continentData)
            {
                var continentName = continentCountries.Key;
                Console.WriteLine($"{continentName}: ");
                foreach(var countryCities in continentCountries.Value)
                {
                   
                    
                    Console.WriteLine($"{countryCities.Key} -> {string.Join(", ", countryCities.Value)}");
                    
                }
            }
        }
    }
}
