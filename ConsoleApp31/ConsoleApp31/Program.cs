using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp31
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for(int i = 0; i <numberOfCars; i++)
            {
                var info = Console.ReadLine().Split();
                var engine = new Engine(int.Parse(info[1]), int.Parse(info[2]));
                var cargo = new Cargo(int.Parse(info[3]), info[4]);
                var tires = new Tire[]
                {
                    new Tire(double.Parse(info[5]), int.Parse(info[6])),
                    new Tire(double.Parse(info[7]), int.Parse(info[8])),
                    new Tire(double.Parse(info[9]), int.Parse(info[10])),
                    new Tire(double.Parse(info[11]), int.Parse(info[12]))
                };
                cars.Add(new Car(info[0], engine, cargo, tires));
            }
            string type = Console.ReadLine();
            var filltered = new List<Car>();
            if(type == "fragile")
            {
                filltered = cars.Where(c => c.Cargo.Type == "fragile" && c.Tire.Any(t => t.Pressure < 1)).ToList();
            }
            else
            {
                filltered = cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250).ToList();
            }

            foreach(Car car in filltered)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
