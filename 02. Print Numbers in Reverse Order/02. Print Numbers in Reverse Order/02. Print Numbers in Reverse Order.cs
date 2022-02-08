using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read n numbers and print them in reverse order.  

            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            for(int i = 0; i <n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[numbers.Length - 1 - i] + " ");
            }
        }

    }
}
