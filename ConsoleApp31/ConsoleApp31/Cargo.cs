﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp31
{
    public class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }

        public Cargo(int cargoWeight, string cargoType)
        {
            Weight = cargoWeight;
            Type = cargoType;
        }
    }
}
