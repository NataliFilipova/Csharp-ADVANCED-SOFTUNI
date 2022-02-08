using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    public class Car
    {
        public string Model { get; set; }
        public decimal Fuel { get; set; }
        public decimal  Consumption{ get; set; }
        public decimal Trveled { get; set; }

        public Car(string model, decimal fuel, decimal consumption)
        {
            Model = model;
            Fuel = fuel;
            Consumption = consumption;
            Trveled = 0;
        }

        public void Drive (decimal distance)
        {
            decimal fuelNeed = distance * Consumption;
            if(Fuel >= fuelNeed)
            {
                Fuel -= fuelNeed;
                Trveled += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
