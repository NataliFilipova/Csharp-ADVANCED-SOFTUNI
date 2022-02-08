using System;
using System.Linq;

namespace ConsoleApp30
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new Car[n];

            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries); //splitting by space char[0] gives space
                var model = tokens[0];
                var fuelAmount = decimal.Parse(tokens[1]);
                var fuelCost = decimal.Parse(tokens[2]);
                cars[i] = new Car(model, fuelAmount, fuelCost);


            }

            while (true)
            {
                var input = Console.ReadLine();
                var tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                if (input == "End") 
                { 
                    break;
                }

                var model = tokens[1];
                decimal distance = decimal.Parse(tokens[2]);
                cars.Where(c => c.Model == model).ToList().ForEach(c => c.Drive(distance));
            }

            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.Trveled}");
            }
        }
    }
}
