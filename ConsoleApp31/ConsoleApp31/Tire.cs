using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp31
{
    public class Tire
    {
        public double Pressure { get; set; }
        public int Age { get; set; }
        public Tire(double tirePressure, int tireAge)
        {
            Pressure = tirePressure;
            Age = tireAge;
        }
    }
}
