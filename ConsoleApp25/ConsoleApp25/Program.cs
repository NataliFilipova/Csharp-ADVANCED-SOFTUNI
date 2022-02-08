using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _03
{
    public class Animal
    {
        public string animalName;
        public int dailyFoodLimit;
        public string areaLiveIn;
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Animal> dict = new Dictionary<string, Animal>();
            string[] command = Console.ReadLine().Split(": ");

            while(command[0] != "EndDay") {
                string[] token = command[1].Split("=");

                if(command[0] == "Add")
                {
                    if (!dict.ContainsKey(token[0]))
                    {
                        Animal currAnimal = new (token[0]);
                    }
                }

            }
        }
    }
}