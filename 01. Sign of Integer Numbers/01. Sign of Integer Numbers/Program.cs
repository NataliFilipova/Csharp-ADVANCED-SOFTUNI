using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            int numItem = int.Parse(Console.ReadLine());
            Orders(item, numItem);
        }
        
        static void Orders(string item, int num)
        {
            double sum = 0;
            if(item == "coffe")
            {
                sum = num * 1.50;
                Console.WriteLine($"{sum:f2}");
            }
            else if(item == "water")
            {
                sum = num * 1.00;
                Console.WriteLine($"{sum:f2}");
            }
            else if (item == "coke")
            {
                sum = num * 1.40;
                Console.WriteLine($"{sum:f2}");
            }
            else if (item == "snacks")
            {
                sum = num * 2.00;
                Console.WriteLine($"{sum:f2}");
            }
        }
      
    }
}
