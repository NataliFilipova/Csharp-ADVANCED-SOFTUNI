using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> songsQueue = new Queue<string>(songs);


            string[] command = Console.ReadLine().Split(' ');
            while(songsQueue.Count > 0)
            {
               

                if (command[0] == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    StringBuilder nameSong = new StringBuilder();

                    for (int i = 1; i < command.Length; i++)
                    {
                        nameSong.Append($"{command[i]}");
                        if (!i.Equals(command.Length - 1))
                        {
                            nameSong.Append(" ");
                        }
                    }
                    if (!songs.Contains(nameSong.ToString()))
                    {
                        songsQueue.Enqueue(nameSong.ToString());
                    }

                    else
                    {
                        Console.WriteLine($"{nameSong.ToString()} is already contained!");
                    }
                }



                else if (command[0] == "Show")
                {
                    Console.WriteLine("{0}", string.Join(", ", songsQueue));

                }
                command = Console.ReadLine().Split().ToArray();
            }
            
            Console.WriteLine("No more songs!");

        }
    }
}


//A song cannot be added if it is currently in the queue.

