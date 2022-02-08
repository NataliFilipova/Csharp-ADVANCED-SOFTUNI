using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp33
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var trainers = new List<Trainer>();

            while (true)
            {
                var cmdArgs = Console.ReadLine();
                if(cmdArgs == "Tournament")
                {
                    break;
                }
                var info = cmdArgs.Split();
                if(!trainers.Any(x => x.Name == info[0]))
                {
                    trainers.Add(new Trainer(info[0]));
                }

                var curTrainer = trainers.Find(t => t.Name == info[0]);
                curTrainer.Pokemons.Add(new Pokemon(info[1], info[2], int.Parse(info[3])));
            }

            while (true)
            {
                var elements = Console.ReadLine();
                if(elements == "End")
                {
                    break;
                }
                foreach(Trainer trainer in trainers)
                {
                    if (trainer.Pokemons.Any(pokemon => pokemon.Element == elements))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        for(int i = 0; i< trainer.Pokemons.Count; i++)
                        {
                            trainer.Pokemons[i].Health -= 10; 
                            if(trainer.Pokemons[i].Health <= 0)
                            {
                                trainer.Pokemons.RemoveAt(i);
                                i--;
                            }
                        }
                    }

                    
                }
            }

            foreach(Trainer trainer in trainers.OrderByDescending(trainer => trainer.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
