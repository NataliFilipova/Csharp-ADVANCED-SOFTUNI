using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> whoCame = new HashSet<string>(); 

            string command = Console.ReadLine();
            

            while(command != "PARTY")
            {
                if((char)command[0] > 48 && (char)command[0] < 58)
                {
                    vipGuests.Add(command);
                }
                else
                {
                    regularGuests.Add(command);
                }
                command = Console.ReadLine();
            }

            while(command != "END")
            {
                if (command != "PARTY")
                {
                    whoCame.Add(command);
                }
                 command = Console.ReadLine();
            }

            int peopleWhoDidntCome =  (vipGuests.Count + regularGuests.Count) - whoCame.Count;
            Console.WriteLine(peopleWhoDidntCome);

            foreach(var item in vipGuests)
            {
                bool flag = true;
                foreach(var item2 in whoCame)
                {
                    if(item == item2)
                    {
                        flag = false;
                    }
                }
                if(flag == true)
                {
                    Console.WriteLine(item);
                }
            }

            foreach (var item in regularGuests)
            {
                bool flag = true;
                foreach (var item2 in whoCame)
                {
                    if (item == item2)
                    {
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
