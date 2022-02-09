using System;
using System.Linq;

namespace ConsoleApp38
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
               double stringValue = double.Parse(Console.ReadLine());
                    box.Items.Add(stringValue);

            }
            double comparatigItem = double.Parse(Console.ReadLine());
           int value = box.CountGreaterThan(comparatigItem);
           
            Console.WriteLine(value);
        }
        
    }
}
