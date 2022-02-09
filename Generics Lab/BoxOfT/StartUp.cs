using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var box = new Box<int>();
            box.Add(1);
            Console.WriteLine(box.Count);
            box.Remove();
            Console.WriteLine(box.Count);
        }
    }
  
    
}
