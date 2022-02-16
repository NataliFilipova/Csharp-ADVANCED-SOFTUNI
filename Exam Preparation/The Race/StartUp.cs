using System;

namespace TheRace
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Race race = new Race("Indianapolis 500", 10);
            Car car1 = new Car("ferrari", 150);
            Car car2 = new Car("lambo", 170);

            Racer racer1 = new Racer("Stephen", 40, "Bulgaria", car1);
            Console.WriteLine(racer1);
        }
    }
}
