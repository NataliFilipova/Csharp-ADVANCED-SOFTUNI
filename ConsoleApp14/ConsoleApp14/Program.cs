using System;
using System.Linq;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[] cmd = Console.ReadLine().Split(" ");

            while (cmd[0] != "end")
            {
                if (cmd[0] == "swap")
                {
                    // Console.WriteLine($"Before swap: 1: { arr[(int.Parse(cmd[1]))]} and 2: {arr[(int.Parse(cmd[2]))]} ");
                    int tmp = arr[(int.Parse(cmd[1]))];
                    arr[(int.Parse(cmd[1]))] = arr[(int.Parse(cmd[2]))];
                    arr[(int.Parse(cmd[2]))] = tmp;

                    //Console.WriteLine($"After swap: 1: { arr[(int.Parse(cmd[1]))]} and 2: {arr[(int.Parse(cmd[2]))]} ");
                }
                else if (cmd[0] == "multiply")
                {
                    arr[(int.Parse(cmd[1]))] = arr[(int.Parse(cmd[1]))] * arr[(int.Parse(cmd[2]))];

                    // Console.WriteLine(arr[(int.Parse(cmd[1]))]);
                }
                else if (cmd[0] == "decrease")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] -= 1;
                    }
                }

                cmd = Console.ReadLine().Split(" ");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (!(i == (arr.Length - 1)))
                {
                    Console.Write($"{arr[i]}, ");
                }
                else
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }
       
    }
}
