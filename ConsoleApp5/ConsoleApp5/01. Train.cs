using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] train = new int[wagons];
            int sum = 0;

            for(int i = 0; i < wagons; i++) 
            { 

                int people = int.Parse(Console.ReadLine());
                train[i] = people;

            }

            for (int i = 0; i < train.Length; i++)
            {
                Console.Write(train[i] + " ");
                sum += train[i];
            }
            Console.WriteLine("");
            Console.WriteLine(sum);
        }
    }
}
