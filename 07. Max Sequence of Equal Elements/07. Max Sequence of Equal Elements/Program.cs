using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            int start = 0;
            int max = 0;

            

            for (int i = 0; i <arr.Length; i++)
            {
                if(arr[i] == arr[i + 1])
                {
                    count++;
                    if(count > max)
                    {
                        start = i - count;
                        max = count;
                    }
                  
                }
                else
                {
                    count = 0;
                }

                
            }
            for (int i = start + 1; i <= start + max + 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
