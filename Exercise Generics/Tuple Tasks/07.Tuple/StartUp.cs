using System;

namespace _07.Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInput = Console.ReadLine().Split(' ');
            string[] beerInput = Console.ReadLine().Split(' ');
            string[] numbersInput = Console.ReadLine().Split(' ');

            string name = personInput[0] + " " + personInput[1];

            MyTuple<string, string, string> personInfo = new MyTuple<string, string, string>(name, personInput[2], personInput[3]);

            int liters = int.Parse(beerInput[1]);
            bool drunk = beerInput[2] == "drunk" ? true : false;
            MyTuple<string, int, bool> beerInfo = new MyTuple<string, int,bool> (beerInput[0], liters, drunk);

            
            double dbl = double.Parse(numbersInput[1]);
            MyTuple<string, double, string> numbersInfo = new MyTuple<string, double, string>(numbersInput[0], dbl, numbersInput[2]);

            Console.WriteLine(personInfo);
            Console.WriteLine(beerInfo);
            Console.WriteLine(numbersInfo);

        }
    }
}
