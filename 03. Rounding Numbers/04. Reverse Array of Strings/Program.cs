using System;


namespace _07_VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            decimal sumCoins = 0.0m;
            decimal sumNeeded = 0.0m;
            decimal price = 0.0m;


            while (start != "Start")
            {

                decimal coins = decimal.Parse(start);
                if (coins == 0.1m || coins == 0.2m || coins == 0.5m || coins == 1.0m || coins == 2.0m)
                {
                    sumCoins += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                start = Console.ReadLine();
            }

            string nameProduct = Console.ReadLine();
            while (nameProduct != "End")
            {
                price = 0.0m;
                switch (nameProduct)
                {
                    case "Nuts":
                        price = 2.0m;
                        break;
                    case "Water":
                        price = 0.7m;
                        break;
                    case "Crisps":
                        price = 1.5m;
                        break;
                    case "Soda":
                        price = 0.8m;
                        break;
                    case "Coke":
                        price = 1.0m;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (price == 0.0m)
                {
                    break;
                }
                sumNeeded += price;
                if (sumNeeded > sumCoins)
                {
                    Console.WriteLine("Sorry, not enough money");
                    sumNeeded -= price;
                }
                else
                {
                    string lower = nameProduct.ToLower();
                    Console.WriteLine($"Purchased {lower}");

                }
                nameProduct = Console.ReadLine();
            }
            decimal moneyNeed = Math.Abs(sumNeeded - sumCoins);
            Console.WriteLine($"Change: {moneyNeed:f2}");
        }
    }
}
