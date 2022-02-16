using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._The_Fight_for_Gondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());

            Queue<int> plates = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            
            for(int i = 1; i <= numberOfWaves; i++)
            {
                Stack<int> waves = new Stack<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

                if(i%3== 0)
                {
                    int n = int.Parse(Console.ReadLine());
                    plates.Enqueue(n);
                }

                while(!(waves.Count == 0))
                {
                    if(waves.Peek() > plates.Peek())
                    {
                        waves.Push(waves.Pop() - plates.Dequeue());

                    }
                    else if(waves.Peek() < plates.Peek())
                    {
                        Queue<int> newUpdatedPlates = new Queue<int>();
                        newUpdatedPlates.Enqueue(plates.Dequeue() - waves.Pop());

                        for(int j = 0; j < plates.Count; j++)
                        {
                            newUpdatedPlates.Enqueue(plates.ElementAt(j));
                        }
                        plates = newUpdatedPlates;
                    }
                    else if(waves.Peek() == plates.Peek())
                    {
                        plates.Dequeue();
                        waves.Pop();
                    }

                    if(plates.Count == 0)
                    {
                        Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.");
                        Console.WriteLine($"Orcs left: {string.Join(", ", waves)}");
                        return;
                    }


                }

            }
            Console.WriteLine("The people successfully repulsed the orc's attack.");
            Console.WriteLine($"Plates left: {string.Join(", ", plates)}");

        }
    }
}
