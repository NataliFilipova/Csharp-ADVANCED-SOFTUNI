using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp38
{
    public class Box<T>
        where T: IComparable
    {
        

        public Box() {
            this.Items = new List<T>();
        }
        public List<T> Items { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in Items)
            {
                stringBuilder.AppendLine($"{typeof(T)}: {item}");
            }
            return stringBuilder.ToString();
        }

        public void Swap(int firstIndex, int secondIndex)
        { 
            T Item = Items[firstIndex];
            Items[firstIndex] = Items[secondIndex];
            Items[secondIndex] = Item;
        }

        public int CountGreaterThan(T itemToCompare)
        {
           

            int counter = 0;
            foreach(var item in Items)
            {
                if(item.CompareTo(itemToCompare) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
