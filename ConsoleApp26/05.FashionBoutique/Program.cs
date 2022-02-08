using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(arr);

            int capacityOfRack = int.Parse(Console.ReadLine());
            int sum = 0;
            int rack = 1;
            

            while (stack.Count > 0) 
            {
                int k = stack.Pop();

                if (sum + k < capacityOfRack)
                {
                    sum += k;
                }
                else if(sum + k == capacityOfRack)
                {
                    if (stack.Count != 0) 
                        {

                            rack = rack + 1;
                            sum = 0;
                        }
                   
                    
                }
                else if(sum + k > capacityOfRack)
                {
                   
                    
                    rack = rack + 1;
                    sum = 0;
                    sum += k;
                }

              
            }
            Console.WriteLine(rack);

        }
    }
}
