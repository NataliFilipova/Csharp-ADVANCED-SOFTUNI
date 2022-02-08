using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Factorial(num1, num2);
        }
       private static void Factorial(int num1, int num2 )
        {
            int factorialOfNum1 = 1;
            int factorialOfNum2 = 1;

            for(int i = num1; i > 0; i--)
            {
                factorialOfNum1 *= i;
            }
            for (int i = num2; i > 0; i--)
            {
                factorialOfNum2 *= i;
            }

            double output = factorialOfNum1 / factorialOfNum2;
            Console.WriteLine($"{output:f2}");
        }
    }
}
