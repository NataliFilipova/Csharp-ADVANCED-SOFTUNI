using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return Data.Count;
            }

        }
        public List<Racer> Data { get; set; }
        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Data = new List<Racer>();
        }

        public void Add(Racer Racer)
        {
            if (Capacity > Data.Count)
            {
                Data.Add(Racer);
            }
        }

        public bool Remove(string name)
        {
            if (Data.Any(x => x.Name == name))
            {
                Racer racerToBeRemoved = Data.Find(x => x.Name == name);
                Data.Remove(racerToBeRemoved);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Racer GetOldestRacer()
        {
            Racer oldestRacer = Data.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestRacer;
        }

        public Racer GetRacer(string name)
        {
            Racer racerWithTheName = Data.Find(x => x.Name == name);
            return racerWithTheName;
        }

        public Racer GetFastestRacer()
        {
            Racer racerWithTheHighsetSpeed = Data.OrderByDescending(x => x.Car.Speed).FirstOrDefault();
            return racerWithTheHighsetSpeed;
        }

      
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");
            foreach (Racer racer in Data)
            {
                sb.AppendLine($"{racer}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
