using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet>data;
        public int Capacity { get; set; }

        public List<Pet> Data { get; set; }

        public Clinic(int capacity)
        {
            Data = new List<Pet>();
            Capacity = capacity;
           
        }

        public void Add(Pet pet)
        {
            if(Data.Count < Capacity)
            {
                Data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            if(Data.Any(x => x.Name == name))
            {
                Pet petToRemove = Data.Find(x => x.Name == name);
                Data.Remove(petToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Pet GetPet(string name, string owner)
        {
            Pet pet = Data.FirstOrDefault(x => x.Name == name && x.Owner == owner);
            return pet;
        }

        public int Count
        {
            get
            {
                return Data.Count;
            }
        }
        public Pet GetOldestPet()
        {
            Pet pet = Data.OrderByDescending(x => x.Age).FirstOrDefault();
            return pet;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach(var pet in Data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
