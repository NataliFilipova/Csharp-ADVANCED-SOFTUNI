using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int initialBitcoins = 0;

            string[] rooms = Console.ReadLine().Split("|");

            for(int i = 0; i < rooms.Length; i++)
            {
                string[] splitted = rooms[i].Split(" ");
                string command = splitted[0];
                int amount = int.Parse(splitted[1]);

                if(command == "potion")
                {
                    initialHealth += amount;
                    if(initialHealth > 100)
                    {
                        amount -= initialHealth - 100;
                        initialHealth = 100;
                    }
                    Console.WriteLine($"You healed for {amount} hp.");
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
                else if(command == "chest")
                {
                    Console.WriteLine($"You found {amount} bitcoins");
                    initialBitcoins += amount;
                }
                else
                {
                    //here amount = monster health
                    if(initialHealth > amount)
                    {
                        Console.WriteLine($"You slayed {command}.");
                        initialHealth -= amount;
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {initialBitcoins}");
            Console.WriteLine($"Health: {initialHealth}");

        }
    }
}
